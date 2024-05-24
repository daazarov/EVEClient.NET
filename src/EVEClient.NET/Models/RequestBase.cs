using System;

namespace EVEClient.NET.Models
{
    internal abstract class RequestBase<TUri, TBody> : IBodyModel, IRoteModel
        where TBody : class
        where TUri : class
    {
        private readonly TUri _uriModel;
        private readonly TBody _bodyModel;
        
        public RequestBase(TUri uriModel, TBody bodyModel)
        { 
            _uriModel = uriModel ?? throw new ArgumentNullException(nameof(uriModel));
            _bodyModel = bodyModel ?? throw new ArgumentNullException(nameof(bodyModel));
        }

        public object Body => _bodyModel;
        public object QueryRoute => _uriModel;
    }
}
