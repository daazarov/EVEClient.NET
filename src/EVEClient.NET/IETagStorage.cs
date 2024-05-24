using System.Threading.Tasks;

namespace EVEClient.NET
{
    public interface IETagStorage
    {
        Task<bool> TryGetETagAsync(string eTagKey, out string eTag);
        Task StoreETagAsync(string eTagKey, string eTag);
    }
}
