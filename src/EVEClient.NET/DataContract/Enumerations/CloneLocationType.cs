using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CloneLocationType
    {
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "structure")] Structure
    }
}
