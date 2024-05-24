using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class CorporationObserverUriModel
    {
        public CorporationObserverUriModel(int corporationId, long observerId, int page)
        {
            CorporationId = corporationId;
            ObserverId = observerId;
            Page = page;
        }

        [PathParameter("observer_id")]
        public long ObserverId { get; set; }

        [PathParameter("corporation_id")]
        public int CorporationId { get; set; }

        [QueryParameter("page")]
        public int Page {  get; set; }
    }
}
