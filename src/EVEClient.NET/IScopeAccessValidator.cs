using System.Threading.Tasks;

namespace EVEClient.NET
{
    /// <summary>
    /// Defines a class which validates that the EVE access token contains the necessary scope.
    /// </summary>
    public interface IScopeAccessValidator
    {
        /// <summary>
        /// Performs validation.
        /// </summary>
        /// <param name="token">An EVE access token.</param>
        /// <param name="scope">An EVE scope to validate.</param>
        public Task<bool> ValidateScopeAccess(string token, string scope);
    }
}
