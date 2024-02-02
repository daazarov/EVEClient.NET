using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class StarbaseInfoUriModel
    {
        public StarbaseInfoUriModel(int corporationId, long starbaseId, int systemId)
        { 
            CorporationId = corporationId;
            StarbaseId = starbaseId;
            SystemId = systemId;
        }

        [RouteParameter("corporation_id")]
        public int CorporationId { get; set; }

        [RouteParameter("starbase_id ")]
        public long StarbaseId { get; set; }

        [QueryParameter("system_id ")]
        public int SystemId { get; set; }
    }
}
