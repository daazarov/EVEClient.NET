using System.Text;
using System.Collections.Specialized;

using EVEOnline.Esi.Communication.Extensions;

namespace EVEOnline.Esi.Communication.Utilities
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
            endpointId.ArgumentStringNotNullOrEmpty(nameof(endpointId));
            routingParams.ArgumentNotNull(nameof(routingParams));
            queryParams.ArgumentNotNull(nameof(queryParams));

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
