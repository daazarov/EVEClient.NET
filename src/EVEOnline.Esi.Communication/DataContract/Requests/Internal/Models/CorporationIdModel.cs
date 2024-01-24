using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CorporationIdModel
    {
        public CorporationIdModel(int corporationId)
        {
            CorporationId = corporationId;
        }

        [RouteParameter("corporation_id")]
        public int CorporationId { get; set; }
    }
}
