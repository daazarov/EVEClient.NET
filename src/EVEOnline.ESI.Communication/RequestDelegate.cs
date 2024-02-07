using System.Threading.Tasks;

namespace EVEOnline.ESI.Communication
{
    internal delegate Task RequestDelegate(EsiContext context);
}
