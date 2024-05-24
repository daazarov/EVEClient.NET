using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class StarbaseInfoUriModel
    {
        public StarbaseInfoUriModel(int corporationId, long starbaseId, int systemId)
        { 
            CorporationId = corporationId;
            StarbaseId = starbaseId;
            SystemId = systemId;
        }

        [PathParameter("corporation_id")]
        public int CorporationId { get; set; }

        [PathParameter("starbase_id ")]
        public long StarbaseId { get; set; }

        [QueryParameter("system_id ")]
        public int SystemId { get; set; }
    }
}
