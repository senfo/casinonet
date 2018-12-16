using System;
using System.Collections.Generic;
using Casino.Games.Common;
using System.Collections.ObjectModel;

namespace Casino.Games.CardGames.Poker
{
    /// <summary>
    /// Contains methods for evaluating poker hands
    /// </summary>
    public static class PokerUtility
    {
        /// <summary>
        /// Determines the hand that a player holds
        /// </summary>
        /// <param name="cards">The cards that a player possess</param>
        /// <param name="cardsInHnad">The cards the make up the hand</param>
        /// <returns>The poker hand held by a player</returns>
        public static PokerHand DetermineHand(Collection<Card> cards, out Collection<Card> cardsInHand)
        {
            cardsInHand = new Collection<Card>();

            cardsInHand.Add(
                new Card()
                {
                    CardSuit = Suit.Club,
                    CardValue = CardValue.Ace
                });

            return PokerHand.HighCards;
        }
    }
}
