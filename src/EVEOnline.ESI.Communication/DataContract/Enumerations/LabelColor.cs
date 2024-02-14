using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LabelColor
    {
        [EnumMember(Value = "#0000fe")] Blue,
        [EnumMember(Value = "#006634")] Green,
        [EnumMember(Value = "#0099ff")] DodjerBlue,
        [EnumMember(Value = "#00ff33")] LightGreen,
        [EnumMember(Value = "#01ffff")] Aqua,
        [EnumMember(Value = "#349800")] LaPalma,
        [EnumMember(Value = "#660066")] Purple,
        [EnumMember(Value = "#666666")] Gray,
        [EnumMember(Value = "#999999")] LightGray,
        [EnumMember(Value = "#99ffff")] ElectricBlue,
        [EnumMember(Value = "#9a0000")] DarkRed,
        [EnumMember(Value = "#ccff9a")] Reef,
        [EnumMember(Value = "#e6e6e6")] Whisper,
        [EnumMember(Value = "#fe0000")] Red,
        [EnumMember(Value = "#ff6600")] Orange,
        [EnumMember(Value = "#ffff01")] Yellow,
        [EnumMember(Value = "#ffffcd")] Cream,
        [EnumMember(Value = "#ffffff")] White
    }
}
