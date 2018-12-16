using System;
using System.Collections.Generic;
using System.Text;

namespace Casino.Games.Common
{
    /// <summary>
    /// Represents the type of chip
    /// </summary>
    public enum ChipType
    {
        /// <summary>
        /// Represents a red chip
        /// </summary>
        Red,

        /// <summary>
        /// Represents a white chip
        /// </summary>
        White,

        /// <summary>
        /// Represents a blue chip
        /// </summary>
        Blue,

        /// <summary>
        /// Represents a green chip
        /// </summary>
        Green,

        /// <summary>
        /// Represents a black chip
        /// </summary>
        Black
    }

    /// <summary>
    /// Represents the suit of the card
    /// </summary>
    public enum Suit
    {
        /// <summary>
        /// Represents a red card with heart shapes
        /// </summary>
        Heart,

        /// <summary>
        /// Represents a black card with club shapes
        /// </summary>
        Club,

        /// <summary>
        /// Represents a black card with spade shapes
        /// </summary>
        Spade,

        /// <summary>
        /// Represents a red card with diamond shapes
        /// </summary>
        Diamond
    }

    /// <summary>
    /// Represents the value on the card
    /// </summary>
    public enum CardValue
    {
        /// <summary>
        /// Represents no clue
        /// </summary>
        None = 0,

        /// <summary>
        /// The Joker card
        /// </summary>
        Joker,

        /// <summary>
        /// The Two card
        /// </summary>
        Two,

        /// <summary>
        /// The Three card
        /// </summary>
        Three,

        /// <summary>
        /// The Four card
        /// </summary>
        Four,

        /// <summary>
        /// The Five card
        /// </summary>
        Five,

        /// <summary>
        /// The Six card
        /// </summary>
        Six,

        /// <summary>
        /// The Seven card
        /// </summary>
        Seven,

        /// <summary>
        /// The Eight card
        /// </summary>
        Eight,

        /// <summary>
        /// The Nine card
        /// </summary>
        Nine,

        /// <summary>
        /// The Ten card
        /// </summary>
        Ten,

        /// <summary>
        /// The Jack queen
        /// </summary>
        Jack,

        /// <summary>
        /// The Queen card
        /// </summary>
        Queen,

        /// <summary>
        /// The King card
        /// </summary>
        King,

        /// <summary>
        /// The Ace card
        /// </summary>
        Ace
    }

    /// <summary>
    /// Represents a hand of poker
    /// </summary>
    public enum PokerHand
    {
        /// <summary>
        /// Represents a hand with high cards
        /// </summary>
        HighCards,

        /// <summary>
        /// Represents a hand with one pair
        /// </summary>
        OnePair,

        /// <summary>
        /// Represents a hand with two pairs
        /// </summary>
        TwoPair,

        /// <summary>
        /// Represents a hand with three of a kind
        /// </summary>
        ThreeOfAKind,

        /// <summary>
        /// Represents a straight
        /// </summary>
        Straight,

        /// <summary>
        /// Represents a flush
        /// </summary>
        Flush,

        /// <summary>
        /// Represents a full house
        /// </summary>
        FullHouse,

        /// <summary>
        /// Represents four of a kind
        /// </summary>
        FourOfAKind,

        /// <summary>
        /// Represents a straight flush
        /// </summary>
        StraightFlush,

        /// <summary>
        /// Represents a royal flush
        /// </summary>
        RoyalFlush
    }
}
