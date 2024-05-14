using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class StationIdModel
    {
        public StationIdModel(int stationId)
        { 
            StationId = stationId;
        }

        [PathParameter("station_id")]
        public int StationId { get; set; }
    }
}
