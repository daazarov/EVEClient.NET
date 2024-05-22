using System;
using EVEOnline.ESI.Communication.Pipline;
using EVEOnline.ESI.Communication.Utilities.Stores;

namespace EVEOnline.ESI.Communication.Defaults
{
    internal class DefaultPiplineThreadSaveStore : IPiplineStore
    {
        private readonly ThreadSaveStore<string, IRequestPipline> _cache = new ThreadSaveStore<string, IRequestPipline>();

        public IRequestPipline GetPipline(string key, Func<string, IRequestPipline> getter)
        {
            return _cache.Get(key, getter);
        }
    }
}
