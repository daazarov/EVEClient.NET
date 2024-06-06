using EVEClient.NET.Configuration;
using EVEClient.NET.Pipline.Modifications;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IEsiClientConfigurationBuilder
    {
        IServiceCollection Services { get; }
        IPiplineModificationsBuilder PiplineModificationBuilder { get; }
        EsiClientConfiguration Configuration { get; }
    }
}
