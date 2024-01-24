using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum LocationType
    {
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "solar_system")] SolarSystem,
        [EnumMember(Value = "item")] Item,
        [EnumMember(Value = "other")] Other
    }
}
