using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that define a Card
    /// </summary>
    public class Card : GameObject, IComparable
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier of the card
        /// </summary>
        public int CardId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the suit associated with the card
        /// </summary>
        public Suit CardSuit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value on the card
        /// </summary>
        public CardValue CardValue
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Card class
        /// </summary>
        public Card()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Compares the current instance with another card of the same type and returns
        /// an integer that indicates whether the current instance precedes, follows,
        /// or occurs in the same position in the sort order as the other card.
        /// </summary>
        /// <param name="obj">Card to compare to</param>
        /// <returns>A negative value if the c</returns>
        public int CompareTo(object obj)
        {
            Card card;

            if (obj == null)
            {
                return 1;
            }

            if ((card = obj as Card) == null)
            {
                throw new ArgumentException("Object is not a Card");
            }

            // This card is less than obj
            if (this.CardValue < card.CardValue)
            {
                return -1;
            }

            // This card is greater than obj
            if (this.CardValue > card.CardValue)
            {
                return 1;
            }

            // Cards are equal
            return 0;
        }

        /// <summary>
        /// Initializes a new instance of the Card class
        /// </summary>
        /// <param name="sprite">A two-dimensional texture that represents the card</param>
        /// <param name="cardSuit">The suit associated with the card</param>
        /// <param name="cardValue">The value on the card</param>
        public Card(Texture2D sprite, Suit cardSuit, CardValue cardValue)
        {
            Sprite = sprite;
            Position = Vector2.Zero;
            CardSuit = cardSuit;
            CardValue = cardValue;
            Velocity = Vector2.Zero;
        }

        #endregion

        #region Overriden Methods

        /// <summary>
        /// Returns a value indicating whether this instance is equal to specified Card object
        /// </summary>
        /// <param name="card">Card to compare to</param>
        /// <returns>True if the cards are equal. Otherwise false.</returns>
        public override bool Equals(object obj)
        {
            Card card;

            if ((card = obj as Card) == null)
            {
                return false;
            }

            return (this.CardValue == card.CardValue) && (this.CardSuit == card.CardSuit);
        }

        /// <summary>
        /// Returns the hash code for the value of the instance
        /// </summary>
        /// <returns>The hash code for the value of the instance</returns>
        public override int GetHashCode()
        {
            return this.CardSuit.GetHashCode() + this.CardValue.GetHashCode();
        }

        #endregion

        #region Operator Overloads

        /// <summary>
        /// Determines whether two cards are equal in value
        /// </summary>
        /// <param name="card1">First card to compare</param>
        /// <param name="card2">Second card to comare</param>
        /// <returns>True if the two cards are equal, otherwise false</returns>
        public static bool operator ==(Card card1, Card card2)
        {
            if ((card1 is Card) &&
                (card2 is Card))
            {
                return card1.Equals(card2);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether two cards are equal in value
        /// </summary>
        /// <param name="card1">First card to compare</param>
        /// <param name="card2">Second card to comare</param>
        /// <returns>True if the two cards are NOT equal, otherwise false</returns>
        public static bool operator !=(Card card1, Card card2)
        {
            return !card1.Equals(card2);
        }

        /// <summary>
        /// Determines if the value of one card is less than the value of another
        /// </summary>
        /// <param name="card1">First card to compare</param>
        /// <param name="card2">Second card to compare</param>
        /// <returns>True if card1 is less than the value of card 2, otherwise false</returns>
        public static bool operator <(Card card1, Card card2)
        {
            return card1.CompareTo(card2) < 0;
        }

        /// <summary>
        /// Determines if the value of one card is less than the value of another
        /// </summary>
        /// <param name="card1">First card to compare</param>
        /// <param name="card2">Second card to compare</param>
        /// <returns>True if card1 is greater than the value of card 2, otherwise false</returns>
        public static bool operator >(Card card1, Card card2)
        {
            return card1.CompareTo(card2) > 0;
        }

        /// <summary>
        /// Determines if the value of one card is less than or equal to the value of another
        /// </summary>
        /// <param name="card1">First card to compare</param>
        /// <param name="card2">Second card to compare</param>
        /// <returns>True if card1 is less than or equal to card2, otherwise false</returns>
        public static bool operator <=(Card card1, Card card2)
        {
            return card1.CompareTo(card2) <= 0;
        }

        /// <summary>
        /// Determines if the value of one card is greater than or equal to the value of another
        /// </summary>
        /// <param name="card1">First card to compare</param>
        /// <param name="card2">Second card to compare</param>
        /// <returns>True if card1 is greater than or equal to card2, otherwise false</returns>
        public static bool operator >=(Card card1, Card card2)
        {
            return card1.CompareTo(card2) >= 0;
        }

        #endregion
    }
}
