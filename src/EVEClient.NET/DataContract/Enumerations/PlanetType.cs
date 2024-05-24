using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlanetType
    {
        [EnumMember(Value = "temperate")] Temperate,
        [EnumMember(Value = "barren")] Barren,
        [EnumMember(Value = "oceanic")] Oceanic,
        [EnumMember(Value = "ice")] Ice,
        [EnumMember(Value = "gas")] Gas,
        [EnumMember(Value = "lava")] Lava,
        [EnumMember(Value = "storm")] Storm,
        [EnumMember(Value = "plasma")] Plasma
    }
}
