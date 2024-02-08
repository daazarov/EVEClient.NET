using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CorporationJobsUriModel
    {
        public CorporationJobsUriModel(int corporation, bool includeCompleted, int page)
        {
            CorporationId = corporation;
            IncludeCompleted = includeCompleted;
            Page = page;
        }

        [RouteParameter("character_id")]
        public int CorporationId { get; set; }

        [QueryParameter("include_completed")]
        public bool IncludeCompleted { get; set; }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
