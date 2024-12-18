using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Config
{
    internal class Game
    {
        RenderWindow _rw;
        BGDraw _bgDraw; 
        WindowSettings _windowSettings;
        CellNumbers _cellNumbers;
        internal Game(RenderWindow rw)
        {
            _rw = rw;
            _cellNumbers = new CellNumbers();
            _windowSettings = new WindowSettings();
            _bgDraw = new BGDraw(_windowSettings);
        }

        internal void UpdateWindow()
        {
            _bgDraw.DrawBackGround(_rw);
            _cellNumbers.DrawCellNumbers(_rw);
        }
    }
}
