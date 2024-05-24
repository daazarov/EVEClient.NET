using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecipientType
    {
        [EnumMember(Value = "alliance")] Alliance,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "mailing_list")] MailingList
    }
}
