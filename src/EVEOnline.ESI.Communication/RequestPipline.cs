﻿using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    internal class RequestPipline : IRequestPipline
    {
        private readonly RequestDelegate _middleware;
        
        public RequestPipline(RequestDelegate middleware)
        { 
            _middleware = middleware;
        }

        public async Task<EsiContext> ExecuteAsync(EsiContext context)
        {
            await _middleware.Invoke(context);

            return context;
        }
    }
}
