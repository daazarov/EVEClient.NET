using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace EVEClient.NET
{
    public interface IETagStorage
    {
        /// <summary>
        /// Try to provides the cached ETag header value for specific request.
        /// </summary>
        /// <param name="eTagKey">The unique identifier of specific parameterized request.</param>
        /// <param name="eTag">The ETag header value.</param>
        Task<bool> TryGetETagAsync(string eTagKey, [MaybeNullWhen(false)] out string eTag);

        /// <summary>
        /// Store the ETag header value in the storage.
        /// </summary>
        /// <param name="eTagKey">The unique identifier of specific parameterized request.</param>
        /// <param name="eTag">The ETag header value.</param>
        Task StoreETagAsync(string eTagKey, string eTag);
    }
}