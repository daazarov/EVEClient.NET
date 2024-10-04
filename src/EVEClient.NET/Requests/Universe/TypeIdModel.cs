using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
