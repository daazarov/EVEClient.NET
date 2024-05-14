using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
