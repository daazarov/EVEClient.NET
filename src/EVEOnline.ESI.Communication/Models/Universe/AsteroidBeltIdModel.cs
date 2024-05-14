using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class AsteroidBeltIdModel
    {
        public AsteroidBeltIdModel(int asteroidBeltId)
        { 
            AsteroidBeltId = asteroidBeltId;
        }

        [PathParameter("asteroid_belt_id")]
        public int AsteroidBeltId { get; set; }
    }
}
