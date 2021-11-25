namespace ShittyEngine.Entity;

public interface IComponent
{
    Guid Id { get; }
    Entity Parent { get; }
    bool IsDrawable { get; set; }

    void LoadContent() { }
    void UnloadContent() { }
    void Update(GameTime gameTime) { }
    void Draw(GameTime gameTime) { }
}