using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShittyEngine.Entity;
using ShittyPong.Entities.Components;
using System.Collections.Generic;

namespace ShittyPong.Entities
{
    public class Player : Entity
    {
        private GraphicsDevice _graphicsDevice;

        private Texture2D _tex;
        public Player(string name, Point pos, bool isDrawable, SpriteBatch spriteBatch, GraphicsDevice graphicsDevice) : base(name, pos, isDrawable)
        {
            _graphicsDevice = graphicsDevice;

            _tex = new Texture2D(_graphicsDevice, 1, 1);
            _tex.SetData(new[] { Color.White });
        }


    }
}