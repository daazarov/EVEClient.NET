using System;

namespace EVEClient.NET
{
    public class EsiStreamEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the <see cref="EsiResponse"/>.
        /// </summary>
        public EsiResponse Response { get; }

        /// <summary>
        /// Gets the requested page number.
        /// </summary>
        public int RequestedPage { get; }

        internal EsiStreamEventArgs(EsiResponse response, int page)
        {
            ArgumentNullException.ThrowIfNull(response);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(page);

            Response = response;
            RequestedPage = page;
        }
    }
}
