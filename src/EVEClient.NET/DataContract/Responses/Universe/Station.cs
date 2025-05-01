using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Station
    {
        /// <summary>
        /// max_dockable_ship_volume number
        /// </summary>
        [JsonPropertyName("max_dockable_ship_volume")]
        public required float MaxDockableShipVolume { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// office_rental_cost number
        /// </summary>
        [JsonPropertyName("office_rental_cost")]
        public required float OfficeRentalCost { get; init; }

        /// <summary>
        /// ID of the corporation that controls this station
        /// </summary>
        [JsonPropertyName("owner")]
        public int? Owner { get; init; }

        /// <summary>
        /// position object
        /// </summary>
        [JsonPropertyName("position")]
        public required Position Position { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>
        [JsonPropertyName("race_id")]
        public int? RaceId { get; init; }

        /// <summary>
        /// reprocessing_efficiency number
        /// </summary>
        [JsonPropertyName("reprocessing_efficiency")]
        public required float ReprocessingEfficiency { get; init; }

        /// <summary>
        /// reprocessing_stations_take number
        /// </summary>
        [JsonPropertyName("reprocessing_stations_take")]
        public required float ReprocessingStationsTake { get; init; }

        /// <summary>
        /// services array
        /// </summary>
        [JsonPropertyName("services")]
        public required List<Service> Services { get; init; }

        /// <summary>
        /// station_id integer
        /// </summary>
        [JsonPropertyName("station_id")]
        public required int StationId { get; init; }

        /// <summary>
        /// The solar system this station is in
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
