using System;

namespace EVEClient.NET.Models
{
    internal abstract class BodyModelBase<T> : IBodyModel where T : class
    {
        private readonly T _content;

        public BodyModelBase(T bodyModel)
        { 
            _content = bodyModel ?? throw new ArgumentNullException(nameof(bodyModel));
        }

        public object Body => _content;
    }
}
