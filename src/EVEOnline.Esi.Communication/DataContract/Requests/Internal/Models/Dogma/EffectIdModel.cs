using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
