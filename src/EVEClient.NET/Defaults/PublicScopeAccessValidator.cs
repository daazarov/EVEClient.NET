using System;
using System.Threading.Tasks;

namespace EVEClient.NET.Defaults
{
    internal class PublicScopeAccessValidator : IScopeAccessValidator
    {
        public Task<bool> ValidateScopeAccess(string token, string scope)
        {
            throw new InvalidOperationException("This provider is designed to call only public esi endpoints.");
        }
    }
}
