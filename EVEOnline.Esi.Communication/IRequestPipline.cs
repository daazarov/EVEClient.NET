using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication
{
    internal interface IRequestPipline
    {
        Task<EsiContext> ExecuteAsync(EsiContext context);
    }
}
