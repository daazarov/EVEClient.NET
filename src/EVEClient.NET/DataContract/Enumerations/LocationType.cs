using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationType
    {
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "solar_system")] SolarSystem,
        [EnumMember(Value = "item")] Item,
        [EnumMember(Value = "other")] Other
    }
}
