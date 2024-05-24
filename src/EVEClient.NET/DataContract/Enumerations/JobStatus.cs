using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
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
