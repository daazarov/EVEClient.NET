using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
