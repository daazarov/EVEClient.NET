using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterContractRouteModel : CharacterIdModel
    {
        public CharacterContractRouteModel(int characterId, int contractId) : base(characterId)
        {
            ContractId = contractId;
        }

        [PathParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
