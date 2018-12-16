using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that represent a CasinoGame
    /// </summary>
    public class CasinoGame
    {
        /// <summary>
        /// Gets or sets a reference to a deck of cards
        /// </summary>
        public DeckBase Deck
        {
            get;
            set;
        }
    }
}
