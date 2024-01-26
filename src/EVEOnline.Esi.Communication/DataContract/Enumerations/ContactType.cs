using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum ContactType
    {
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "alliance")] Alliance,
        [EnumMember(Value = "faction")] Faction
    }
}
