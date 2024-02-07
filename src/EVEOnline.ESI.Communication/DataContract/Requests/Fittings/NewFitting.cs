using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class NewFitting
    {
        /// <summary>
        /// description string
        /// </summary>
        public string Description {  get; set; }

        /// <summary>
        /// items array
        /// </summary>
        public List<FittingItem> Items { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        public int ShipTypeId { get; set; }
    }
}
