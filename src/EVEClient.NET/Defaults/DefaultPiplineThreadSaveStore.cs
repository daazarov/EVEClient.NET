using System;
using EVEClient.NET.Pipline;
using EVEClient.NET.Utilities.Stores;

namespace EVEClient.NET.Defaults
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
