using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Defaults
{
    internal class DefaultInMemoryETagThreadSaveStore : IETagStorage
    {
        private readonly ConcurrentDictionary<string, string> _store = new ConcurrentDictionary<string, string>();

        public Task StoreETagAsync(string eTagKey, string eTag)
        {
            _store.AddOrUpdate(eTagKey, eTag, (key, oldValue) => eTag);

            return Task.CompletedTask;
        }

        public Task<bool> TryGetETagAsync(string eTagKey, out string eTag)
        {
            return Task.FromResult(_store.TryGetValue(eTagKey, out eTag));
        }

        /// <summary>
        /// For tests porpouse only
        /// </summary>
        internal void Clear()
        {
            _store.Clear();
        }
    }
}
