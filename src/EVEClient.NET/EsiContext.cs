using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

using EVEClient.NET.Models;

namespace EVEClient.NET
{
    public class EsiContext
    {
        /// <summary>
        /// The ESI endpoint identifier for which the context is created.
        /// </summary>
        public string EndpointId { get; }

        /// <summary>
        /// Gets ot sets <see cref="NET.ExecutionOptions"/>.
        /// </summary>
        public ExecutionOptions ExecutionOptions { get; set; } = ExecutionOptions.None;

        /// <summary>
        /// Gets or sets <see cref="CancellationToken"/> that fires if the request is aborted and the application should cease processing.
        /// </summary>
        public CancellationToken CancellationToken { get; set; } = default;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> that provides access to the service container.
        /// </summary>
        public IServiceProvider ScopedServices { get; set; } = default!;

        /// <summary>
        /// Gets the <see cref="EsiRequest"/> that will be sent to the ESI API.
        /// </summary>
        public EsiRequest Request { get; }

        /// <summary>
        /// Gets the <see cref="EsiResponseContext"/>.
        /// </summary>
        public EsiResponseContext ResponseContext { get; }

        /// <summary>
        /// A container for storing custom objects between midleware components with per-request life cycle.
        /// </summary>
        public Dictionary<string, object> Properties { get; } = new();

        /// <summary>
        /// Creates a new instance of the object.
        /// </summary>
        /// <param name="endpointId">ESI endpoint id from <see cref="ESI.Endpoints"/>.</param>
        /// <param name="request">The <see cref="EsiRequest"/> object.</param>
        public EsiContext(string endpointId, EsiRequest request)
        {
            EndpointId = endpointId;
            Request = request;

            ResponseContext = new EsiResponseContext(this);
        }
    }

    public class EsiResponseContext
    {
        public EsiResponseContext(EsiContext context)
        {
            EsiContext = context;
        }

        /// <summary>
        /// Gets the parent <see cref="NET.EsiContext"/>.
        /// </summary>
        public EsiContext EsiContext { get; }

        public HttpResponseMessage Response { get; set; } = default!;

        public bool Completed { get; set; }
    }
}
