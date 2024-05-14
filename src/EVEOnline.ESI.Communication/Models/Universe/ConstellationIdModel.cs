using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class ConstellationIdModel
    {
        public ConstellationIdModel(int constellationId)
        {
            ConstellationId = constellationId;
        }

        [PathParameter("constellation_id")]
        public int ConstellationId { get; set; }
    }
}
