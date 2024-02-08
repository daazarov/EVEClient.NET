﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "private")] Private
    }
}