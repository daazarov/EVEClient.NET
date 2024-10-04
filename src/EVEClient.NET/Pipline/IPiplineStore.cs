using System.Threading.Tasks;

namespace EVEClient.NET.Pipline
{
    /// <summary>
    /// Defines a class that stores cached middleware for ESI endpoints.
    /// </summary>
    internal interface IPiplineStore
    {
        /// <summary>
        /// Provides the ESI endpoint request middleware.
        /// </summary>
        /// <param name="endpointId">The ESI endpoint id from <see cref="ESI.Endpoints"/>.</param>
        /// <param name="methodType">
        /// The <see cref="HttpMethodType"/> which will be used to get the default execution pipline
        /// if no custom pipline was found for the specified <paramref name="endpointId"/>.
        /// </param>
        /// <returns>The <see cref="IRequestPipline"/>.</returns>
        Task<IRequestPipline> GetPiplineAsync(string endpointId, HttpMethodType methodType);
    }
}
