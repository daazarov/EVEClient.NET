using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
