using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum Status
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "private")] Private
    }
}
