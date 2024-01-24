using EVEOnline.Esi.Communication.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace EVEOnline.Esi.Communication
{
    public class EsiResponse
    {
        private readonly string _eTag;
        private readonly Guid _requestId;
        private readonly HttpResponseMessage _httpResponseMessage;
        private readonly HttpStatusCode _statusCode;
        private readonly DateTime? _date;
        private readonly DateTime? _expires;
        private readonly DateTime? _lastModified;
        private readonly IEnumerable<string> _errors;

        protected Exception _exception;

        public HttpStatusCode StatusCode => _statusCode;
        public string ETag => _eTag;        
        public HttpResponseMessage HttpResponseMessage => _httpResponseMessage;
        public DateTime? Date => _date;
        public DateTime? Expires => _expires;
        public DateTime? LastModified => _lastModified;
        public Guid RequestId => _requestId;
        public Exception Exception => _exception;
        public IEnumerable<string> Errors => _errors;
        public bool Success => !Errors.Any() && Exception == null;

        public EsiResponse(Exception exception)
        {
            _exception = exception;
        }
        
        public EsiResponse(HttpResponseMessage response)
        {
            _httpResponseMessage = response;
            
            try 
            {
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
                if (response.Content.Headers.Contains("Date"))
                {
                    _date = DateTime.Parse(response.Content.Headers.GetValues("Date").First());
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
            catch (Exception ex)
            { 
                _exception = ex;
            }
        }
    }
}
