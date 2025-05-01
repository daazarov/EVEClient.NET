using Microsoft.Extensions.Options;

namespace EVEClient.NET.Configuration
{
    internal class EnshureEndpointsConfigurationPostConfigure : IPostConfigureOptions<EsiClientConfiguration>
    {
        public void PostConfigure(string? name, EsiClientConfiguration options)
        {
            foreach (var kpv in ESI.Endpoints.Configurations.Default)
            {
                options.TryAddEndpointConfiguration(kpv.Key, kpv.Value);
            }
        }
    }
}
