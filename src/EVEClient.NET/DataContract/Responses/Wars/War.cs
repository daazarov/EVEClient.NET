using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class War
    {
        /// <summary>
        /// aggressor object
        /// </summary>
        [JsonPropertyName("aggressor")]
        public required Fighter Aggressor { get; init; }

        /// <summary>
        /// allied corporations or alliances, each object contains either corporation_id or alliance_id
        /// </summary>
        [JsonPropertyName("allies")]
        public List<Ally>? Allies { get; init; }

        /// <summary>
        /// Time that the war was declared
        /// </summary>
        [JsonPropertyName("declared")]
        public required DateTime Declared { get; init; }

        /// <summary>
        /// defender object
        /// </summary>
        [JsonPropertyName("defender")]
        public required Fighter Defender { get; init; }

        /// <summary>
        /// Time the war ended and shooting was no longer allowed
        /// </summary>
        [JsonPropertyName("finished")]
        public DateTime? Finished { get; init; }

        /// <summary>
        /// ID of the specified war
        /// </summary>
        [JsonPropertyName("id")]
        public required int ID { get; init; }

        /// <summary>
        /// Was the war declared mutual by both parties
        /// </summary>
        [JsonPropertyName("mutual")]
        public required bool Mutual { get; init; }

        /// <summary>
        /// Is the war currently open for allies or not
        /// </summary>
        [JsonPropertyName("open_for_allies")]
        public required bool OpenForAllies { get; init; }

        /// <summary>
        /// Time the war was retracted but both sides could still shoot each other
        /// </summary>
        [JsonPropertyName("retracted")]
        public DateTime? Retracted { get; init; }

        /// <summary>
        /// Time when the war started and both sides could shoot each other
        /// </summary>
        [JsonPropertyName("started")]
        public DateTime? Started { get; init; }


        public class Ally
        {
            /// <summary>
            /// Alliance ID if and only if this ally is an alliance
            /// </summary>
            [JsonPropertyName("alliance_id")]
            public int? AllianceId { get; init; }

            /// <summary>
            /// Corporation ID if and only if this ally is a corporation
            /// </summary>
            [JsonPropertyName("corporation_id")]
            public int? CorporationId { get; init; }
        }

        public class Fighter
        {
            /// <summary>
            /// Alliance ID if and only if the aggressor/defender is an alliance
            /// </summary>
            [JsonPropertyName("alliance_id")]
            public int? AllianceId { get; init; }

            /// <summary>
            /// Corporation ID if and only if the aggressor/defender is a corporation
            /// </summary>
            [JsonPropertyName("corporation_id")]
            public int? CorporationId { get; init; }

            /// <summary>
            /// ISK value of ships the aggressor/defender has destroyed
            /// </summary>
            [JsonPropertyName("isk_destroyed")]
            public required float IskDestroyed { get; init; }

            /// <summary>
            /// The number of ships the aggressor/defender has killed
            /// </summary>
            [JsonPropertyName("ships_killed")]
            public required int ShipsKilled { get; init; }
        }
    }
}
