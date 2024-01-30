using System.Linq;
using System.Web;
using System.Collections.Specialized;

namespace EVEOnline.Esi.Communication.Utilities
{
    internal class UrlQueryBuilder
    {
        public static string BuildRouteString(string template, NameValueCollection collection)
        {
            var url = template;
            
            foreach (var key in collection.AllKeys)
            {
                url = url.Replace($"{{{key}}}", collection.Get(key));
            }

            return url;
        }

        public static string BuildQueryString(string url, NameValueCollection collection)
        {
            if (collection.Count == 0)
            {
                return url;
            }
            
            return string.Concat(url, BuildQueryString(collection));
        }

        private static string BuildQueryString(NameValueCollection collection)
        {
            var array = (
                from key in collection.AllKeys
                from value in collection.GetValues(key)
                select string.Format(
                    "{0}={1}",
                    HttpUtility.UrlEncode(key),
                    HttpUtility.UrlEncode(value))
                ).ToArray();

            return string.Concat("?", string.Join("&", array));
        }
    }
}
