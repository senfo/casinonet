using System;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that represent a player chip
    /// </summary>
    public class PlayerChip
    {
        #region Properties

        /// <summary>
        /// Gets or sets the type of chip
        /// </summary>
        public ChipType ChipColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the value associated with the chip
        /// </summary>
        public double ChipValue
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the PlayerChip class
        /// </summary>
        public PlayerChip()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlayerChip class
        /// </summary>
        /// <param name="chipColor">Specifies the color of the chip</param>
        /// <param name="chipValue">Specifies the value associated with the chip</param>
        public PlayerChip(ChipType chipColor, double chipValue)
        {
            ChipColor = chipColor;
            ChipValue = chipValue;
        }

        #endregion
    }
}
