namespace EVEOnline.Esi.Communication.DataContract.Requests
{
    public abstract class PaginatedRequest
    {
        public int Page { get; set; } = 1;
    }
}
