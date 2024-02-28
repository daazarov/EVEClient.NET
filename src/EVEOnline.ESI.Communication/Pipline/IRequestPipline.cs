using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Pipline
{
    internal interface IRequestPipline
    {
        Task<EsiContext> ExecuteAsync(EsiContext context);
    }
}
