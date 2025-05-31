using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Gme1011a2BrooklynM
{
    internal class Potion
    {
        private Texture2D _potionTexture;
        private Vector2 _location;
        private int _healamount;
        Random _rng = new Random();
        private bool _drink;


        public Potion(Vector2 location, Texture2D potionTexture)
        {
            _location = location;
            _potionTexture = potionTexture;
            _healamount = _rng.Next(5, 10);
            _drink = false;

        }

        public bool getdrink() { return _drink; }
        public int gethealamount() { return _healamount; }
        public Vector2 getLocation() { return _location; }

        public void update()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {

                _drink = true;

            }
          














        }
    }
}
      

