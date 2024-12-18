using SFML.Graphics;
using SFML.System;

namespace TicTacToe.Config
{
    internal class BGDraw
    {
        Sprite backgroundSprite;
        // Загружаем текстуру
        Texture backgroundTexture;
        WindowSettings _windowSettings;
        internal BGDraw(WindowSettings windowSettings)
        {
            backgroundTexture = new Texture("Resources/img/TicTacToe_bg.jpg");
            backgroundSprite = new Sprite(backgroundTexture);
            _windowSettings = windowSettings;
        }
        internal void DrawBackGround(RenderWindow rw)
        {
            // Установка спрайта в размер окна
            backgroundSprite.Scale = new Vector2f(_windowSettings.windowWidth / backgroundTexture.Size.X, _windowSettings.windowHeight / backgroundTexture.Size.Y);
            rw.Draw(backgroundSprite);
        }
    }
}
