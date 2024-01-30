using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class PageBasedRegionIdModel : RegionIdModel
    {
        public PageBasedRegionIdModel(int regionId, int page) : base(regionId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
