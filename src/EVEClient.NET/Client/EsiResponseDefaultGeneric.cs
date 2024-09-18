using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;

using EVEClient.NET.Extensions;

using Newtonsoft.Json;

namespace EVEClient.NET
{
    public class EsiResponseDefaultGeneric<T> : EsiResponse<T>
    {
        private T? _cachedData;
        private readonly List<string>? _errors;

        private readonly HttpResponseMessage _response;

        public override HttpStatusCode StatusCode
        {
            get => _response.StatusCode;
        }

        public override string? ETag
        {
            get
            {
                if (_response.Headers.Contains("ETag"))
                {
                    return _response.Headers.GetValues("ETag").First().Replace("\"", string.Empty);
                }
                return null;
            }
        }

        public override DateTime? Expires
        {
            get
            {
                if (_response.Content.Headers.Contains("Expires"))
                {
                    return DateTime.Parse(_response.Content.Headers.GetValues("Expires").First());
                }
                return null;
            }
        }

        public override DateTime? LastModified
        {
            get
            {
                if (_response.Content.Headers.Contains("Last-Modified"))
                {
                    return DateTime.Parse(_response.Content.Headers.GetValues("Last-Modified").First());
                }
                return null;
            }
        }

        public override Guid RequestId
        {
            get => Guid.Parse(_response.Headers.GetValues("X-ESI-Request-ID").First());
        }

        public override bool Success
        {
            get => _response.IsSuccessStatusCode || StatusCode == HttpStatusCode.NotModified;
        }

        public override string? Warning
        {
            get
            {
                if (_response.Headers.Contains("Warning"))
                {
                    return _response.Headers.GetValues("Warning").First();
                }
                return null;
            }
        }

        public override int ErrorLimitRemain
        {
            get => int.Parse(_response.Headers.GetValues("X-ESI-Error-Limit-Remain").First());
        }

        public override TimeSpan ErrorLimitReset
        {
            get => TimeSpan.FromSeconds(int.Parse(_response.Headers.GetValues("X-ESI-Error-Limit-Reset").First()));
        }

        [Obsolete("The Data propery is obsolete and will be removed in the near future. Use TryGetData method instead.")]
        public override T? Data
        {
            get
            { 
                if (TryGetData(out var data, out _)) return data;
                return default;
            }
        }

        public override int? TotalPages
        {
            get
            {
                if (_response.Headers.Contains("X-Pages"))
                {
                    return int.Parse(_response.Headers.GetValues("X-Pages").First());
                }
                return null;
            }
        }

        public override List<string>? Errors
        {
            get => _errors;
        }

        public EsiResponseDefaultGeneric(HttpResponseMessage response)
        {
            ArgumentNullException.ThrowIfNull(response);

            _response = response;

            if (!Success)
            {
                var result = GetStringContent(_response.Content);
                _errors = new List<string>()
                {
                    JsonConvert.DeserializeAnonymousType(result, new { error = "Unknown error." })?.error!
                };
            }
        }

        public override bool TryGetData([NotNullWhen(true)] out T? data, [NotNullWhen(false)] out string? errorMessage)
        {
            data = default;
            errorMessage = default;

            if (_cachedData != null)
            { 
                data = _cachedData;
                return true;
            }

            if (!Success)
            {
                errorMessage = $"Failed HTTP response. Http status code: {StatusCode}. Error message: {_errors?.First()}";
                return false;
            }

            if (StatusCode == HttpStatusCode.NotModified)
            {
                errorMessage = "No results can be returned because the server returned the NotModified http status code.";
                return false;
            }

            var result = GetStringContent(_response.Content);
            try
            {
                if (result.IsPotentiallyJson())
                {
                    _cachedData = JsonConvert.DeserializeObject<T>(result) ?? throw new JsonSerializationException();
                }
                else
                {
                    _cachedData = (T)Convert.ChangeType(result, typeof(T));
                }

                data = _cachedData;
                return true;
            }
            catch
            {
                errorMessage = $"Failed to deserializa/convert response data. Model type: {typeof(T).Name}; Response data: {result}";
                return false;
            }
        }

        public override void Dispose()
        {
            Dispose(true);
        }

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _response.Dispose();
                }

                _disposedValue = true;
            }
        }

        private string GetStringContent(HttpContent httpContent)
        {
            using (var stream = _response.Content.ReadAsStream())
            using (var reader = new StreamReader(stream))
            { 
                return reader.ReadToEnd();
            }
        }
    }
}
