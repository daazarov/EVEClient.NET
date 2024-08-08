namespace EVEClient.NET.Pipline
{
    /// <summary>
    /// Defines a class that provides the mechanisms to configure an ESI endpoint request pipeline.
    /// </summary>
    internal interface IRequestPiplineBuilder
    {
        /// <summary>
        /// Adds a middleware component to the ESI endpoint request pipeline.
        /// </summary>
        /// <param name="component">The middleware component.</param>
        /// <returns>The <see cref="IRequestPiplineBuilder"/>.</returns>
        IRequestPiplineBuilder Use(PiplineComponent component);

        /// <summary>
        /// Builds the middleware components used by specific ESI endpoint to process HTTP requests.
        /// </summary>
        /// <returns>The request handling delegate.</returns>
        IRequestPipline Build();
    }
}
