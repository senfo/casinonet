using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that represent a players purse
    /// </summary>
    public class PlayerPurse
    {
        #region Fields

        private List<PlayerChip> _redChips;
        private List<PlayerChip> _whiteChips;
        private List<PlayerChip> _blueChips;
        private List<PlayerChip> _greenChips;
        private List<PlayerChip> _blackChips;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a reference to a list containing the red chips that a player holds
        /// </summary>
        public Collection<PlayerChip> RedChips
        {
            get
            {
                return new Collection<PlayerChip>(_redChips);
            }
        }

        /// <summary>
        /// Gets a reference to a list containing the white chips that a player holds
        /// </summary>
        public Collection<PlayerChip> WhiteChips
        {
            get
            {
                return new Collection<PlayerChip>(_whiteChips);
            }
        }

        /// <summary>
        /// Gets a reference to a list containing the blue chips that a player holds
        /// </summary>
        public Collection<PlayerChip> BlueChips
        {
            get
            {
                return new Collection<PlayerChip>(_blueChips);
            }
        }

        /// <summary>
        /// Gets a reference to a list containing the green chips that a player holds
        /// </summary>
        public Collection<PlayerChip> GreenChips
        {
            get
            {
                return new Collection<PlayerChip>(_greenChips);
            }
        }

        /// <summary>
        /// Gets a reference to a list containing the black chips that a player holds
        /// </summary>
        public Collection<PlayerChip> BlackChips
        {
            get
            {
                return new Collection<PlayerChip>(_blackChips);
            }
        }

        /// <summary>
        /// Gets the value of all chips held by the player
        /// </summary>
        public double ValueOfChips
        {
            get
            {
                return GetHandValue();
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the PlayerHand class
        /// </summary>
        public PlayerPurse()
        {
            _redChips = new List<PlayerChip>();
            _whiteChips = new List<PlayerChip>();
            _blueChips = new List<PlayerChip>();
            _greenChips = new List<PlayerChip>();
            _blackChips = new List<PlayerChip>();
        }

        /// <summary>
        /// Initializes a new instance of the PlayerHand class
        /// </summary>
        /// <param name="redChips">Specifies the number of red chips to initialize the hand with</param>
        /// <param name="redChipValue">Specifies the value associated with the red chips</param>
        /// <param name="whiteChips">Specifies the number of white chips to initialize the hand with</param>
        /// <param name="whiteChipValue">Specifies the value associated with the white chips</param>
        /// <param name="blueChips">Specifies the number of blue chips to initialize the hand with</param>
        /// <param name="blueChipValue">Specifies the value associated with the blue chips</param>
        /// <param name="greenChips">Specifies the number of green chips to initialize the hand with</param>
        /// <param name="greenChipValue">Specifies the value associated with the green chips</param>
        /// <param name="blackChips">Specifies the number of black chips to initialize the hand with</param>
        /// <param name="blackChipValue">Specifies the value associated with the black chips</param>
        public PlayerPurse(int redChips, double redChipValue, int whiteChips, double whiteChipValue, int blueChips, double blueChipValue, int greenChips, double greenChipValue, int blackChips, double blackChipValue)
        {
            _redChips = AddChips(redChips, ChipType.Red, redChipValue);
            _whiteChips = AddChips(whiteChips, ChipType.White, whiteChipValue);
            _blueChips = AddChips(blueChips, ChipType.Blue, blueChipValue);
            _greenChips = AddChips(greenChips, ChipType.Green, greenChipValue);
            _blackChips = AddChips(blackChips, ChipType.Black, blackChipValue);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes a collection of chips with the specified value
        /// </summary>
        /// <param name="numbChips">Specifies the number of chips to add</param>
        /// <param name="chipColor">Specifies the color of the chip</param>
        /// <param name="chipValue">Specifies the value of the chip</param>
        private static List<PlayerChip> AddChips(int numbChips, ChipType chipColor, double chipValue)
        {
            List<PlayerChip> chips = new List<PlayerChip>(numbChips);

            for (int x = 0; x < numbChips; x++)
            {
                chips.Add(new PlayerChip(chipColor, chipValue));
            }

            return chips;
        }

        /// <summary>
        /// Gets the value of the cards held in the hand
        /// </summary>
        private double GetHandValue()
        {
            double amount = 0;

            amount += RedChips.Sum(c => c.ChipValue);
            amount += WhiteChips.Sum(c => c.ChipValue);
            amount += BlueChips.Sum(c => c.ChipValue);
            amount += GreenChips.Sum(c => c.ChipValue);
            amount += BlackChips.Sum(c => c.ChipValue);

            return amount;
        }

        #endregion
    }
}
