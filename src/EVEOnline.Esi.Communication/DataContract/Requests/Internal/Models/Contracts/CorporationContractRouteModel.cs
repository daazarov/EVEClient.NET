using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CorporationContractRouteModel
    {
        public CorporationContractRouteModel(int corporationId, int contractId) 
        { 
            CorporationId = corporationId;
            ContractId = contractId;
        }

        [RouteParameter("contract_id")]
        public int ContractId { get; set; }

        [RouteParameter("corporation_id")]
        public int CorporationId { get; set; }
    }
}
