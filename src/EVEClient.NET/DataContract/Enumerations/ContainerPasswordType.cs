using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContainerPasswordType
    {
        [EnumMember(Value = "config")] Config,
        [EnumMember(Value = "general")] General
    }
}
