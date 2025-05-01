using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum IncursionState
    {
        [EnumMember(Value = "withdrawing")] Withdrawing,
        [EnumMember(Value = "mobilizing")] Mobilizing,
        [EnumMember(Value = "established")] Established
    }
}
