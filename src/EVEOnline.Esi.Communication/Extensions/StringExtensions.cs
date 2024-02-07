using System;

using EVEOnline.ESI.Communication.Utilities.Hashing;

namespace EVEOnline.ESI.Communication.Extensions
{
    internal static class StringExtensions
    {
        public static string ArgumentStringNotNullOrEmpty(this string @this, string parameterName)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrWhiteSpace(@this))
            {
                throw new ArgumentNullException(parameterName);
            }

            return @this;
        }

        public static string MD5(this string @this)
        {
            return HashingFactory.Instance.CreateHashingInstance(HashingAliases.MD5).GenerateHash(@this);
        }

        public static string SHA256(this string @this)
        {
            return HashingFactory.Instance.CreateHashingInstance(HashingAliases.SHA256).GenerateHash(@this);
        }
    }
}
