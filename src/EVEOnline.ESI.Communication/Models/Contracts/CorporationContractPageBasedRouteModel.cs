using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
