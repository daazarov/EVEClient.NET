using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterContractRouteModel : FleetIdModel
    {
        public CharacterContractRouteModel(int characterId, int contractId) : base(characterId)
        {
            ContractId = contractId;
        }

        [RouteParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
