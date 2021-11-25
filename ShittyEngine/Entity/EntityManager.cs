namespace ShittyEngine.Entity;

public class EntityManager : IManager
{
    private SpriteBatch _spriteBatch;
    private GraphicsDevice _graphicsDevice;

    public List<IEntity> Entities = new List<IEntity>();

    public EntityManager(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
    {
        _spriteBatch = spriteBatch;
        _graphicsDevice = graphicsDevice;
    }

    public void LoadContent()
    {
        foreach (var entity in Entities)
        {
            foreach (var component in entity.Components)
            {
                component.LoadContent();
            }
        }
    }

    public void Update(GameTime gameTime)
    {
        foreach (var entity in Entities)
        {
            foreach (var component in entity.Components)
            {
                component.Update(gameTime);
            }
        }
    }

    public void Draw(GameTime gameTime)
    {
        foreach (var entity in Entities)
        {
            foreach (var component in entity.Components.Where(x => x.IsDrawable))
            {
                component.Draw(gameTime);
            }
        }
    }
}