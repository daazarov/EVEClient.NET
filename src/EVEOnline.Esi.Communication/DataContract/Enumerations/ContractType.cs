using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum ContractType
    {
        [EnumMember(Value = "unknown")] Unknown,
        [EnumMember(Value = "item_exchange")] ItemExchange,
        [EnumMember(Value = "auction")] Auction,
        [EnumMember(Value = "courier")] Courier,
        [EnumMember(Value = "loan")] Loan
    }
}
