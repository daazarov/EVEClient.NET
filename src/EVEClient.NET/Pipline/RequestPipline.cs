using System.Collections.Generic;
using System.Threading.Tasks;

namespace EVEClient.NET.Pipline
{
    internal class RequestPipline : IRequestPipline
    {
        private readonly RequestDelegate _middleware;

#if DEBUG
        private readonly List<PiplineComponent> _components;

        public RequestPipline(RequestDelegate middleware, List<PiplineComponent> components)
        {
            _middleware = middleware;
            _components = components;
        }
#else
        public RequestPipline(RequestDelegate middleware)
        {
            _middleware = middleware;
        }
#endif

        public async Task<EsiContext> ExecuteAsync(EsiContext context)
        {
            await _middleware.Invoke(context);

            return context;
        }
    }
}
