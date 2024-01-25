using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    public enum CalendarEventResponse
    {
        [EnumMember(Value = "declined")] Declined,
        [EnumMember(Value = "not_responded")] NotResponded,
        [EnumMember(Value = "accepted")] Accepted,
        [EnumMember(Value = "tentative")] Tentative
    }
}
