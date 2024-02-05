using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
