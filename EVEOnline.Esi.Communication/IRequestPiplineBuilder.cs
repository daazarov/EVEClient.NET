using System;

namespace EVEOnline.Esi.Communication
{
    internal interface IRequestPiplineBuilder
    {
        IServiceProvider ServiceProvider { get; }

        IRequestPiplineBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
        IRequestPipline Build();
    }
}
