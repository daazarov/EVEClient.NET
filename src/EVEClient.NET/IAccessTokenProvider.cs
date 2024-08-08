using System.Threading.Tasks;

namespace EVEClient.NET
{
    /// <summary>
    ///  Defines JWT token provider that will be use in protection middleware.
    /// </summary>
    public interface IAccessTokenProvider
    {
        /// <summary>
        /// Gets the JWT token issued by an ESI SSO.
        /// </summary>
        Task<string> RequestAccessToken();
    }
}
