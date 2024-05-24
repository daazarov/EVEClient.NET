using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
