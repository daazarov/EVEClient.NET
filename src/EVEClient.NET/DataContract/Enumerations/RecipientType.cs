using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum RecipientType
    {
        [EnumMember(Value = "alliance")] Alliance,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "mailing_list")] MailingList
    }
}
