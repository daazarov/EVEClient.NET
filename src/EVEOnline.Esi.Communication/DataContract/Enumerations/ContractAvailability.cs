using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum ContractAvailability
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "personal")] Personal,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "alliance")] Alliance
    }
}
