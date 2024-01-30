using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CharacterContractRouteModel : CharacterIdModel
    {
        public CharacterContractRouteModel(int characterId, int contractId) : base(characterId)
        {
            ContractId = contractId;
        }

        [RouteParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
