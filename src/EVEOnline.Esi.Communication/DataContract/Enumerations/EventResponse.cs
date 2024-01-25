using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum EventResponse
    {
        [EnumMember(Value = "declined")] Declined,
        [EnumMember(Value = "accepted")] Accepted,
        [EnumMember(Value = "tentative")] Tentative
    }
}
