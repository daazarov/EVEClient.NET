using System.Threading.Tasks;

namespace EVEClient.NET.Pipline
{
    public delegate Task RequestDelegate(EsiContext context);
}
