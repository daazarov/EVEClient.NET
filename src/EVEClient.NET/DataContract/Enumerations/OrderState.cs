using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OrderState
    {
        Active,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "expired")] Expired
    }
}
