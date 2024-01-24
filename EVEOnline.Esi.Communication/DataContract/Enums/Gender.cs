using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum Gender
    {
        [EnumMember(Value = "female")] Female,
        [EnumMember(Value = "male")] Male
    }
}
