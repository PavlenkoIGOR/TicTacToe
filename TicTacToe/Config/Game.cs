using SFML.Graphics;

namespace TicTacToe.Config
{
    internal class Game
    {
        RenderWindow _rw;
        BGDraw _bgDraw; 
        WindowSettings _windowSettings;
        CellNumbers _cellNumbers;
        InputLogic _inputLogic;
        internal Game(RenderWindow rw)
        {
            _rw = rw;
            _cellNumbers = new CellNumbers();
            _windowSettings = new WindowSettings();
            _bgDraw = new BGDraw(_windowSettings);
            _inputLogic = new InputLogic(_rw);
        }

        internal void UpdateWindow()
        {
            _bgDraw.DrawBackGround(_rw);
            _cellNumbers.DrawCellNumbers(_rw);
            _rw.KeyPressed +=_inputLogic.CheckInput;
            //_inputLogic.DrawFromInput(_rw);
        }
    }
}
