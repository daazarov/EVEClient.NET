using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class AttributeIdModel
    {
        public AttributeIdModel(int attributeId)
        { 
            AttributeId = attributeId;
        }

        [PathParameter("attribute_id")]
        public int AttributeId { get; set; }
    }
}
