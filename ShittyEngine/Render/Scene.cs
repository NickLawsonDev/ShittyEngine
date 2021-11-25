using Microsoft.Xna.Framework.Content;
using ShittyEngine.Assets;
using ShittyEngine.Entity;

namespace ShittyEngine.Render;

public class Scene : IScene
{
    public string Name { get; }
    public Guid Id => Guid.NewGuid();

    private ContentManager _contentManager;
    public AssetManager AssetManager => new(_contentManager);
    public EntityManager EntityManager => new();

    public Scene(string name, ContentManager contentManager)
    {
        Name = name;
        _contentManager = contentManager;
    }

    public void LoadContent() { }
    public void UnloadContent() { }
    public void Update(GameTime gameTime) { }
    public void Draw(GameTime gameTime) { }
}