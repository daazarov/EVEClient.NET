using System.Threading.Tasks;

using EVEClient.NET.Pipline;

namespace EVEClient.NET.Handlers
{
    /// <summary>
    /// Defines handler (middleware) that can be added to the ESI request pipeline.
    /// </summary>
    public interface IHandler
    {
        /// <summary>
        /// Request handling method.
        /// </summary>
        /// <param name="context">he <see cref="EsiContext"/> for the current request.</param>
        /// <param name="next">The delegate representing the remaining middleware in the request pipeline.</param>
        /// <returns>A <see cref="Task"/> that represents the execution of this middleware.</returns>
        Task HandleAsync(EsiContext context, RequestDelegate next);
    }
}
