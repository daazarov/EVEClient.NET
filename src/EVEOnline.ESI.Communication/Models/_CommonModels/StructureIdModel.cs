using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
