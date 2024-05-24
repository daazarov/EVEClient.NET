using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class RegionIdModel
    {
        public RegionIdModel(int regionId)
        {
            RegionId = regionId;
        }

        [PathParameter("region_id")]
        public int RegionId { get; set; }
    }
}
