using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using Newtonsoft.Json;

using EVEClient.NET.Extensions;

namespace EVEClient.NET
{
    public class EsiResponse
    {
        private readonly string _eTag;
        private readonly string _warning;
        private readonly Guid _requestId;
        private readonly HttpResponseMessage _httpResponseMessage;
        private readonly HttpStatusCode _statusCode;
        private readonly DateTime? _expires;
        private readonly DateTime? _lastModified;
        private readonly int _errorLimitRemain;
        private readonly TimeSpan _errorLimitReset;
        private readonly List<string> _errors;

        public HttpStatusCode StatusCode => _statusCode;
        public string ETag => _eTag;
        public HttpResponseMessage HttpResponseMessage => _httpResponseMessage;
        public DateTime? Expires => _expires;
        public DateTime? LastModified => _lastModified;
        public Guid RequestId => _requestId;
        public List<string> Errors => _errors;
        public bool Success => Errors == null;
        public string Warning => _warning;

        /// <summary>
        /// How many more errors you can make within the window of time <see cref="ErrorLimitRemain"/>
        /// </summary>
        public int ErrorLimitRemain => _errorLimitRemain;

        /// <summary>
        /// Number of seconds until the end of the current error window.
        /// </summary>
        public TimeSpan ErrorLimitReset => _errorLimitReset;
        
        public EsiResponse(HttpResponseMessage response)
        {
            _httpResponseMessage = response;

            if (response.Headers.Contains("X-ESI-Request-ID"))
            {
                _requestId = Guid.Parse(response.Headers.GetValues("X-ESI-Request-ID").First());
            }
            if (response.Headers.Contains("ETag"))
            {
                _eTag = response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);
            }
            if (response.Content.Headers.Contains("Expires"))
            {
                _expires = DateTime.Parse(response.Content.Headers.GetValues("Expires").First());
            }
            if (response.Content.Headers.Contains("Last-Modified"))
            {
                _lastModified = DateTime.Parse(response.Content.Headers.GetValues("Last-Modified").First());
            }
            if (response.Headers.Contains("Warning"))
            {
                _warning = response.Headers.GetValues("Warning").First();
            }
            if (response.Headers.Contains("X-ESI-Error-Limit-Remain"))
            {
                _errorLimitRemain = int.Parse(response.Headers.GetValues("X-ESI-Error-Limit-Remain").First());
            }
            if (response.Headers.Contains("X-ESI-Error-Limit-Reset"))
            {
                _errorLimitReset = TimeSpan.FromSeconds(int.Parse(response.Headers.GetValues("X-ESI-Error-Limit-Reset").First()));
            }

            _statusCode = response.StatusCode;

            if (!response.IsSuccessStatusCode && _statusCode.NotIn(HttpStatusCode.NotModified))
            {
                var result = response.Content.ReadAsStringAsync().Result;

                _errors = new List<string>()
                {
                    JsonConvert.DeserializeAnonymousType(result, new { error = string.Empty }).error
                };
            }
        }
    }
}
