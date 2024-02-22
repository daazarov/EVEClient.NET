using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class ColonyInfoUriModel
    {
        public ColonyInfoUriModel(int characterId, int planetId)
        {
            CharacterId = characterId;
            PlanetId = planetId;
        }

        [PathParameter("character_id")]
        public int CharacterId { get; set; }

        [PathParameter("planet_id")]
        public int PlanetId { get; set; }
    }
}
