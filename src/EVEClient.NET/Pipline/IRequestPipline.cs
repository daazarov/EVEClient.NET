using System.Threading.Tasks;

namespace EVEClient.NET.Pipline
{
    internal interface IRequestPipline
    {
        Task<EsiContext> ExecuteAsync(EsiContext context);
    }
}
