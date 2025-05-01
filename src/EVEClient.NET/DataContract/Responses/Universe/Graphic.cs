using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Graphic
    {
        /// <summary>
        /// collision_file string
        /// </summary>
        [JsonPropertyName("collision_file")]
        public string? CollisionFile { get; init; }

        /// <summary>
        /// graphic_file string
        /// </summary>
        [JsonPropertyName("graphic_file")]
        public string? GraphicFile { get; init; }

        /// <summary>
        /// graphic_id integer
        /// </summary>
        [JsonPropertyName("graphic_id")]
        public required int GraphicId { get; init; }

        /// <summary>
        /// icon_folder string
        /// </summary>
        [JsonPropertyName("icon_folder")]
        public string? IconFolder { get; init; }

        /// <summary>
        /// sof_dna string
        /// </summary>
        [JsonPropertyName("sof_dna")]
        public string? SofDna { get; init; }

        /// <summary>
        /// sof_fation_name string
        /// </summary>
        [JsonPropertyName("sof_fation_name")]
        public string? SofFationName { get; init; }

        /// <summary>
        /// sof_hull_name string
        /// </summary>
        [JsonPropertyName("sof_hull_name")]
        public string? SofHullName { get; init; }

        /// <summary>
        /// sof_race_name string
        /// </summary>
        [JsonPropertyName("sof_race_name")]
        public string? SofRaceName { get; init; }
    }
}
