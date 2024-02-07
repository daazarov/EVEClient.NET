﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        [EnumMember(Value = "female")] Female,
        [EnumMember(Value = "male")] Male
    }
}
