using System;
using System.Text;
using System.Collections.Specialized;

using EVEClient.NET.Extensions;

namespace EVEClient.NET.Utilities
{
    internal class ETagStoreKeyGenerator
    {
        public static string GetKey(string endpointId)
        {
            return GetKey(endpointId, new NameValueCollection());
        }

        public static string GetKey(string endpointId, NameValueCollection routingParams)
        {
            return GetKey(endpointId, routingParams, new NameValueCollection());
        }

        public static string GetKey(string endpointId, NameValueCollection routingParams, NameValueCollection queryParams)
        {
            ArgumentNullException.ThrowIfNull(routingParams);
            ArgumentNullException.ThrowIfNull(queryParams);
            ArgumentNullException.ThrowIfNullOrEmpty(endpointId);

            var stringBuilder = new StringBuilder();

            stringBuilder.Append(endpointId);
            stringBuilder.Append(';');

            foreach (var key in routingParams.AllKeys)
            {
                stringBuilder.Append(string.Format("{0}={1};", key, routingParams.Get(key)));
            }

            foreach (var key in queryParams.AllKeys)
            {
                stringBuilder.Append(string.Format("{0}={1};", key, queryParams.Get(key)));
            }

            return stringBuilder.ToString().MD5();
        }
    }
}
