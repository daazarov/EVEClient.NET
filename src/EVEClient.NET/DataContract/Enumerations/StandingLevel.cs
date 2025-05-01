using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum StandingLevel
    {
        [EnumMember(Value = "bad")] Bad,
        [EnumMember(Value = "excellent")] Excellent,
        [EnumMember(Value = "good")] Good,
        [EnumMember(Value = "neutral")] Neutral,
        [EnumMember(Value = "terrible")] Terrible
    }
}
