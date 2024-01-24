using Microsoft.Extensions.DependencyInjection;
using EVEOnline.Esi.Communication.Configuration;

namespace EVEOnline.Esi.Communication.DependencyInjection
{
    public interface IEsiClientConfigurationBuilder
    {
        IServiceCollection ServiceCollection { get; }
        EsiClientConfiguration Configuration { get; }
    }
}
