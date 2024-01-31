﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContainerPasswordType
    {
        [EnumMember(Value = "config")] Config,
        [EnumMember(Value = "general")] General
    }
}
