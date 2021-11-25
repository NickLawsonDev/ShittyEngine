namespace ShittyEngine.Entity
{
    public class Entity : IEntity
    {
        public Guid Id => Guid.NewGuid();

        public string Name { get; }

        public List<IComponent> Components => new List<IComponent>();

        private bool _isDrawable { get; set; }

        public bool IsDrawable
        {
            get => _isDrawable;
            set => _isDrawable = value;
        }

        private Point _position { get; set; }

        public Point Position
        {
            get => _position;
            set => _position = value;
        }

        public Entity(string name, Point pos, bool isDrawable = true)
        {
            Name = name;
            Position = pos;
            IsDrawable = isDrawable;
        }

        public void AddComponent(IComponent component)
        {
            if (component == null) throw new ArgumentNullException(nameof(component));

            Components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            if (component == null) throw new ArgumentNullException(nameof(component));

            Components.Remove(component);
        }

        public bool FindComponent<T>()
        {
            if (Components.Count == 0) return false;
            return Components.Any(x => x.GetType() == typeof(T));
        }
    }
}