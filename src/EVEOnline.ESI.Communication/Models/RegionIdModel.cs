using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class RegionIdModel
    {
        public RegionIdModel(int regionId)
        {
            RegionId = regionId;
        }

        [RouteParameter("region_id")]
        public int RegionId { get; set; }
    }
}
