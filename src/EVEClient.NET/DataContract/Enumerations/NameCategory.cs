using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
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
