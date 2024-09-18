using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace EVEClient.NET
{
    internal class EsiStreamResponseDefault<T> : EsiStreamResponse<T>
    {
        private int? _totalPages;
        private HttpStatusCode _statusCode;
        private bool _success;
        private string? _eTag;
        private DateTime? _expires;
        private DateTime? _lastModified;
        private Guid _requestId;
        private string? _warning;
        private int _errorLimitRemain;
        private TimeSpan _errorLimitReset;
        private List<string>? _errors;

        public override int? TotalPages => _totalPages;

        public override HttpStatusCode StatusCode => _statusCode;

        public override string? ETag => _eTag;

        public override DateTime? Expires => _expires;

        public override DateTime? LastModified => _lastModified;

        public override Guid RequestId => _requestId;

        public override string? Warning => _warning;

        public override int ErrorLimitRemain => _errorLimitRemain;

        public override TimeSpan ErrorLimitReset => _errorLimitReset;

        public override bool Success => _success;

        public override List<string>? Errors => _errors;

        internal EsiStreamResponseDefault(Func<int, Task<EsiResponsePagination<List<T>>>> executor, int pageOffset, int pageLimit, int pageSize, CancellationToken cancellationToken = default)
            : base(executor, pageOffset, pageLimit, pageSize, cancellationToken)
        {
        }

        public override bool TryGetData([NotNullWhen(true)] out IAsyncEnumerable<T>? data, [NotNullWhen(false)] out string? errorMessage)
        {
            data = default;
            errorMessage = default;

            // we ok, if the response was created without initialization, just return the stream
            if (!_initialized)
            {
                data = Stream;
                return true;
            }

            switch (StatusCode)
            { 
                case HttpStatusCode.OK:
                    data = Stream;
                    return true;
                // This shouldn't happen since we disable eTag for stream requests, but just in case, let's check it out
                case HttpStatusCode.NotModified:
                    errorMessage = "No results can be returned because the server returned the NotModified http status code for initial request.";
                    return false;
                default:
                    errorMessage = Errors?.FirstOrDefault() ?? "Unknown error.";
                    return false;
            }
        }

        protected override void InitialSetter(EsiResponse response)
        {
            _warning = response.Warning;
            _eTag = response.ETag;
            _success = response.Success;
            _errorLimitReset = response.ErrorLimitReset;
            _errorLimitRemain = response.ErrorLimitRemain;
            _expires = response.Expires;
            _errors = response.Errors;
            _lastModified = response.LastModified;
            _requestId = response.RequestId;
            _statusCode = response.StatusCode;
            _totalPages = response.TotalPages;
        }
    }
}
