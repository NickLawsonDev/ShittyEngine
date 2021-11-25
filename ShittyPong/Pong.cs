using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ShittyEngine;

namespace ShittyPong;

public class Pong : Game
{
    private GraphicsDeviceManager _graphicsDeviceManager;
    private SpriteBatch _spriteBatch;
    private Engine _engine;

    public Pong()
    {
        _graphicsDeviceManager = new GraphicsDeviceManager(this);
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        var contentManager = this.Content; 
        _engine = new Engine("Content", ref _spriteBatch, ref contentManager);
        this.Content = contentManager;

        _engine.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _engine.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _engine.Draw(gameTime);

        base.Draw(gameTime);
    }
}