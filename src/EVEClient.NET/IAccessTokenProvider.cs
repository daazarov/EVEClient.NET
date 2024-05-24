using System.Threading.Tasks;

namespace EVEClient.NET
{
    public interface IAccessTokenProvider
    {
        Task<string> RequestAccessToken();
    }
}
