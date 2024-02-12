namespace EVEOnline.ESI.Communication.Models
{
    public interface IRequestModel 
    {
    }

    public interface IBodyModel : IRequestModel
    {
        object Body { get; }
    }

    public interface IRoteModel : IRequestModel
    {
        object QueryRoute { get; }
    }
}
