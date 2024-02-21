using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
