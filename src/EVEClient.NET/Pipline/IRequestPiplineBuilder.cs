using System;

namespace EVEClient.NET.Pipline
{
    internal interface IRequestPiplineBuilder
    {
        IServiceProvider ServiceProvider { get; }

        IRequestPiplineBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
        IRequestPiplineBuilder Clear();
        IRequestPipline Build();
    }
}
