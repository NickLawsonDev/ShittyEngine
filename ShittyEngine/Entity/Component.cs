namespace ShittyEngine.Entity
{
    public class Component : IComponent
    {
        public Guid Id => Guid.NewGuid();

        private Entity _parent { get; }
        public Entity Parent => _parent;

        private bool _isDrawable { get; set; }

        public bool IsDrawable
        {
            get => _isDrawable;
            set => _isDrawable = value;
        }

        public Component(Entity parent, bool isDrawable)
        {
            _parent = parent;
            _isDrawable = isDrawable;
        }
    }
}