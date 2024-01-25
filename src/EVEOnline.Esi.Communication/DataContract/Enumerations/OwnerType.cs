using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum OwnerType
    {
        [EnumMember(Value = "eve_server")] EVEServer,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "faction")] Faction,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "alliance")] Alliance
    }
}
