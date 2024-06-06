using EVEClient.NET.Models;

namespace EVEClient.NET
{
    internal interface IEsiContextFactory
    {
        EsiContext CreateContext(EndpointMarker marker);
        EsiContext CreateContext(EndpointMarker marker, IRequestModel requestModel);
    }
}
