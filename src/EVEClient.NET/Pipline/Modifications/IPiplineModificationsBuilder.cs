using System;

namespace EVEClient.NET.Pipline.Modifications
{
    public interface IPiplineModificationsBuilder
    {
        /// <summary>
        /// Defines a modification builder for a specific endpoint ID from <see cref="ESI.Endpoints"/>
        /// </summary>
        /// <example>
        /// RuleFor(ESI.Endpoints.Characters.PublicInformation)...
        /// </example>
        IEndpointModificationBuilder ModificationFor(string endpointId);

        /// <summary>
        /// Defines a modification builder for a specific endpoint IDs from <see cref="ESI.Endpoints"/>
        /// </summary>
        IEndpointModificationBuilder ModificationFor(string[] endpointIds);

        /// <summary>
        /// Defines a modification builder for endpoints satisfying the selected selector.
        /// </summary>
        IEndpointModificationBuilder ModificationFor(EndpointsSelector selector);
    }

    [Flags]
    public enum EndpointsSelector
    {
        GetRequests = 1,
        PostRequests = 2,
        PutRequests = 4,
        DeleteRequests = 8,
        AllRequests = 16
    }
}
