using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    public interface IAccessTokenProvider
    {
        Task<string> GetAccessToken();
    }
}
