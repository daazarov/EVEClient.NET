using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class CorporationIdModel
    {
        public CorporationIdModel(int corporationId)
        {
            CorporationId = corporationId;
        }

        [PathParameter("corporation_id")]
        public int CorporationId { get; set; }
    }
}
