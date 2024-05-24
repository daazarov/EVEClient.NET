/*
Sketches for a separate Polly extension


using System.Collections.Generic;

namespace EVEClient.NET
{
    public interface ICustomEndpointRoutePriorityProvider
    {
        /// <summary>
        /// Returns a collection of routes that the client will attempt to execute the request.
        /// <paramref name="endpointId"/> is unique endpoint name from <see cref="ESI.Endpoints"/>
        /// </summary>
        IEnumerable<EndpointRoutePrioritySetting> GetRoutePrioritiesForEndpoint(string endpointId);
    }
}
*/