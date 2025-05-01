using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterIndustryJob
    {
        /// <summary>
        /// Job activity ID
        /// </summary>
        [JsonPropertyName("activity_id")]
        public required int ActivityId { get; init; }

        /// <summary>
        /// blueprint_id integer
        /// </summary>
        [JsonPropertyName("blueprint_id")]
        public required long BlueprintId { get; init; }

        /// <summary>
        /// Location ID of the location from which the blueprint was installed.
        /// Normally a station ID, but can also be an asset (e.g. container) or corporation facility
        /// </summary>
        [JsonPropertyName("blueprint_location_id")]
        public required long BlueprintLocationId { get; init; }

        /// <summary>
        /// blueprint_type_id integer
        /// </summary>
        [JsonPropertyName("blueprint_type_id")]
        public required int BlueprintTypeId { get; init; }

        /// <summary>
        /// ID of the character which completed this job
        /// </summary>
        [JsonPropertyName("completed_character_id")]
        public int? CompletedCharacterId { get; init; }

        /// <summary>
        /// Date and time when this job was completed
        /// </summary>
        [JsonPropertyName("completed_date")]
        public DateTime? CompletedDate { get; init; }

        /// <summary>
        /// The sume of job installation fee and industry facility tax
        /// </summary>
        [JsonPropertyName("cost")]
        public double? Cost { get; init; }

        /// <summary>
        /// Job duration in seconds
        /// </summary>
        [JsonPropertyName("duration")]
        public required int Duration { get; init; }

        /// <summary>
        /// Date and time when this job finished
        /// </summary>
        [JsonPropertyName("end_date")]
        public required DateTime EndDate { get; init; }

        /// <summary>
        /// ID of the facility where this job is running
        /// </summary>
        [JsonPropertyName("facility_id")]
        public required long FacilityId { get; init; }

        /// <summary>
        /// ID of the character which installed this job
        /// </summary>
        [JsonPropertyName("installer_id")]
        public required int InstallerId { get; init; }

        /// <summary>
        /// Unique job ID
        /// </summary>
        [JsonPropertyName("job_id")]
        public required int JobId { get; init; }

        /// <summary>
        /// Number of runs blueprint is licensed for
        /// </summary>
        [JsonPropertyName("licensed_runs")]
        public int? LicensedRuns { get; init; }

        /// <summary>
        /// Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility
        /// </summary>
        [JsonPropertyName("output_location_id")]
        public required long OutputLocationId { get; init; }

        /// <summary>
        /// Date and time when this job was paused (i.e. time when the facility where this job was installed went offline)
        /// </summary>
        [JsonPropertyName("pause_date")]
        public DateTime? PauseDate { get; init; }

        /// <summary>
        /// Chance of success for invention
        /// </summary>
        [JsonPropertyName("probability")]
        public float? Probability { get; init; }

        /// <summary>
        /// Type ID of product (manufactured, copied or invented)
        /// </summary>
        [JsonPropertyName("product_type_id")]
        public int? ProductTypeId { get; init; }

        /// <summary>
        /// Number of runs for a manufacturing job, or number of copies to make for a blueprint copy
        /// </summary>
        [JsonPropertyName("runs")]
        public required int Runs { get; init; }

        /// <summary>
        /// Date and time when this job started
        /// </summary>
        [JsonPropertyName("start_date")]
        public required DateTime StartDate { get; init; }

        /// <summary>
        /// ID of the station where industry facility is located
        /// </summary>
        [JsonPropertyName("station_id")]
        public required long StationId { get; init; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonPropertyName("status")]
        public required JobStatus Status { get; init; }

        /// <summary>
        /// Number of successful runs for this job. Equal to runs unless this is an invention job
        /// </summary>
        [JsonPropertyName("successful_runs")]
        public int? SuccessfulRuns { get; init; }
    }
}
