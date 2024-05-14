using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Station
    {
        /// <summary>
        /// max_dockable_ship_volume number
        /// </summary>
        [JsonProperty("max_dockable_ship_volume")]
        public float MaxDockableShipVolume {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// office_rental_cost number
        /// </summary>
        [JsonProperty("office_rental_cost")]
        public float OfficeRentalCost { get; set; }

        /// <summary>
        /// ID of the corporation that controls this station
        /// </summary>
        [JsonProperty("owner")]
        public int? Owner {  get; set; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int? RaceId { get; set; }

        /// <summary>
        /// reprocessing_efficiency number
        /// </summary>
        [JsonProperty("reprocessing_efficiency")]
        public float ReprocessingEfficiency { get; set; }

        /// <summary>
        /// reprocessing_stations_take number
        /// </summary>
        [JsonProperty("reprocessing_stations_take")]
        public float ReprocessingStationsTake { get; set; }

        /// <summary>
        /// services array
        /// </summary>
        [JsonProperty("services")]
        public List<Service> Services { get; set; }

        /// <summary>
        /// station_id integer
        /// </summary>
        [JsonProperty("station_id")]
        public int StationId { get; set; }

        /// <summary>
        /// The solar system this station is in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
