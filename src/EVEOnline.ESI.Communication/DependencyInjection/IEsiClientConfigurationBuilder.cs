using Microsoft.Extensions.DependencyInjection;
using EVEOnline.ESI.Communication.Configuration;

namespace EVEOnline.ESI.Communication.DependencyInjection
{
    public interface IEsiClientConfigurationBuilder
    {
        IServiceCollection ServiceCollection { get; }
        EsiClientConfiguration Configuration { get; }
    }
}
