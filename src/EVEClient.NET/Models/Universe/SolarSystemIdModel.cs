using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class SolarSystemIdModel
    {
        public SolarSystemIdModel(int systemId)
        { 
            SolarSystemId = systemId;
        }

        [PathParameter("system_id")]
        public int SolarSystemId { get; set; }
    }
}
