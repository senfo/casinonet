using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casino.Games.Common
{
    /// <summary>
    /// Defines the contract for a card shuffler
    /// </summary>
    public interface IShuffler
    {
        /// <summary>
        /// Shuffles a deck of cards
        /// </summary>
        void Shuffle();

        /// <summary>
        /// Shuffles a deck of cards
        /// </summary>
        /// <param name="passes">Specifies the number of times to shuffle the deck</param>
        void Shuffle(int passes);

        /// <summary>
        /// Shuffles a deck of cards
        /// </summary>
        /// <param name="cards">Deck of cards to shuffle</param>
        /// <returns>A shuffled Collection of Card objects</returns>
        IEnumerable<Card> Shuffle(IEnumerable<Card> cards);

        /// <summary>
        /// Shuffles the specified deck of cards
        /// </summary>
        /// <param name="cards">Deck of cards to shuffle</param>
        /// <param name="passes">Specifies the number of times to shuffle the deck</param>
        /// <returns>A shuffled Collection of Card objects</returns>
        IEnumerable<Card> Shuffle(IEnumerable<Card> cards, int passes);

        /// <summary>
        /// Shuffles the specified deck of cards using the specified shuffler
        /// </summary>
        /// <param name="shuffler">Indicates the specific IShuffler to use when shuffling the deck of cards</param>
        /// <param name="cards">Deck of cards to shuffle</param>
        /// <param name="passes">Specifies the number of times to shuffle the deck</param>
        /// <returns>A shuffled Collection of Card objects</returns>
        IEnumerable<Card> Shuffle(IShuffler shuffler, IEnumerable<Card> cards, int passes);
    }
}
