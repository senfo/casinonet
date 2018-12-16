using Casino.Games.CardGames.Poker;
using Casino.Games.Common;

namespace Casino
{
    /// <summary>
    /// Contains the main entry point to the application
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            using (ICasinoGame game = new CasinoNetPoker())
            {
                game.Run();
            }
        }
    }
}

