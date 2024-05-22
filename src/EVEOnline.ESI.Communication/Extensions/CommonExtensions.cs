using EVEOnline.ESI.Communication.DataContract;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.Extensions
{
    internal static class CommonExtensions
    {
        public static bool In<T>(this T @this, params T[] items)
        {
            return items.Contains(@this);
        }

        public static bool NotIn<T>(this T @this, params T[] items)
        {
            return !items.Contains(@this);
        }

        public static T ArgumentNotNull<T>(this T @this, string parameterName) where T : class
        {
            if (@this == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            return @this;
        }

        public static NameValueCollection AsNameValueCollection<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> @this)
        {
            var nv = new NameValueCollection();

            if (@this != null)
            {
                foreach (var keyValuePair in @this)
                {
                    string value = null;

                    if (keyValuePair.Value != null)
                    {
                        value = keyValuePair.Value.ToString();
                    }

                    nv.Add(keyValuePair.Key.ToString(), value);
                }
            }

            return nv;
        }

        public static IDictionary<TKey, TValue> Merge<TKey, TValue>(this IDictionary<TKey, TValue> @this, Func<IDictionary<TKey, TValue>> getter)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }
            
            var result = getter.Invoke();

            if (result == null)
            {
                return @this;
            }
            else
            {
                return @this.ForEachMerge(result);
            }
        }

        public static IDictionary<TKey, TValue> ForEachMerge<TKey, TValue>(this IDictionary<TKey, TValue> @this, IDictionary<TKey, TValue> target)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            foreach (var keyValuePair in target)
            {
                if (!@this.ContainsKey(keyValuePair.Key))
                {
                    @this[keyValuePair.Key] = keyValuePair.Value;
                }
            }

            return @this;
        }

        public static string ToEsiString(this Enum @this)
        {
            if (@this == null)
            {
                return null;
            }
            
            var enumString = @this.ToString();

            if (enumString.TrySplit(",", out var splitedArray))
            {
                return string.Join(",", splitedArray.Select(x => @this.ToEsiStringSingle(x.Trim())));
            }
            else
            {
                return @this.ToEsiStringSingle(enumString);
            }
        }

        private static bool TrySplit(this string @this, string separator, out string[] splitedArray)
        {
            splitedArray = null;

            if (@this.Contains(separator))
            {
                splitedArray = @this.Split(separator);
                return true;
            }

            return false;
        }

        private static string ToEsiStringSingle(this Enum @this, string value)
        {
            var type = @this.GetType();
            var typeInfo = type.GetTypeInfo();
            var memberInfo = typeInfo.DeclaredMembers.SingleOrDefault(x => x.Name.Equals(value, StringComparison.OrdinalIgnoreCase));
            var attribute = memberInfo?.GetCustomAttribute<EnumMemberAttribute>(false);

            return attribute?.Value;
        }
    }
}
