using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OwnerType
    {
        [EnumMember(Value = "eve_server")] EVEServer,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "faction")] Faction,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "alliance")] Alliance
    }
}
