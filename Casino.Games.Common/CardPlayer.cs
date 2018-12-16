using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that represent a card player
    /// </summary>
    public class CardPlayer : Player
    {
        #region Fields

        /// <summary>
        /// Stores a collection of cards held by a player
        /// </summary>
        private List<Card> _cards = new List<Card>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a reference to a Collection of Card objects
        /// </summary>
        public Collection<Card> Cards
        {
            get
            {
                return new Collection<Card>(_cards);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the CardPlayer class
        /// </summary>
        public CardPlayer()
        {
        }

        #endregion
    }
}
