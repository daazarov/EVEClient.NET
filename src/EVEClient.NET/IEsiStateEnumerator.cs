using System.Collections.Generic;

namespace EVEClient.NET
{
    internal interface IEsiStateEnumerator<T> : IAsyncEnumerator<T>
    {
        State CurrentState { get; set; }

        public int NextPage { get; set; }

        public int LastPage { get; set; }
    }

    internal enum State : byte
    {
        Initial,
        Running,
        Completed,
        Disposed
    }
}
