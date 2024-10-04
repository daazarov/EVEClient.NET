using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class RegionStatisticsUriModel
    {
        public RegionStatisticsUriModel(int regionId, int typeId)
        { 
            RegionId = regionId;
            TypeId = typeId;
        }

        [PathParameter("region_id")]
        public int RegionId { get; set; }

        [QueryParameter("type_id")]
        public int TypeId { get; set; }
    }
}
