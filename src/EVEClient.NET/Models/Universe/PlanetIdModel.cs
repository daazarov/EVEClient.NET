using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
