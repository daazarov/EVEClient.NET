using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Contested
    {
        [EnumMember(Value = "captured")] Captured,
        [EnumMember(Value = "contested")] Contested,
        [EnumMember(Value = "uncontested")] Uncontested,
        [EnumMember(Value = "vulnerable")] Vulnerable
    }
}
