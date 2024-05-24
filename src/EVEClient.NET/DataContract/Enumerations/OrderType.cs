using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    public enum OrderType
    {
        [EnumMember(Value = "buy")] Buy,
        [EnumMember(Value = "sell")] Sell,
        [EnumMember(Value = "all")] All
    }
}
