namespace ShittyEngine.Entity;

public interface IEntity
{
    public Guid Id { get; }
    public string Name { get; }
    public bool IsDrawable { get; set; }
    public Point Position { get; set; }
    List<IComponent> Components { get; }

    void AddComponent(IComponent component);

    void RemoveComponent(IComponent component);

    bool FindComponent<T>();
}