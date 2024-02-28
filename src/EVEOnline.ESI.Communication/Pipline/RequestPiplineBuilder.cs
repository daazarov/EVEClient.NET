using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Pipline
{
    internal class RequestPiplineBuilder : IRequestPiplineBuilder
    {
        private readonly IList<Func<RequestDelegate, RequestDelegate>> _components = new List<Func<RequestDelegate, RequestDelegate>>();
        private readonly IServiceProvider _serviceProvider;

        public IServiceProvider ServiceProvider => _serviceProvider;

        public RequestPiplineBuilder(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IRequestPipline Build()
        {
            RequestDelegate middleware = context => Task.CompletedTask;

            foreach (var component in _components.Reverse())
            {
                middleware = component(middleware);
            }

            return new RequestPipline(middleware);
        }

        public IRequestPiplineBuilder Use(Func<RequestDelegate, RequestDelegate> middleware)
        {
            _components.Add(middleware);

            return this;
        }

        public IRequestPiplineBuilder Clear()
        {
            _components.Clear();

            return this;
        }
    }
}
