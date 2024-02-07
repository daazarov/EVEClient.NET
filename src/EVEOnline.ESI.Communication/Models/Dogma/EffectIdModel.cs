using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class EffectIdModel
    {
        public EffectIdModel(int effectId)
        { 
            EffectId = effectId;
        }

        [RouteParameter("effect_id")]
        public int EffectId { get; set; }
    }
}
