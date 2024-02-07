﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CalendarEventResponse
    {
        [EnumMember(Value = "declined")] Declined,
        [EnumMember(Value = "not_responded")] NotResponded,
        [EnumMember(Value = "accepted")] Accepted,
        [EnumMember(Value = "tentative")] Tentative
    }
}
