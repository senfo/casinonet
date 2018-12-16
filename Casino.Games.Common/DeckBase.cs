using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Casino.Games.Common
{
    /// <summary>
    /// Defines the contract for a deck of cards
    /// </summary>
    public abstract class DeckBase : IShuffler
    {
        #region Fields

        /// <summary>
        /// Stores an offset that is used to track the cards dealt
        /// </summary>
        private int _cardOffset;

        /// <summary>
        /// Stores a collection of cards the make up a deck
        /// </summary>
        private List<Card> _cards = new List<Card>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a reference to a collection of Card objects
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
        /// Initializes a new instance of the DeckBase class
        /// </summary>
        protected DeckBase()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Deals a hand of cards to a player
        /// </summary>
        /// <param name="numbCards">Number of cars to deal</param>
        /// <returns>A collection of cards</returns>
        public IEnumerable<Card> DealHand(int numbCards)
        {
            List<Card> hand = new List<Card>(numbCards);

            if (numbCards + _cardOffset > _cards.Count)
            {
                throw new InvalidOperationException("Operation would deal more cards than exist in the deck");
            }

            for (int x = 0; x < numbCards; x++)
            {
                hand.Add(_cards[_cardOffset++]);
            }

            return hand;
        }

        /// <summary>
        /// Initializes a deck of cards
        /// </summary>
        public void Initialize()
        {
            Initialize(false);
        }

        /// <summary>
        /// Initializes a deck of cards
        /// </summary>
        /// <param name="shuffle">Indicates whether or not to shuffle the deck of cards after initializing</param>
        public abstract void Initialize(bool shuffle);

        /// <summary>
        /// Shuffles the internal Collection of Card objects
        /// </summary>
        public void Shuffle()
        {
            _cards = new List<Card>(Shuffle(this, _cards, 1));
        }

        /// <summary>
        /// Shuffles the specified collection of Card objects
        /// </summary>
        /// <param name="cards">Deck of cards to shuffle</param>
        /// <returns>A shuffled Collection of Card objects</returns>
        public IEnumerable<Card> Shuffle(IEnumerable<Card> cards)
        {
            return Shuffle(this, cards, 1);
        }

        /// <summary>
        /// Shuffles the internal Collection of Card objects
        /// </summary>
        /// <param name="passes">Specifies the number of times to shuffle</param>
        public void Shuffle(int passes)
        {
            _cards = new List<Card>(Shuffle(this, _cards, passes));
        }

        /// <summary>
        /// Shuffles the specified deck of Card objects
        /// </summary>
        /// <param name="cards">Deck of cards to shuffle</param>
        /// <param name="passes">Specifies the number of times to shuffle</param>
        /// <returns>A shuffled Collection of Card objects</returns>
        public IEnumerable<Card> Shuffle(IEnumerable<Card> cards, int passes)
        {
            int position;
            Card temp;
            Card[] cardsArray = cards.ToArray();
            Random r = new Random();

            for (int pass = 0; pass < passes; pass++)
            {
                for (int x = 0; x < cardsArray.Length; x++)
                {
                    position = r.Next(0, cardsArray.Length - 1);

                    temp = cardsArray[x];
                    cardsArray[x] = cardsArray[position];
                    cardsArray[position] = temp;
                }
            }

            return new List<Card>(cardsArray);
        }

        /// <summary>
        /// Shuffles the specified deck of cards using the specified shuffler
        /// </summary>
        /// <param name="shuffler">Indicates the specific IShuffler to use when shuffling the deck of cards</param>
        /// <param name="cards">Deck of cards to shuffle</param>
        /// <param name="passes">Specifies the number of times to shuffle</param>
        /// <returns>A shuffled Collection of Card objects</returns>
        public IEnumerable<Card> Shuffle(IShuffler shuffler, IEnumerable<Card> cards, int passes)
        {
            return shuffler.Shuffle(cards, passes);
        }

        #endregion
    }
}
