using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class ContractIdModel
    {
        public ContractIdModel(int contractId)
        {
            ContractId = contractId;
        }

        [RouteParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
