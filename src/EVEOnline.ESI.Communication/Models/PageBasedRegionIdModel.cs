using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
