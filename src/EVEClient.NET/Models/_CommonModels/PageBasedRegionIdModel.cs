using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
