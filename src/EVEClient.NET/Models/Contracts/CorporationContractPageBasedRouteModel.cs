using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
