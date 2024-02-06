using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class DeleteFittingUriModel
    {
        public DeleteFittingUriModel(int characterId, int fittingId)
        {
            CharacterId = characterId;
            FittingId = fittingId;
        }

        [RouteParameter("character_id")]
        public int CharacterId { get; set; }

        [RouteParameter("fitting_id")]
        public int FittingId { get; set;}
    }
}
