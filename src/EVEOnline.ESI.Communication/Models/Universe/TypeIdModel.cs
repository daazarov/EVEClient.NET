using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class TypeIdModel
    {
        public TypeIdModel(int typeId)
        { 
            TypeId = typeId;
        }

        [PathParameter("type_id")]
        public int TypeId { get; set; }
    }
}
