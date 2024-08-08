using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class IndustryFacility
    {
        /// <summary>
        /// ID of the facility
        /// </summary>
        [JsonProperty("facility_id")]
        public required long FacilityId { get; init; }

        /// <summary>
        /// Owner of the facility
        /// </summary>
        [JsonProperty("owner_id")]
        public required int OwnerId { get; init; }

        /// <summary>
        /// Region ID where the facility is
        /// </summary>
        [JsonProperty("region_id")]
        public required int RegionId { get; init; }

        /// <summary>
        /// Solar system ID where the facility is
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// Tax imposed by the facility
        /// </summary>
        [JsonProperty("tax")]
        public float? Tax { get; init; }

        /// <summary>
        /// Type ID of the facility
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }
}
