using ShittyEngine.Assets;
using ShittyEngine.Entity;

namespace ShittyEngine.Render;

internal interface IScene
{
    string Name { get; }
    Guid Id { get; }
    AssetManager AssetManager { get; }
    EntityManager EntityManager { get; }
    void LoadContent() { }
    void UnloadContent() { }
    void Update(GameTime gameTime) { }
    void Draw(GameTime gameTime) { }
}