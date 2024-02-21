using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
