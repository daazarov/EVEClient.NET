using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication
{
    public interface IETagStorage
    {
        Task<bool> TryGetETagAsync(string eTagKey, out string eTag);
        Task StoreETagAsync(string eTagKey, string eTag);
        Task ReplaceETagAsync(string eTagKey, string eTag);
    }
}
