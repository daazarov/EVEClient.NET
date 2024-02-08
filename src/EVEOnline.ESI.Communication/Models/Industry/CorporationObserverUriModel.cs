using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CorporationObserverUriModel
    {
        public CorporationObserverUriModel(int corporationId, long observerId, int page)
        {
            CorporationId = corporationId;
            ObserverId = observerId;
            Page = page;
        }

        [RouteParameter("observer_id")]
        public long ObserverId { get; set; }

        [RouteParameter("corporation_id")]
        public int CorporationId { get; set; }

        [QueryParameter("page")]
        public int Page {  get; set; }
    }
}
