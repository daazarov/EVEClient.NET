namespace EVEClient.NET.Pipline
{
    internal interface IRequestPiplineBuilder
    {
        IRequestPiplineBuilder Use(PiplineComponent component);
        IRequestPipline Build();
    }
}
