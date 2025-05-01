namespace EVEClient.NET
{
    public interface IResponseReaderProvider
    {
        IResponseReader GetDefaultReader();
        IResponseReader<T> GetGenericReader<T>();
    }
}
