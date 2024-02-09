﻿using System;
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

        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> @this)
        {
            if (@this == null)
            {
                return Enumerable.Empty<T>();
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
            var result = getter.Invoke();

            if (result == null)
            {
                return @this;
            }
            else if (@this == null && result != null)
            {
                return result;
            }
            else
            {
                return @this.ForEachMerge(result);
            }
        }

        public static IDictionary<TKey, TValue> ForEachMerge<TKey, TValue>(this IDictionary<TKey, TValue> @this, IDictionary<TKey, TValue> target)
        {
            if (@this != null)
            {
                foreach (var keyValuePair in target)
                {
                    if (!@this.ContainsKey(keyValuePair.Key))
                    {
                        @this[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }

            return @this;
        }

        public static string ToEsiString(this Enum @this)
        {
            var type = @this.GetType();
            var typeInfo = type.GetTypeInfo();
            var memberInfo = typeInfo.DeclaredMembers.SingleOrDefault(x => x.Name == @this.ToString());
            var attribute = memberInfo?.GetCustomAttribute<EnumMemberAttribute>(false);

            return attribute?.Value;
        }
    }
}
