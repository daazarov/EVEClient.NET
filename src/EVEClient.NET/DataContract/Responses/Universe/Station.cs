using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Station
    {
        /// <summary>
        /// max_dockable_ship_volume number
        /// </summary>
        [JsonProperty("max_dockable_ship_volume")]
        public required float MaxDockableShipVolume { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// office_rental_cost number
        /// </summary>
        [JsonProperty("office_rental_cost")]
        public required float OfficeRentalCost { get; init; }

        /// <summary>
        /// ID of the corporation that controls this station
        /// </summary>
        [JsonProperty("owner")]
        public int? Owner { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonProperty("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonProperty("race_id")]
        public int? RaceId { get; init; }

        /// <summary>
        /// reprocessing_efficiency number
        /// </summary>
        [JsonProperty("reprocessing_efficiency")]
        public required float ReprocessingEfficiency { get; init; }

        /// <summary>
        /// reprocessing_stations_take number
        /// </summary>
        [JsonProperty("reprocessing_stations_take")]
        public required float ReprocessingStationsTake { get; init; }

        /// <summary>
        /// services array
        /// </summary>
        [JsonProperty("services")]
        public required List<Service> Services { get; init; }

        /// <summary>
        /// station_id integer
        /// </summary>
        [JsonProperty("station_id")]
        public required int StationId { get; init; }

        /// <summary>
        /// The solar system this station is in
        /// </summary>
        [JsonProperty("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public required int TypeId { get; init; }
    }
}
