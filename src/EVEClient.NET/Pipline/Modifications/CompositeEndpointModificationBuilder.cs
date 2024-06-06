using System;
using System.Linq;
using System.Collections.Generic;

namespace EVEClient.NET.Pipline.Modifications
{
    internal class CompositeEndpointModificationBuilder : IEndpointModificationBuilder
    {
        private readonly List<IEndpointModificationBuilder> _childs;

        public CompositeEndpointModificationBuilder(IEnumerable<IEndpointModificationBuilder> childs)
        {
            _childs = childs.ToList();
        }

        public IEndpointModificationBuilder AdditionalHandler<CustomHandler>(string addAfter = null, bool addedToEnd = false, bool addedToStart = false, int? endOrder = null, int? startOrder = null)
            where CustomHandler : IHandler
        {
            _childs.ForEach(x => x.AdditionalHandler<CustomHandler>(addAfter, addedToEnd, addedToStart, endOrder, startOrder));
            return this;
        }

        public IEndpointModificationBuilder AdditionalMiddleware(string componentId, Func<RequestDelegate, RequestDelegate> middleware, string addAfter = null, bool addedToEnd = false, bool addedToStart = false, int? endOrder = null, int? startOrder = null)
        {
            _childs.ForEach(x => x.AdditionalMiddleware(componentId, middleware, addAfter, addedToEnd, addedToStart, endOrder, startOrder));
            return this;
        }

        public IEndpointModificationBuilder ReplaceHandler<CustomHandler>(string replacingComponentId) where CustomHandler : IHandler
        {
            _childs.ForEach(x => x.ReplaceHandler<CustomHandler>(replacingComponentId));
            return this;
        }

        public IEndpointModificationBuilder ReplaceHandler<CustomHandler>(Type replacingComponentType) where CustomHandler : IHandler
        {
            _childs.ForEach(x => x.ReplaceHandler<CustomHandler>(replacingComponentType));
            return this;
        }

        public IEndpointModificationBuilder ReplaceHandler<CustomHandler, ReplacingHandler>()
            where CustomHandler : IHandler
            where ReplacingHandler : IHandler
        {
            _childs.ForEach(x => x.ReplaceHandler<CustomHandler, ReplacingHandler>());
            return this;
        }
    }
}
