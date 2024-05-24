using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceState
    {
        [EnumMember(Value = "online")] Online,
        [EnumMember(Value = "offline")] Offline,
        [EnumMember(Value = "cleanup")] Cleanup
    }
}
