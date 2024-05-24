using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StandingLevel
    {
        [EnumMember(Value = "bad")] Bad,
        [EnumMember(Value = "excellent")] Excellent,
        [EnumMember(Value = "good")] Good,
        [EnumMember(Value = "neutral")] Neutral,
        [EnumMember(Value = "terrible")] Terrible
    }
}
