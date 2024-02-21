using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    public enum OrderType
    {
        [EnumMember(Value = "buy")] Buy,
        [EnumMember(Value = "sell")] Sell,
        [EnumMember(Value = "all")] All
    }
}
