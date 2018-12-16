using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using Casino.Games.Common;

namespace Casino.Games.CardGames.Poker
{
    /// <summary>
    /// This is the main type for the poker game
    /// </summary>
    [CLSCompliant(false)]
    [SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification="Implemented in the base class. Check into refactoring ICasinoGame.")]
    public class CasinoNetPoker : Game, ICasinoGame
    {
        #region Fields

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _backgroundTexture;
        private Card _card;
        private Rectangle _tableRect;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Casino class
        /// </summary>
        public CasinoNetPoker()
        {
            _graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            InitGraphicsMode(1024, 600, false);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _backgroundTexture = Content.Load<Texture2D>("Sprites\\table");
            _card = new Card(Content.Load<Texture2D>("Sprites\\Deck\\19"), Suit.Heart, CardValue.Eight);
            _tableRect = new Rectangle(0, 0, _graphics.GraphicsDevice.Viewport.Width, _graphics.GraphicsDevice.Viewport.Height);

            _card.Velocity = new Vector2(2.0f, 2.0f);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

#if !XBOX
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                _card.Position += new Vector2(_card.Velocity.X, 0);
            }

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                _card.Position -= new Vector2(_card.Velocity.X, 0);
            }

            if (keyboardState.IsKeyDown(Keys.Down))
            {
                _card.Position += new Vector2(0, _card.Velocity.Y);
            }

            if (keyboardState.IsKeyDown(Keys.Up))
            {
                _card.Position -= new Vector2(0, _card.Velocity.Y);
            }
#endif

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(SpriteBlendMode.AlphaBlend);
            _spriteBatch.Draw(_backgroundTexture, _tableRect, Color.White); // Draw background image
            _spriteBatch.Draw(_card.Sprite, _card.Position, Color.White); // Draw a card

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Attempt to set the display mode to the desired resolution.  Itterates through the display
        /// capabilities of the default graphics adapter to determine if the graphics adapter supports the
        /// requested resolution.  If so, the resolution is set and the function returns true.  If not,
        /// no change is made and the function returns false.
        /// </summary>
        /// <param name="width">Desired screen width.</param>
        /// <param name="height">Desired screen height.</param>
        /// <param name="fullScreen">True if you wish to go to Full Screen, false for Windowed Mode.</param>
        private bool InitGraphicsMode(int width, int height, bool fullScreen)
        {
            // If we aren't using a full screen mode, the height and width of the window can
            // be set to anything equal to or smaller than the actual screen size.
            if (fullScreen == false)
            {
                if ((width <= GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width)
                    && (height <= GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height))
                {
                    _graphics.PreferredBackBufferWidth = width;
                    _graphics.PreferredBackBufferHeight = height;
                    _graphics.IsFullScreen = fullScreen;
                    _graphics.ApplyChanges();

                    return true;
                }
            }
            else
            {
                // If we are using full screen mode, we should check to make sure that the display
                // adapter can handle the video mode we are trying to set.  To do this, we will
                // iterate thorugh the display modes supported by the adapter and check them against
                // the mode we want to set.
                foreach (DisplayMode dm in GraphicsAdapter.DefaultAdapter.SupportedDisplayModes)
                {
                    // Check the width and height of each mode against the passed values
                    if ((dm.Width == width) && (dm.Height == height))
                    {
                        // The mode is supported, so set the buffer formats, apply changes and return
                        _graphics.PreferredBackBufferWidth = width;
                        _graphics.PreferredBackBufferHeight = height;
                        _graphics.IsFullScreen = fullScreen;
                        _graphics.ApplyChanges();

                        return true;
                    }
                }
            }

            return false;
        }

        #endregion
    }
}
