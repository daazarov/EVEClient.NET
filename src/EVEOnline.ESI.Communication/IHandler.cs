using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    public interface IHandler
    {
        Task HandleAsync(EsiContext context, RequestDelegate next);
    }
}
