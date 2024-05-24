using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "private")] Private
    }
}
