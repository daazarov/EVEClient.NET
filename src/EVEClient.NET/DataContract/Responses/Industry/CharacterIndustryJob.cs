﻿using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterIndustryJob
    {
        /// <summary>
        /// Job activity ID
        /// </summary>
        [JsonProperty("activity_id")]
        public int ActivityId { get; init; }

        /// <summary>
        /// blueprint_id integer
        /// </summary>
        [JsonProperty("blueprint_id")]
        public long BlueprintId { get; init; }

        /// <summary>
        /// Location ID of the location from which the blueprint was installed.
        /// Normally a station ID, but can also be an asset (e.g. container) or corporation facility
        /// </summary>
        [JsonProperty("blueprint_location_id")]
        public long BlueprintLocationId { get; init; }

        /// <summary>
        /// blueprint_type_id integer
        /// </summary>
        [JsonProperty("blueprint_type_id")]
        public int BlueprintTypeId { get; init; }

        /// <summary>
        /// ID of the character which completed this job
        /// </summary>
        [JsonProperty("completed_character_id")]
        public int? CompletedCharacterId { get; init; }

        /// <summary>
        /// Date and time when this job was completed
        /// </summary>
        [JsonProperty("completed_date")]
        public DateTime? CompletedDate { get; init; }

        /// <summary>
        /// The sume of job installation fee and industry facility tax
        /// </summary>
        [JsonProperty("cost")]
        public double? Cost { get; init; }

        /// <summary>
        /// Job duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; init; }

        /// <summary>
        /// Date and time when this job finished
        /// </summary>
        [JsonProperty("end_date")]
        public DateTime EndDate { get; init; }

        /// <summary>
        /// ID of the facility where this job is running
        /// </summary>
        [JsonProperty("facility_id")]
        public long FacilityId { get; init; }

        /// <summary>
        /// ID of the character which installed this job
        /// </summary>
        [JsonProperty("installer_id")]
        public int InstallerId { get; init; }

        /// <summary>
        /// Unique job ID
        /// </summary>
        [JsonProperty("job_id")]
        public int JobId { get; init; }

        /// <summary>
        /// Number of runs blueprint is licensed for
        /// </summary>
        [JsonProperty("licensed_runs")]
        public int? LicensedRuns { get; init; }

        /// <summary>
        /// Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility
        /// </summary>
        [JsonProperty("output_location_id")]
        public long OutputLocationId { get; init; }

        /// <summary>
        /// Date and time when this job was paused (i.e. time when the facility where this job was installed went offline)
        /// </summary>
        [JsonProperty("pause_date")]
        public DateTime? PauseDate { get; init; }

        /// <summary>
        /// Chance of success for invention
        /// </summary>
        [JsonProperty("probability")]
        public float? Probability { get; init; }

        /// <summary>
        /// Type ID of product (manufactured, copied or invented)
        /// </summary>
        [JsonProperty("product_type_id")]
        public int? ProductTypeId { get; init; }

        /// <summary>
        /// Number of runs for a manufacturing job, or number of copies to make for a blueprint copy
        /// </summary>
        [JsonProperty("runs")]
        public int Runs { get; init; }

        /// <summary>
        /// Date and time when this job started
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime StartDate { get; init; }

        /// <summary>
        /// ID of the station where industry facility is located
        /// </summary>
        [JsonProperty("station_id")]
        public long StationId { get; init; }

        /// <summary>
        /// status string
        /// </summary>
        [JsonProperty("status")]
        public JobStatus Status { get; init; }

        /// <summary>
        /// Number of successful runs for this job. Equal to runs unless this is an invention job
        /// </summary>
        [JsonProperty("successful_runs")]
        public int? SuccessfulRuns { get; init; }
    }
}
