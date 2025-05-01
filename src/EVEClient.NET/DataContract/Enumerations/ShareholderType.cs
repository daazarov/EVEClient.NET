using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ShareholderType
    {
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "corporation")] Corporation
    }
}
