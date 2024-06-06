using EVEClient.NET.Pipline;

namespace EVEClient.NET.UnitTests.TestsClasses
{
    internal class CustomHandler : IHandler
    {
        public Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }

    internal class CustomHandler1 : IHandler
    {
        public Task HandleAsync(EsiContext context, RequestDelegate next)
        {
            throw new NotImplementedException();
        }
    }
}
