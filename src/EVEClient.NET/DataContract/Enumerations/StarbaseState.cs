﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StarbaseState
    {
        [EnumMember(Value = "offline")] Offline,
        [EnumMember(Value = "online")] Online,
        [EnumMember(Value = "onlining")] Onlining,
        [EnumMember(Value = "reinforced")] Reinforced,
        [EnumMember(Value = "unanchoring")] Unanchoring
    }
}
