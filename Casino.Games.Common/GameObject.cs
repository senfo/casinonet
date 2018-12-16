using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Casino.Games.Common
{
    /// <summary>
    /// Contains properties that represent objects in the game
    /// </summary>
    public class GameObject
    {
        #region Properties

        /// <summary>
        /// Gets or sets the position of the card
        /// </summary>
        public Vector2 Position
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the sprite that represents that card
        /// </summary>
        public Texture2D Sprite
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the velocity at which an animated card moves
        /// </summary>
        public Vector2 Velocity
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the GameObject class
        /// </summary>
        public GameObject()
        {
        }

        #endregion
    }
}
