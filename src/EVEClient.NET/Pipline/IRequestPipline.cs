using System.Threading.Tasks;

namespace EVEClient.NET.Pipline
{
    /// <summary>
    /// Defines a class that contains a delegate function that can process an ESI HTTP request
    /// </summary>
    internal interface IRequestPipline
    {
        /// <summary>
        /// Execute the compiled ESI enpoint middleware.
        /// </summary>
        /// <param name="context">The ESI context <see cref="EsiContext"/> for the request.</param>
        /// <returns></returns>
        Task<EsiContext> ExecuteAsync(EsiContext context);
    }
}
