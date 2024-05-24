using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class PageBasedStructureIdModel : StructureIdModel
    {
        public PageBasedStructureIdModel(long structureId, int page) : base(structureId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
