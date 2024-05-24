using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    public enum RoutesFlag
    {
        [EnumMember(Value = "shortest")] Shortest,
        [EnumMember(Value = "secure")] Secure,
        [EnumMember(Value = "insecure")] Insecure
    }
}
