using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    internal interface IRequestPipline
    {
        Task<EsiContext> ExecuteAsync(EsiContext context);
    }
}
