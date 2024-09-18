using System;
using System.Collections.Generic;
using System.Net;

namespace EVEClient.NET
{
    public abstract class EsiResponse : IDisposable
    {
        /// <summary>
        /// Gets the <see cref="HttpStatusCode"/>.
        /// </summary>
        public abstract HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets the <c>ETag</c> header value.
        /// </summary>
        /// <remarks>Entity Tags are described in RFC7232 <see href="https://tools.ietf.org/html/rfc7232"/>.</remarks>
        public abstract string? ETag { get; }

        /// <summary>
        /// Gets the <c>Expires</c> header value.
        /// </summary>
        public abstract DateTime? Expires { get; }

        /// <summary>
        /// Gets the <c>Last-Modified</c> header value.
        /// </summary>
        public abstract DateTime? LastModified { get; }

        /// <summary>
        /// Gets the EVE request ID.
        /// </summary>
        public abstract Guid RequestId { get; }

        /// <summary>
        /// Holds failure information from the HTTP response.
        /// </summary>
        public abstract List<string>? Errors { get; }

        /// <summary>
        /// Gets a value that indicates if the HTTP request to the EVE ESI was successfull.
        /// </summary>
        public abstract bool Success { get; }

        /// <summary>
        /// Can contain important information about endpoint routes deprication.
        /// </summary>
        public abstract string? Warning { get; }

        /// <summary>
        /// How many more errors you can make within the window of time <see cref="ErrorLimitRemain"/>
        /// </summary>
        public abstract int ErrorLimitRemain { get; }

        /// <summary>
        /// Number of seconds until the end of the current error window.
        /// </summary>
        public abstract TimeSpan ErrorLimitReset { get; }

        /// <summary>
        /// Gets the total count of pages if applicable.
        /// </summary>
        public abstract int? TotalPages { get; }

        public abstract void Dispose();
    }
}
