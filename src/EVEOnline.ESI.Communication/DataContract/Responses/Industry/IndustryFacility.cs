using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class IndustryFacility
    {
        /// <summary>
        /// ID of the facility
        /// </summary>
        [JsonProperty("facility_id")]
        public long FacilityId { get; set; }

        /// <summary>
        /// Owner of the facility
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Region ID where the facility is
        /// </summary>
        [JsonProperty("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// Solar system ID where the facility is
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// Tax imposed by the facility
        /// </summary>
        [JsonProperty("tax")]
        public float? Tax { get; set; }

        /// <summary>
        /// Type ID of the facility
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
