using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication
{
    public interface IAccessTokenProvider
    {
        Task<string> GetAccessToken();
    }
}
