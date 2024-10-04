using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class PageBasedAllianceIdModel : AllianceIdModel
    {
        public PageBasedAllianceIdModel(int allianceId, int page) : base(allianceId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
