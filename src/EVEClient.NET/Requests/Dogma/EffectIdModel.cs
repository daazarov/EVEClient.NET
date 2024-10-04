using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class EffectIdModel
    {
        public EffectIdModel(int effectId)
        { 
            EffectId = effectId;
        }

        [PathParameter("effect_id")]
        public int EffectId { get; set; }
    }
}
