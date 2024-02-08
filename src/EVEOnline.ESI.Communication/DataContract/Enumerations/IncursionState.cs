using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncursionState
    {
        [EnumMember(Value = "withdrawing")] Withdrawing,
        [EnumMember(Value = "mobilizing")] Mobilizing,
        [EnumMember(Value = "established")] Established
    }
}
