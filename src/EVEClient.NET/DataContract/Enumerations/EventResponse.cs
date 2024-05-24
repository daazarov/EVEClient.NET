using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventResponse
    {
        [EnumMember(Value = "declined")] Declined,
        [EnumMember(Value = "accepted")] Accepted,
        [EnumMember(Value = "tentative")] Tentative
    }
}
