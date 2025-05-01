using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ServiceState
    {
        [EnumMember(Value = "online")] Online,
        [EnumMember(Value = "offline")] Offline,
        [EnumMember(Value = "cleanup")] Cleanup
    }
}
