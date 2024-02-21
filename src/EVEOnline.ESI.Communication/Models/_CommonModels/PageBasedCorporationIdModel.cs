using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class PageBasedCorporationIdModel : CorporationIdModel
    {
        public PageBasedCorporationIdModel(int corporationId, int page) : base(corporationId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
