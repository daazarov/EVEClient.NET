using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace EVEClient.NET.Defaults
{
    internal class DefaultInMemoryETagThreadSaveStore : IETagStorage
    {
        private readonly ConcurrentDictionary<string, string> _store = new ConcurrentDictionary<string, string>();

        public Task StoreETagAsync(string eTagKey, string eTag)
        {
            _store.AddOrUpdate(eTagKey, eTag, (key, oldValue) => eTag);

            return Task.CompletedTask;
        }

        public Task<bool> TryGetETagAsync(string eTagKey, [MaybeNullWhen(false)] out string eTag)
        {
            if (_store.TryGetValue(eTagKey, out var value))
            {
                eTag = value;
                return Task.FromResult(true);
            }

            eTag = null!;
            return Task.FromResult(false);
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
