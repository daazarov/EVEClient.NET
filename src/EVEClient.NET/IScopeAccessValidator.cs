using System.Threading.Tasks;

namespace EVEClient.NET
{
    public interface IScopeAccessValidator
    {
        public Task<bool> ValidateScopeAccess(string token, string scope);
    }
}
