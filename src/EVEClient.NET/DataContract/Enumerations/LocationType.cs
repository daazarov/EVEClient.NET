using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum LocationType
    {
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "solar_system")] SolarSystem,
        [EnumMember(Value = "item")] Item,
        [EnumMember(Value = "other")] Other
    }
}
