using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EVEClient.NET
{
    /// <summary>
    /// Implementation of <see cref="EsiResponse{IAsyncEnumerable{T}}"/>.
    /// </summary>
    /// <typeparam name="T">Data type loaded by async stream.</typeparam>
    /// <remarks>
    /// The properties from response headers are set only when the esi endpoint has been called (by default after the call <see cref="InitializeAsync"/> method).
    /// If you need to monitor state changes, use the <see cref="OnCalled(Action{EsiStreamEventArgs})"/> method.
    /// </remarks>
    public abstract class EsiStreamResponse<T> : EsiResponse<IAsyncEnumerable<T>>
    {
        private readonly List<IDisposable> _registrations = new List<IDisposable>();
        private event Action<EsiStreamEventArgs>? _onCalled;

        protected bool _initialized;

        /// <summary>
        /// Gets the <see cref="EsiStream{T}"/>.
        /// </summary>
        protected EsiStream<T> Stream { get; }

        /// <summary>
        /// Gets the async data stream.
        /// </summary>
        [Obsolete("The Data propery is obsolete and will be removed in the near future. Use TryGetData method instead.")]
        public override IAsyncEnumerable<T> Data
        {
            get => Stream;
        }

        /// <summary>
        /// Allows derived types to handle first esi endpoint call.
        /// </summary>
        /// <param name="args"></param>
        protected abstract void InitialSetter(EsiResponse response);

        internal EsiStreamResponse(Func<int, Task<EsiResponsePagination<List<T>>>> executor, int pageOffset, int pageLimit, int pageSize, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(executor);

            ArgumentOutOfRangeException.ThrowIfNegative(pageOffset);
            ArgumentOutOfRangeException.ThrowIfNegative(pageLimit);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(pageSize);

            Stream = new EsiStream<T>(this, executor, pageOffset, pageLimit, pageSize, cancellationToken);
        }

        /// <summary>
        /// Calls the <see cref="EsiStream{T}.Begin()"/> to initialize iterator and fill the data buffer from the first esi endpoint call.
        /// Also invokes the <see cref="InitialSetter(EsiResponse)"/> to initialize properties from response headers after first esi endpoint call.
        /// </summary>
        /// <returns>The <see cref="Task"/>.</returns>
        /// <remarks>Method call is not necessary for successful work with the data stream.</remarks>
        public virtual async Task InitializeAsync()
        {
            if (_initialized) return;

            using (OnCalled(args => InitialSetter(args.Response)))
            {
                await Stream.Begin();
            }

            _initialized = true;
        }

        /// <summary>
        /// Registers a listener to be called after each esi endpoint call.
        /// </summary>
        /// <param name="listener">The action to be invoked when esi endpoint has called.</param>
        /// <returns>An <see cref="IDisposable"/> which should be disposed to stop listening for changes.</returns>
        public virtual IDisposable OnCalled(Action<EsiStreamEventArgs> listener)
        {
            var disposable = new EndpointCallingTrackerDisposable(this, listener);
            _onCalled += disposable.OnCalled;
            _registrations.Add(disposable);
            return disposable;
        }

        internal virtual void InvokeOnCalled(EsiStreamEventArgs response)
        {
            _onCalled?.Invoke(response);
        }

        public override void Dispose()
        {
            Dispose(true);
        }

        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if (_onCalled != null)
                    {
                        RemoveListeners();
                    }
                }

                _disposedValue = true;
            }
        }

        private void RemoveListeners()
        {
            foreach (var registration in _registrations)
            {
                registration.Dispose();
                _registrations.Remove(registration);
            }
        }

        internal sealed class EndpointCallingTrackerDisposable : IDisposable
        {
            private readonly Action<EsiStreamEventArgs> _listener;
            private readonly EsiStreamResponse<T> _parent;

            public EndpointCallingTrackerDisposable(EsiStreamResponse<T> parent, Action<EsiStreamEventArgs> listener)
            {
                _listener = listener;
                _parent = parent;
            }

            public void OnCalled(EsiStreamEventArgs response)
            {
                _listener.Invoke(response);
            }

            public void Dispose()
            {
                _parent._onCalled -= OnCalled;
                _parent._registrations.Remove(this);
            }
        }
    }
}
