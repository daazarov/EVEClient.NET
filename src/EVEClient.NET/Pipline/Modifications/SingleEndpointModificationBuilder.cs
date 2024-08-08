using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

using EVEClient.NET.Extensions;

namespace EVEClient.NET.Pipline.Modifications
{
    internal class SingleEndpointModificationBuilder : IEndpointModificationBuilder
    {
        private readonly PiplineModification _modification;
        private readonly PiplineModificationsBuilder _bulder;

        public SingleEndpointModificationBuilder(PiplineModification modification, PiplineModificationsBuilder bulder)
        {
            _modification = modification;
            _bulder = bulder;
        }

        public IEndpointModificationBuilder AdditionalHandler<CustomHandler>(string? addAfter = null, bool addToEnd = false, bool addToStart = false, int? endOrder = null, int? startOrder = null)
            where CustomHandler : IHandler
        {
            var componentId = typeof(CustomHandler).Name;
            var middleware = CreateMiddleware<CustomHandler>();

            return AdditionalMiddleware(componentId, middleware, addAfter, addToEnd, addToStart, endOrder, startOrder);
        }

        public IEndpointModificationBuilder AdditionalMiddleware(string componentId, Func<RequestDelegate, RequestDelegate> middleware, string? addAfter = null,  bool addToEnd = false, bool addToStart = false, int? endOrder = null, int? startOrder = null)
        {
            componentId.ArgumentStringNotNullOrEmpty(nameof(componentId));

            var component = new AdditionalComponent
            {
                PiplineComponent = new PiplineComponent(componentId, middleware),
                AddToEnd = addToEnd,
                AddToStart = addToStart,
                AddAfter = addAfter,
                EndOrder = endOrder,
                StartOrder = startOrder
            };

            if (_bulder.AddedComponentIds.TryGetValue(_modification.EndpointId, out var componentIds))
            {
                componentIds.Add(componentId);
            }
            else
            {
                _bulder.AddedComponentIds.Add(_modification.EndpointId, new List<string> { componentId });
            }

            _modification.Additions.Add(component);

            return this;
        }

        public IEndpointModificationBuilder ReplaceHandler<CustomHandler, ReplacingHandler>()
            where CustomHandler : IHandler
            where ReplacingHandler : IHandler
        {
            return ReplaceHandler<CustomHandler>(typeof(ReplacingHandler));
        }

        public IEndpointModificationBuilder ReplaceHandler<CustomHandler>(Type replacingComponentType) where CustomHandler : IHandler
        {
            return ReplaceHandler<CustomHandler>(replacingComponentType.Name);
        }

        public IEndpointModificationBuilder ReplaceHandler<CustomHandler>(string replacingComponentId) where CustomHandler : IHandler
        {
            var componentId = typeof(CustomHandler).Name;
            var middleware = CreateMiddleware<CustomHandler>();

            var component = new ReplaceComponent
            {
                PiplineComponent = new PiplineComponent(componentId, middleware),
                ReplaceId = replacingComponentId
            };

            _modification.Replacements.Add(component);

            return this;
        }

        private Func<RequestDelegate, RequestDelegate> CreateMiddleware<CustomHandler>() where CustomHandler : IHandler
        { 
            return next =>
            {
                return context =>
                {
                    var handler = context.ScopedServices.GetRequiredService<CustomHandler>();
                    return handler.HandleAsync(context, next);
                };
            };
        }
    }
}
