using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderRange
    {
        [EnumMember(Value = "1")] Jumps_1,
        [EnumMember(Value = "10")] Jumps_10,
        [EnumMember(Value = "2")] Jumps_2,
        [EnumMember(Value = "20")] Jumps_20,
        [EnumMember(Value = "3")] Jumps_3,
        [EnumMember(Value = "30")] Jumps_30,
        [EnumMember(Value = "4")] Jumps_4,
        [EnumMember(Value = "40")] Jumps_40,
        [EnumMember(Value = "5")] Jumps_5,
        [EnumMember(Value = "region")] Region,
        [EnumMember(Value = "solarsystem")] Solarsystem,
        [EnumMember(Value = "station")] Station
    }
}
