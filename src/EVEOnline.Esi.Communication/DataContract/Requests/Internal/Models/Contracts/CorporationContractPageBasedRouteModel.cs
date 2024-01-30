using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CorporationContractPageBasedRouteModel : CorporationContractRouteModel
    {
        public CorporationContractPageBasedRouteModel(int corporationId, int contractId, int page)
            : base(corporationId, contractId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
