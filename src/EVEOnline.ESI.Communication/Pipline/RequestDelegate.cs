using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication.Pipline
{
    public delegate Task RequestDelegate(EsiContext context);
}
