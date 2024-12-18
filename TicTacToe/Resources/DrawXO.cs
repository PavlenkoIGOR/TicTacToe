using SFML.Graphics;
using SFML.System;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe.Resources
{
    internal class DrawXO
    {
        Texture _textureX;
        Texture _textureO;
        Sprite _sprite;
        public DrawXO()
        {
            _textureX = new Texture("Resources/img/TicTacToe_x.jpg");
            _textureO = new Texture("Resources/img/TicTacToe_o.jpg");
        }
        internal void DrawX_O(RenderWindow rw, int[] coord)
        {
            _sprite = new Sprite(_textureX);
            
            
            //_sprite.Scale = new SFML.System.Vector2f(300, 300);
            _sprite.Origin = new Vector2f(_sprite.Scale.X / 2, _sprite.Scale.Y / 2);
            _sprite.Position = new SFML.System.Vector2f(coord[0], coord[1]);
            rw.Draw(_sprite);
        }
    }
}
