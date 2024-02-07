using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class AttributeIdModel
    {
        public AttributeIdModel(int attributeId)
        { 
            AttributeId = attributeId;
        }

        [RouteParameter("attribute_id")]
        public int AttributeId { get; set; }
    }
}
