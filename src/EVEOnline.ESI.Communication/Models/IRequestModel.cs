namespace EVEOnline.ESI.Communication.Models
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
