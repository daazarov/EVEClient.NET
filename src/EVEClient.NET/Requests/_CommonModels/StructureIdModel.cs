using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class StructureIdModel
    {
        public StructureIdModel(long structureId)
        {
            StructureId = structureId;
        }

        [PathParameter("structure_id")]
        public long StructureId {  get; set; }
    }
}
