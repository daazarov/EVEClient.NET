using System;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal abstract class BodyModelBase<T> : IBodyModel
    {
        private readonly T _content;
        
        public BodyModelBase(T bodyModel)
        { 
            _content = bodyModel ?? throw new ArgumentNullException(nameof(bodyModel));
        }

        public object Body => _content;
    }
}
