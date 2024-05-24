using System.Threading.Tasks;
using EVEClient.NET.Pipline;

namespace EVEClient.NET
{
    public interface IHandler
    {
        Task HandleAsync(EsiContext context, RequestDelegate next);
    }
}
