using System;

namespace EVEOnline.ESI.Communication.Utilities.Stores
{
    internal static class PiplineThreadSaveStore<T>
    {
        private static readonly ThreadSaveStore<string, IRequestPipline> _cache = new ThreadSaveStore<string, IRequestPipline>();

        public static IRequestPipline GetPipline(string key, Func<string, IRequestPipline> getter)
        {
            return _cache.Get(key, getter);
        }
    }
}
