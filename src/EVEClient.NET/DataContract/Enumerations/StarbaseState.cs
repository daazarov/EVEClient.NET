using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum StarbaseState
    {
        [EnumMember(Value = "offline")] Offline,
        [EnumMember(Value = "online")] Online,
        [EnumMember(Value = "onlining")] Onlining,
        [EnumMember(Value = "reinforced")] Reinforced,
        [EnumMember(Value = "unanchoring")] Unanchoring
    }
}
