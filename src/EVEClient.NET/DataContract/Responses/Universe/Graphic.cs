using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Graphic
    {
        /// <summary>
        /// collision_file string
        /// </summary>
        [JsonProperty("collision_file")]
        public string? CollisionFile {  get; set; }

        /// <summary>
        /// graphic_file string
        /// </summary>
        [JsonProperty("graphic_file")]
        public string? GraphicFile { get; init; }

        /// <summary>
        /// graphic_id integer
        /// </summary>
        [JsonProperty("graphic_id")]
        public required int GraphicId { get; init; }

        /// <summary>
        /// icon_folder string
        /// </summary>
        [JsonProperty("icon_folder")]
        public string? IconFolder { get; init; }

        /// <summary>
        /// sof_dna string
        /// </summary>
        [JsonProperty("sof_dna")]
        public string? SofDna { get; init; }

        /// <summary>
        /// sof_fation_name string
        /// </summary>
        [JsonProperty("sof_fation_name")]
        public string? SofFationName { get; init; }

        /// <summary>
        /// sof_hull_name string
        /// </summary>
        [JsonProperty("sof_hull_name")]
        public string? SofHullName { get; init; }

        /// <summary>
        /// sof_race_name string
        /// </summary>
        [JsonProperty("sof_race_name")]
        public string? SofRaceName { get; init; }
    }
}
