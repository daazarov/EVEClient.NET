using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
