using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
