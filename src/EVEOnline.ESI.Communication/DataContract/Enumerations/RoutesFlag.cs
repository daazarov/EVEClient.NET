using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    public enum RoutesFlag
    {
        [EnumMember(Value = "shortest")] Shortest,
        [EnumMember(Value = "secure")] Secure,
        [EnumMember(Value = "insecure")] Insecure
    }
}
