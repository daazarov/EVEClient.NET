using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class War
    {
        /// <summary>
        /// aggressor object
        /// </summary>
        [JsonProperty("aggressor")]
        public Fighter Aggressor {  get; set; }

        /// <summary>
        /// allied corporations or alliances, each object contains either corporation_id or alliance_id
        /// </summary>
        [JsonProperty("allies")]
        public List<Ally> Allies { get; set; }

        /// <summary>
        /// Time that the war was declared
        /// </summary>
        [JsonProperty("declared")]
        public DateTime Declared {  get; set; }

        /// <summary>
        /// defender object
        /// </summary>
        [JsonProperty("defender")]
        public Fighter Defender { get; set; }

        /// <summary>
        /// Time the war ended and shooting was no longer allowed
        /// </summary>
        [JsonProperty("finished")]
        public DateTime? Finished { get; set; }

        /// <summary>
        /// ID of the specified war
        /// </summary>
        [JsonProperty("id")]
        public int ID { get; set; }

        /// <summary>
        /// Was the war declared mutual by both parties
        /// </summary>
        [JsonProperty("mutual")]
        public bool Mutual { get; set; }

        /// <summary>
        /// Is the war currently open for allies or not
        /// </summary>
        [JsonProperty("open_for_allies")]
        public bool OpenForAllies { get; set; }

        /// <summary>
        /// Time the war was retracted but both sides could still shoot each other
        /// </summary>
        [JsonProperty("retracted")]
        public DateTime? Retracted { get; set; }

        /// <summary>
        /// Time when the war started and both sides could shoot each other
        /// </summary>
        [JsonProperty("started")]
        public DateTime? Started { get; set; }


        public class Ally
        {
            /// <summary>
            /// Alliance ID if and only if this ally is an alliance
            /// </summary>
            [JsonProperty("alliance_id")]
            public int? AllianceId {  get; set; }

            /// <summary>
            /// Corporation ID if and only if this ally is a corporation
            /// </summary>
            [JsonProperty("corporation_id")]
            public int? CorporationId { get; set; }
        }

        public class Fighter
        {
            /// <summary>
            /// Alliance ID if and only if the aggressor/defender is an alliance
            /// </summary>
            [JsonProperty("alliance_id")]
            public int? AllianceId { get; set; }

            /// <summary>
            /// Corporation ID if and only if the aggressor/defender is a corporation
            /// </summary>
            [JsonProperty("corporation_id")]
            public int? CorporationId { get; set; }

            /// <summary>
            /// ISK value of ships the aggressor/defender has destroyed
            /// </summary>
            [JsonProperty("isk_destroyed")]
            public float IskDestroyed { get; set; }

            /// <summary>
            /// The number of ships the aggressor/defender has killed
            /// </summary>
            [JsonProperty("ships_killed")]
            public int ShipsKilled { get; set; }
        }
    }
}
