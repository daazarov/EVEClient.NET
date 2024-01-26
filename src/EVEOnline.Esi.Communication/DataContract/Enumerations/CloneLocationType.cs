using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum CloneLocationType
    {
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "structure")] Structure
    }
}
