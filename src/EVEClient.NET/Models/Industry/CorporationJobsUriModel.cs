using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class CorporationJobsUriModel
    {
        public CorporationJobsUriModel(int corporation, bool includeCompleted, int page)
        {
            CorporationId = corporation;
            IncludeCompleted = includeCompleted;
            Page = page;
        }

        [PathParameter("character_id")]
        public int CorporationId { get; set; }

        [QueryParameter("include_completed")]
        public bool IncludeCompleted { get; set; }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
