using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EVEClient.NET
{
    public class EsiStream<T> : IAsyncEnumerable<T>
    {
        private readonly EsiStreamResponse<T> _parentResponse;
        private readonly Func<int, Task<EsiResponsePagination<List<T>>>> _executor;
        private readonly CancellationToken _cancellationToken;

        private IEsiStateEnumerator<T>? _cachedEnumerator;

        internal int PageOffset { get; }
        internal int PageSize { get; }
        internal int PageLimit { get; }

        internal EsiStream(EsiStreamResponse<T> parentResponse, Func<int, Task<EsiResponsePagination<List<T>>>> executor, int pageOffset, int pageLimit, int pageSize, CancellationToken cancellationToken = default)
        { 
            _parentResponse = parentResponse;
            _executor = executor;
            _cancellationToken = cancellationToken;

            PageOffset = pageOffset;
            PageSize = pageSize;
            PageLimit = pageLimit;
        }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            if (_cachedEnumerator?.CurrentState == State.Disposed)
            {
                _cachedEnumerator = null;
            }

            return _cachedEnumerator ??= new EsiStreamEnumerator<T>(this, _cancellationToken);
        }

        public Task<EsiResponsePagination<List<T>>> LoadNextPage(int page)
        {
            return _executor(page);
        }

        public ValueTask<bool> Begin()
        {
            // just cache the iterator and fill the buffer with the first call
            var enumerator = GetAsyncEnumerator(_cancellationToken);
            return enumerator.MoveNextAsync();
        }

        internal void InvokeOnCalled(EsiResponse response, int page)
        {
            _parentResponse.InvokeOnCalled(new EsiStreamEventArgs(response, page));
        }
    }

    internal class EsiStreamEnumerator<T> : IEsiStateEnumerator<T>
    {
        private readonly EsiStream<T> _parent;
        private readonly CancellationToken _cancellationToken;

        private Queue<T> _buffer = null!;

        public State CurrentState { get; set; }
        public int NextPage { get; set; }
        public int LastPage { get; set; }

        public EsiStreamEnumerator(EsiStream<T> parent, CancellationToken cancellationToken = default)
        { 
            _parent = parent;
            _cancellationToken = cancellationToken;

            Initialize();
        }

        public T Current
        {
            get => _buffer.Dequeue();
        }
       
        public ValueTask<bool> MoveNextAsync()
        {
            _cancellationToken.ThrowIfCancellationRequested();

            if (MoveNextSimple()) return ValueTask.FromResult(true);

            return MoveNextComplecatedAsync();
        }

        public ValueTask DisposeAsync()
        {
            CurrentState = State.Disposed;
            GC.SuppressFinalize(this);

            return ValueTask.CompletedTask;
        }

        private bool MoveNextSimple()
        {
            return _buffer?.TryPeek(out _) == true;
        }

        private ValueTask<bool> MoveNextComplecatedAsync()
        {
            var initial = false;

            switch (CurrentState)
            {
                case State.Initial:
                    initial = true;
                    CurrentState = State.Running;
                    goto case State.Running;
                case State.Running:
                    if (!initial && NextPage > LastPage)
                    {
                        CurrentState = State.Completed;
                        goto case State.Completed;
                    }
                    return new ValueTask<bool>(ProcessRequestPageAsync(initial));
                case State.Completed:
                case State.Disposed:
                default:
                    return ValueTask.FromResult(false);
            }
        }

        private async Task<bool> ProcessRequestPageAsync(bool initial)
        {
            using (var result = await _parent.LoadNextPage(NextPage))
            {
                _parent.InvokeOnCalled(result, NextPage);

                if (result.TryGetData(out var data, out _))
                {
                    if (initial)
                    {
                        _buffer = new(_parent.PageSize);

                        var pages = result.TotalPages!.Value;
                        if ((_parent.PageOffset + _parent.PageLimit) >= pages)
                        {
                            LastPage = pages;
                        }
                        else
                        {
                            LastPage = _parent.PageOffset + _parent.PageLimit;
                        }
                    }

                    _buffer.Clear();
                    data.ForEach(_buffer.Enqueue);
                }
                else
                {
                    return false;
                }
            }
            
            NextPage++;

            return true;
        }

        private void Initialize()
        {
            CurrentState = State.Initial;
            NextPage = _parent.PageOffset == 0 ? 1 : _parent.PageOffset + 1;
        }
    }
}
