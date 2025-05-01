using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum StandingType
    {
        [EnumMember(Value = "agent")] Agent,
        [EnumMember(Value = "npc_corp")] NpcCorporation,
        [EnumMember(Value = "faction")] Faction
    }
}
