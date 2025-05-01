using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ContractType
    {
        [EnumMember(Value = "unknown")] Unknown,
        [EnumMember(Value = "item_exchange")] ItemExchange,
        [EnumMember(Value = "auction")] Auction,
        [EnumMember(Value = "courier")] Courier,
        [EnumMember(Value = "loan")] Loan
    }
}
