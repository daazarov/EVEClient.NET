using System;

namespace EVEOnline.ESI.Communication.Pipline
{
    internal interface IPiplineStore
    {
        IRequestPipline GetPipline(string key, Func<string, IRequestPipline> getter);
    }
}
