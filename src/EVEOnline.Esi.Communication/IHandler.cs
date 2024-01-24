using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication
{
    internal interface IHandler
    {
        Task HandleAsync(EsiContext context, RequestDelegate next);
    }
}
