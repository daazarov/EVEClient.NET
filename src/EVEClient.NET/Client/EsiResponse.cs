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
        /// <summary>
        /// Gets the <see cref="HttpStatusCode"/>.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets the <c>ETag</c> header value.
        /// </summary>
        /// <remarks>Entity Tags are described in RFC7232 <see href="https://tools.ietf.org/html/rfc7232"/>.</remarks>
        public string? ETag { get; }

        /// <summary>
        /// Gets the <see cref="HttpResponseMessage"/>.
        /// </summary>
        public HttpResponseMessage HttpResponseMessage { get; }

        /// <summary>
        /// Gets the <c>Expires</c> header value.
        /// </summary>
        public DateTime? Expires { get; }

        /// <summary>
        /// Gets the <c>Last-Modified</c> header value.
        /// </summary>
        public DateTime? LastModified { get; }

        /// <summary>
        /// Gets the EVE request ID.
        /// </summary>
        public Guid RequestId { get; }

        /// <summary>
        /// Holds failure information from the HTTP response.
        /// </summary>
        public List<string>? Errors { get; protected set; }

        /// <summary>
        /// Gets a value that indicates if the HTTP request to the EVE ESI was successfull.
        /// </summary>
        public bool Success => (HttpResponseMessage.IsSuccessStatusCode || StatusCode == HttpStatusCode.NotModified) && Errors == null;

        /// <summary>
        /// Can contain important information about endpoint routes deprication.
        /// </summary>
        public string? Warning { get; }

        /// <summary>
        /// How many more errors you can make within the window of time <see cref="ErrorLimitRemain"/>
        /// </summary>
        public int ErrorLimitRemain { get; }

        /// <summary>
        /// Number of seconds until the end of the current error window.
        /// </summary>
        public TimeSpan ErrorLimitReset { get; }

        public EsiResponse(HttpResponseMessage response)
        {
            HttpResponseMessage = response;

            if (response.Headers.Contains("X-ESI-Request-ID"))
            {
                RequestId = Guid.Parse(response.Headers.GetValues("X-ESI-Request-ID").First());
            }
            if (response.Headers.Contains("ETag"))
            {
                ETag = response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);
            }
            if (response.Content.Headers.Contains("Expires"))
            {
                Expires = DateTime.Parse(response.Content.Headers.GetValues("Expires").First());
            }
            if (response.Content.Headers.Contains("Last-Modified"))
            {
                LastModified = DateTime.Parse(response.Content.Headers.GetValues("Last-Modified").First());
            }
            if (response.Headers.Contains("Warning"))
            {
                Warning = response.Headers.GetValues("Warning").First();
            }
            if (response.Headers.Contains("X-ESI-Error-Limit-Remain"))
            {
                ErrorLimitRemain = int.Parse(response.Headers.GetValues("X-ESI-Error-Limit-Remain").First());
            }
            if (response.Headers.Contains("X-ESI-Error-Limit-Reset"))
            {
                ErrorLimitReset = TimeSpan.FromSeconds(int.Parse(response.Headers.GetValues("X-ESI-Error-Limit-Reset").First()));
            }

            StatusCode = response.StatusCode;

            if (!response.IsSuccessStatusCode && StatusCode.NotIn(HttpStatusCode.NotModified))
            {
                var result = response.Content.ReadAsStringAsync().Result;

                Errors = new List<string>()
                {
                    JsonConvert.DeserializeAnonymousType(result, new { error = "Unknown error." })?.error!
                };
            }
        }
    }
}
