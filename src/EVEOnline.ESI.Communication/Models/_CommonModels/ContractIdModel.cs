using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class ContractIdModel
    {
        public ContractIdModel(int contractId)
        {
            ContractId = contractId;
        }

        [PathParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
