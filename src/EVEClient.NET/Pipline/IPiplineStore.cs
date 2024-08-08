using System;

namespace EVEClient.NET.Pipline
{
    /// <summary>
    /// Defines a class that stores cached middleware for ESI endpoints.
    /// </summary>
    internal interface IPiplineStore
    {
        /// <summary>
        /// Provides the ESI endpoint request middleware.
        /// </summary>
        /// <param name="marker">The <see cref="EndpointMarker"/> witch associated with specific ESI endpoint.</param>
        /// <returns>The <see cref="IRequestPipline"/>.</returns>
        IRequestPipline GetPipline(EndpointMarker marker);
    }
}
