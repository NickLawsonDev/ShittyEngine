using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShittyEngine.Entity;

namespace ShittyPong.Entities.Components
{
    public class DrawableComponent : Component
    {
        private SpriteBatch _spriteBatch;
        private Texture2D _tex;
        private GraphicsDevice _graphicsDevice;

        public DrawableComponent(Entity parent, bool isDrawable, SpriteBatch spriteBatch, GraphicsDevice graphicsDevice) : base(parent, isDrawable)
        {
            _spriteBatch = spriteBatch;
            _graphicsDevice = graphicsDevice;

            _tex = new Texture2D(_graphicsDevice, 1, 1);
            _tex.SetData(new[] { Color.White });
        }

        public void Draw(GameTime gameTime)
        {
            var pos = Parent.Position;

            _spriteBatch.Draw(_tex, new Rectangle(pos.X, pos.Y, 30, 100), Color.White);
        }
    }
}