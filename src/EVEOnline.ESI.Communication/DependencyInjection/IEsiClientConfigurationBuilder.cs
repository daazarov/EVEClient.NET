using EVEOnline.ESI.Communication.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IEsiClientConfigurationBuilder
    {
        IServiceCollection ServiceCollection { get; }
        EsiClientConfiguration Configuration { get; }
    }
}
