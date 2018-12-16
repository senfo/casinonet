using System;

namespace Casino.Games.Common
{
    /// <summary>
    /// Defines the interface for a CasinoNET Game
    /// </summary>
    public interface ICasinoGame : IDisposable
    {
        /// <summary>
        /// Initializes the poker game
        /// </summary>
        void Run();
    }
}
