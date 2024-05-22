using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    public interface IETagStorage
    {
        Task<bool> TryGetETagAsync(string eTagKey, out string eTag);
        Task StoreETagAsync(string eTagKey, string eTag);
    }
}
