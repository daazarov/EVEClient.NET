using System;
using EVEClient.NET.Requests;

namespace EVEClient.NET.Extensions
{
    public static class ParametersExtensions
    {
        public static void EnshureDatabaseSource(this Parameters parameters, string value)
        {
            ArgumentNullException.ThrowIfNull(parameters);
            ArgumentNullException.ThrowIfNullOrEmpty(value);
            
            if (!parameters.Query.ContainsKey(ESI.Parameters.Query.Datasource))
            {
                parameters.Query[ESI.Parameters.Query.Datasource] = value;
            }
        }
    }
}
