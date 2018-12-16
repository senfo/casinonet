using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that represent a casino player
    /// </summary>
    public class Player
    {
        #region Properties

        /// <summary>
        /// Gets the players current dollar balance
        /// </summary>
        public double Balance
        {
            get
            {
                return Purse.ValueOfChips;
            }
        }

        /// <summary>
        /// Gets or sets a reference to a players purse
        /// </summary>
        public PlayerPurse Purse
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Player class
        /// </summary>
        public Player()
        {
            Purse = new PlayerPurse();
        }

        /// <summary>
        /// Initializes a new instance of the Player class
        /// </summary>
        /// <param name="hand">The players hand</param>
        public Player(PlayerPurse hand)
        {
            Purse = hand;
        }

        #endregion
    }
}
