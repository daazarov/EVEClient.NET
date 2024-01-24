using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
