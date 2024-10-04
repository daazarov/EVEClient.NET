using EVEClient.NET.Configuration;

namespace EVEClient.NET
{
    public interface IEndpointConfigurationProvider
    {
        EndpointConfiguration GetEndpointConfiguration(string endpointId);
    }
}
