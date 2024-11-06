using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.CompilerServices;

namespace MonoGame_Topic_1___Adding_Content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture;
        Texture2D dinoDeadTexture;
        Texture2D skylineTexture;
        Texture2D fireTexture;
        Texture2D halloweenTexture;
        Texture2D zombieTexture;
        Texture2D moonTexture;
        Texture2D ghostTexture;
        private int whichPicture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 850;
            _graphics.PreferredBackBufferHeight = 485;
            _graphics.ApplyChanges();

            Random generator = new Random();
            whichPicture = generator.Next(2);
            this.Window.Title = "First MonoGame Project";


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            dinoTexture = Content.Load<Texture2D>("dino");
            dinoDeadTexture = Content.Load<Texture2D>("dinoDead");
            skylineTexture = Content.Load<Texture2D>("skyline");
            fireTexture = Content.Load<Texture2D>("fire");
            halloweenTexture = Content.Load<Texture2D>("HalloweenBG");
            zombieTexture = Content.Load<Texture2D>("zombie");
            moonTexture = Content.Load<Texture2D>("moon");
            ghostTexture = Content.Load<Texture2D>("ghost");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.BlanchedAlmond);
            _spriteBatch.Begin();
            if (whichPicture == 0) //Godzilla mourns death of fellow Godzilla, destroys city
            {
                _spriteBatch.Draw(skylineTexture, new Vector2(0, 0), Color.White);
                _spriteBatch.Draw(dinoTexture, new Vector2(370, 130), Color.White);
                _spriteBatch.Draw(dinoDeadTexture, new Vector2(300, 325), Color.Red);
                _spriteBatch.Draw(fireTexture, new Vector2(150, 330), Color.White);
                _spriteBatch.Draw(fireTexture, new Vector2(700, 330), Color.White);
                _spriteBatch.Draw(fireTexture, new Vector2(0, 330), Color.White);
                _spriteBatch.Draw(fireTexture, new Vector2(175, 87), Color.White);
                _spriteBatch.Draw(fireTexture, new Vector2(300, 133), Color.White);
                _spriteBatch.Draw(fireTexture, new Vector2(730, 110), Color.White);
            }
            else if (whichPicture == 1) //Halloween
            {
                _spriteBatch.Draw(halloweenTexture, new Vector2(0, 0), Color.White);
                _spriteBatch.Draw(zombieTexture, new Vector2(755, 265), Color.White);
                _spriteBatch.Draw(moonTexture, new Vector2(40, -25), Color.White);
                _spriteBatch.Draw(ghostTexture, new Vector2(400, 55), Color.White);
            }
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
