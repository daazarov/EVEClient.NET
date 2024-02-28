using System;

namespace EVEOnline.ESI.Communication.Pipline
{
    internal interface IRequestPiplineBuilder
    {
        IServiceProvider ServiceProvider { get; }

        IRequestPiplineBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
        IRequestPiplineBuilder Clear();
        IRequestPipline Build();
    }
}
