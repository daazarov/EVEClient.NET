using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class AllianceIdModel
    {
        public AllianceIdModel(int allianceId)
        {
            AllianceId = allianceId;
        }

        [RouteParameter("alliance_id")]
        public int AllianceId { get; set; }
    }
}
