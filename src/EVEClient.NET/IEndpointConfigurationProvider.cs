using EVEClient.NET.Configuration;

namespace EVEClient.NET
{
    public interface IEndpointConfigurationProvider
    {
        EndpointConfiguration GetConfiguration(string endpointId);
        bool Exists(string endpointId);
    }
}
