using Microsoft.Xna.Framework.Content;
using ShittyEngine.Render;

namespace ShittyEngine;

public class Engine
{
    private SceneManager _sceneManager;
    private SpriteBatch _spriteBatch;

    public Engine(string contentDirectory, ref SpriteBatch spriteBatch, ref ContentManager contentManager)
    {
        _sceneManager = new SceneManager(contentManager);
        _spriteBatch = spriteBatch;

        contentManager.RootDirectory = contentDirectory;
    }

    public void LoadContent()
    {
        _sceneManager.LoadContent();
    }

    public void Update(GameTime gameTime)
    {
        _sceneManager.Update(gameTime);
    }

    public void Draw(GameTime gameTime)
    {
        _spriteBatch.Begin();

        _sceneManager.Draw(gameTime);

        _spriteBatch.End();
    }
}