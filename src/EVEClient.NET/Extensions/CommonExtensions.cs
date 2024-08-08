using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace EVEClient.NET.Extensions
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
                    nv.Add(keyValuePair.Key?.ToString(), keyValuePair.Value?.ToString());
                }
            }

            return nv;
        }

        public static IDictionary<TKey, TValue> Merge<TKey, TValue>(this IDictionary<TKey, TValue> @this, IDictionary<TKey, TValue>? target)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (target == null)
            {
                return @this;
            }
            else
            {
                return @this.ForEachMerge(target);
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

        public static string ToEsiString(this Enum @enum)
        {
            ArgumentNullException.ThrowIfNull(@enum);

            var enumString = @enum.ToString();

            if (enumString.TrySplit(",", out var splitedArray))
            {
                return string.Join(",", splitedArray.Select(x => @enum.ToEsiStringSingle(x.Trim())));
            }
            else
            {
                return @enum.ToEsiStringSingle(enumString);
            }
        }

        private static bool TrySplit(this string @this, string separator, [MaybeNullWhen(false)] out string[] splitedArray)
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

            if (string.IsNullOrEmpty(attribute?.Value))
            {
                throw new InvalidOperationException($"Can not convert enum to ESI string. Enum: { @this.ToString() }");
            }

            return attribute.Value;
        }
    }
}
