using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NameCategory
    {
        [EnumMember(Value = "alliance")] Alliance,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "constellation")] Constellation,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "inventory_type")] InventoryType,
        [EnumMember(Value = "region")] Region,
        [EnumMember(Value = "solar_system")] SolarSystem,
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "faction")] Faction
    }
}
