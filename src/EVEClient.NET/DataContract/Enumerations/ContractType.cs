using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContractType
    {
        [EnumMember(Value = "unknown")] Unknown,
        [EnumMember(Value = "item_exchange")] ItemExchange,
        [EnumMember(Value = "auction")] Auction,
        [EnumMember(Value = "courier")] Courier,
        [EnumMember(Value = "loan")] Loan
    }
}
