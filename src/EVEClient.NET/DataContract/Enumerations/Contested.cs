using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Contested
    {
        [EnumMember(Value = "captured")] Captured,
        [EnumMember(Value = "contested")] Contested,
        [EnumMember(Value = "uncontested")] Uncontested,
        [EnumMember(Value = "vulnerable")] Vulnerable
    }
}
