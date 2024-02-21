using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
