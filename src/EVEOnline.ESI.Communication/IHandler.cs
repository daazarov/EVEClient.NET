using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    internal interface IHandler
    {
        Task HandleAsync(EsiContext context, RequestDelegate next);
    }
}
