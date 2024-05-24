using System;

namespace EVEClient.NET.Pipline
{
    internal interface IPiplineStore
    {
        IRequestPipline GetPipline(string key, Func<string, IRequestPipline> getter);
    }
}
