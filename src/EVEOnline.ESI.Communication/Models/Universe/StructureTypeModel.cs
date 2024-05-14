using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class StructureTypeModel
    {
        public StructureTypeModel(string structureType)
        {
            StructureType = structureType;
        }

        [QueryParameter("filter")]
        public string StructureType { get; set; }
    }
}
