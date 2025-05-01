namespace EVEClient.NET
{
    public class DefaultResponseReaderProvider : IResponseReaderProvider
    {
        public IResponseReader GetDefaultReader()
        {
            return new DefaultResponseReader();
        }

        public IResponseReader<T> GetGenericReader<T>()
        {
            return new DefaultGenericResponseReader<T>();
        }
    }
}
