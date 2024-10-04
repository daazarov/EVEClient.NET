using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace EVEClient.NET.Utilities
{
    internal static class SerializerHelper
    {
        public static bool TryDeserializeObject<T>([DisallowNull] string value, [MaybeNullWhen(false)] out T? result)
        {
            try
            {
                if ((value.StartsWith("{") && value.EndsWith("}")) ||
                     value.StartsWith("[") && value.EndsWith("]"))
                {
                    result = JsonSerializer.Deserialize<T>(value);
                }
                else
                {
                    result = (T)Convert.ChangeType(value, typeof(T));
                }

                return true;
            }
            catch
            {
                result = default(T);
                return false;
            }
        }

        public static T? DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
        { 
            return JsonSerializer.Deserialize<T>(value);
        }
    }
}
