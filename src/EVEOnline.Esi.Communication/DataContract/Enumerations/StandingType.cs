using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum StandingType
    {
        [EnumMember(Value = "agent")] Agent,
        [EnumMember(Value = "npc_corp")] NpcCorporation,
        [EnumMember(Value = "faction")] Faction
    }
}
