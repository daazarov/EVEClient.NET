using System;
using System.Diagnostics.CodeAnalysis;

namespace EVEClient.NET
{
    public abstract class EsiResponse<T> : EsiResponse
    {
        /// <summary>
        /// Gets the deserialized response data.
        /// </summary>
        [Obsolete("The Data propery is obsolete and will be removed in the near future. Use TryGetData method instead.")]
        public abstract T? Data { get; }

        /// <summary>
        /// Determines whether the esi request was successful and makes the returned data available for use when it is.
        /// </summary>
        /// <param name="data">The <see cref="T"/> if the request was successful.</param>
        /// <param name="errorMessage">The message.</param>
        /// <returns><c>true</c> when the esi request is successful and <see cref="System.Net.HttpStatusCode"/> not equal NotModified; <c>false</c> otherwise.</returns>
        public abstract bool TryGetData([NotNullWhen(true)] out T? data, [NotNullWhen(false)] out string? errorMessage);
    }
}
