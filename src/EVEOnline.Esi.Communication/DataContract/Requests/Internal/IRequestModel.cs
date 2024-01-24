namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal interface IRequestModel 
    {
    }

    internal interface IBodyModel : IRequestModel
    {
        object Body { get; }
    }

    internal interface IRoteModel : IRequestModel
    {
        object QueryRoute { get; }
    }
}
