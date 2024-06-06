using System;

namespace EVEClient.NET.Pipline
{
    internal interface IPiplineStore
    {
        IRequestPipline GetPipline(EndpointMarker point);
    }
}
