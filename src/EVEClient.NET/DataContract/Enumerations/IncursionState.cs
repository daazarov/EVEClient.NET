using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncursionState
    {
        [EnumMember(Value = "withdrawing")] Withdrawing,
        [EnumMember(Value = "mobilizing")] Mobilizing,
        [EnumMember(Value = "established")] Established
    }
}
