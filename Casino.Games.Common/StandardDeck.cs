using System;

namespace Casino.Games.Common
{
    /// <summary>
    /// Defines a standard deck with 52 cards
    /// </summary>
    public class StandardDeck : DeckBase
    {
        #region Constants

        /// <summary>
        /// Defines the size of the deck
        /// </summary>
        public const int DeckSize = 52;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the StandardDeck class
        /// </summary>
        public StandardDeck()
            : base()
        {
        }

        #endregion

        #region DeckBase Members

        /// <summary>
        /// Initializes a standard deck of cards
        /// </summary>
        /// <param name="shuffle">Indicates whether or not to shuffle the deck of cards after initializing</param>
        public override void Initialize(bool shuffle)
        {
            int cardCount = 0;

            // Initializes the four suits
            for (int x = 0; x < 4; x++)
            {
                // Intializes the cards in the suit
                for (int j = 2; j < 15; j++)
                {
                    Cards.Add(new Card
                               {
                                   CardId = ++cardCount,
                                   CardSuit = (Suit)x,
                                   CardValue = (CardValue)j
                               });
                }
            }

            // Shuffle the deck of cards if necessary
            if (shuffle)
            {
                Shuffle();
            }
        }

        #endregion
    }
}
