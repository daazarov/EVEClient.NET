using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class PlanetIdModel
    {
        public PlanetIdModel(int planetId)
        { 
            PlanetId = planetId;
        }

        [PathParameter("planet_id")]
        public int PlanetId { get; set; }
    }
}
