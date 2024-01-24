using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum Status
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "private")] Private
    }
}
