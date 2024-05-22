using EVEOnline.ESI.Communication.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IEsiClientConfigurationBuilder
    {
        IServiceCollection Services { get; }
        EsiClientConfiguration Configuration { get; }
    }
}
