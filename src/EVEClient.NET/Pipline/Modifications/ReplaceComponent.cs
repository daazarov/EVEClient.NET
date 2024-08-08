namespace EVEClient.NET.Pipline.Modifications
{
    internal class ReplaceComponent
    {
        public required PiplineComponent PiplineComponent { get; init; }
        public required string ReplaceId { get; init; }
    }
}
