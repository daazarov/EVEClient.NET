using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OwnerType
    {
        [EnumMember(Value = "eve_server")] EVEServer,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "faction")] Faction,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "alliance")] Alliance
    }
}
