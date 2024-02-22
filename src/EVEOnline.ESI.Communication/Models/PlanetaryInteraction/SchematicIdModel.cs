using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class SchematicIdModel
    {
        public SchematicIdModel(int schematicId)
        {
            SchematicId = schematicId;
        }

        [PathParameter("schematic_id")]
        public int SchematicId {  get; set; }
    }
}
