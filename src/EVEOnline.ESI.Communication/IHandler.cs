using System.Threading.Tasks;
using EVEOnline.ESI.Communication.Pipline;

namespace EVEOnline.ESI.Communication
{
    public interface IHandler
    {
        Task HandleAsync(EsiContext context, RequestDelegate next);
    }
}
