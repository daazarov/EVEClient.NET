using EVEClient.NET.Models;

namespace EVEClient.NET
{
    internal interface IEsiContextFactory
    {
        EsiContext CreateContext(EndpointMarker marker, string? token);
        EsiContext CreateContext(EndpointMarker marker, IRequestModel requestModel, string? token);
    }
}
