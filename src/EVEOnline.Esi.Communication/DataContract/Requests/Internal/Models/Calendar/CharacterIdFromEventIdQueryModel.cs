using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CharacterIdFromEventIdQueryModel : CharacterIdModel
    {
        public CharacterIdFromEventIdQueryModel(int characterId, int? eventId) : base(characterId)
        {
            FromEventId = eventId;
        }

        [QueryParameter("from_event")]
        public int? FromEventId { get; set; }
    }
}
