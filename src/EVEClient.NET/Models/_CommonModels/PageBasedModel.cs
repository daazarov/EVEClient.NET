using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class PageBasedModel
    {
        public PageBasedModel(int page)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
