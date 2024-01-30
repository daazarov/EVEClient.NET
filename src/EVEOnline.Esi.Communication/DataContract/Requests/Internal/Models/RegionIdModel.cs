using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
