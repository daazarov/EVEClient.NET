using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum JobStatus
    {
        [EnumMember(Value = "active")] Active,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "delivered")] Delivered,
        [EnumMember(Value = "paused")] Paused,
        [EnumMember(Value = "ready")] Ready,
        [EnumMember(Value = "reverted")] Reverted
    }
}
