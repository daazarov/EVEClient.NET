using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
