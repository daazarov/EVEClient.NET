using System;

using EVEClient.NET.Utilities.Hashing;

namespace EVEClient.NET.Extensions
{
    public static class StringExtensions
    {
        public static string ArgumentStringNotNullOrEmpty(this string @this, string parameterName)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrWhiteSpace(@this))
            {
                throw new ArgumentNullException(parameterName);
            }

            return @this;
        }

        public static string EnsureLeadingSlash(this string url)
        {
            if (!string.IsNullOrEmpty(url) && !url.StartsWith("/"))
            {
                return "/" + url;
            }

            return url;
        }

        public static string MD5(this string value)
        {
            return HashingFactory.Instance.CreateHashingInstance(HashingAliases.MD5).GenerateHash(value);
        }

        public static string SHA256(this string @this)
        {
            return HashingFactory.Instance.CreateHashingInstance(HashingAliases.SHA256).GenerateHash(@this);
        }
    }
}
