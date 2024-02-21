using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class AllianceIdModel
    {
        public AllianceIdModel(int allianceId)
        {
            AllianceId = allianceId;
        }

        [PathParameter("alliance_id")]
        public int AllianceId { get; set; }
    }
}
