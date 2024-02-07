using System.Collections.Generic;

namespace EVEOnline.ESI.Communication
{
    public interface ICustomEndpointRoutePriorityProvider
    {
        /// <summary>
        /// Returns a collection of routes that the client will attempt to execute the request.
        /// "endpointId" - id from <see cref="ESI.Endpoints"/>
        /// </summary>
        IEnumerable<EndpointRoutePrioritySetting> GetRoutePrioritiesForEndpoint(string endpointId);
    }
}
