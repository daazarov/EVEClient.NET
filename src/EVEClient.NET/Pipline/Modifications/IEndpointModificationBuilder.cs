using System;

namespace EVEClient.NET.Pipline.Modifications
{
    public interface IEndpointModificationBuilder
    {
        IEndpointModificationBuilder ReplaceHandler<CustomHandler>(string replacingComponentId)
            where CustomHandler : IHandler;

        IEndpointModificationBuilder ReplaceHandler<CustomHandler>(Type replacingComponentType)
            where CustomHandler : IHandler;

        IEndpointModificationBuilder ReplaceHandler<CustomHandler, ReplacingHandler>()
            where CustomHandler : IHandler
            where ReplacingHandler : IHandler;

        IEndpointModificationBuilder AdditionalHandler<CustomHandler>(string addAfter = null, bool addToEnd = false, bool addToStart = false, int? endOrder = null, int? startOrder = null)
            where CustomHandler : IHandler;

        IEndpointModificationBuilder AdditionalMiddleware(string componentId, Func<RequestDelegate, RequestDelegate> middleware, string addAfter = null, bool addToEnd = false, bool addToStart = false, int? endOrder = null, int? startOrder = null);

    }
}
