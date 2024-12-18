using SFML.Graphics;
using SFML.Window;
using TicTacToe.Resources;

namespace TicTacToe.Config
{
    internal class InputLogic
    {
        CellNumbers _cellNumbers;
        DrawXO _drawXO;
        RenderWindow _renderWindow;
        public InputLogic(RenderWindow rw)
        {
            _cellNumbers = new CellNumbers();
            _drawXO = new DrawXO();
            _renderWindow = rw;
        }
        //internal void DrawFromInput(RenderWindow rw)
        //{
        //    //int input = default;
        //    string userInput = string.Empty;
        //    bool input;
        //    sbyte inputValue = default;
        //    do
        //    {
        //        userInput = Console.ReadLine();
        //        input = sbyte.TryParse(userInput, out inputValue);
        //        //input = int.Parse(Console.ReadLine());
        //    } while (!input || inputValue <= 0 || inputValue >= 10 || inputValue == null);

        //    // Преобразуем inputValue в строку для использования в качестве ключа
        //    string key = inputValue.ToString();

        //    // Проверяем, существует ли ключ в словаре
        //    if (_cellNumbers.cellNumbers.ContainsKey(key))
        //    {
        //        // Получаем координаты из словаря
        //        int[] coordinates = _cellNumbers.cellNumbers[key];

        //        // Вызываем метод DrawX_O с полученными координатами
        //        _drawXO.DrawX_O(rw, coordinates);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Координаты не найдены для введенного значения.");
        //    }
        //}

        internal void CheckInput(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.Num1)
            {
                // Логика для обработки нажатия клавиши 1
                int[] coordinates = _cellNumbers.cellNumbers["1"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num2)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["2"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num3)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["3"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.Num4))
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["4"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num5)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["5"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num6)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["6"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num7)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["7"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num8)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["8"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
            else if (e.Code == Keyboard.Key.Num9)
            {
                // Логика для обработки нажатия клавиши 2
                int[] coordinates = _cellNumbers.cellNumbers["9"];
                _drawXO.DrawX_O(_renderWindow, coordinates);
            }
        }
    }
}
