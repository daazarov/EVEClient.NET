using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    public interface IScopeAccessValidator
    {
        public Task<bool> VerifyScopeAccess(string scope);
    }
}
