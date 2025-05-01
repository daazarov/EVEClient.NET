using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ContractAvailability
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "personal")] Personal,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "alliance")] Alliance
    }
}
