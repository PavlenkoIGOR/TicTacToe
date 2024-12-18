using SFML.Graphics;
using SFML.System;
using static System.Net.Mime.MediaTypeNames;
using Font = SFML.Graphics.Font;
using Text = SFML.Graphics.Text;

namespace TicTacToe.Config
{
    internal class CellNumbers
    {
        //internal sbyte[] cellNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        internal Dictionary<string, int[]> cellNumbers = new Dictionary<string, int[]>();
        Font _font = new Font("C:\\Windows\\Fonts\\arial.ttf");
        internal CellNumbers()
        {
            cellNumbers.Add("9", [300 * 2 + 26 + 300 / 2, 300 / 2]);
            cellNumbers.Add("8", [300 + 13 + 300 / 2, 300 / 2]);
            cellNumbers.Add("7", [300 / 2, 300 / 2]);

            cellNumbers.Add("6", [300 * 2 + 26 + 300 / 2, 300 + 13 + 300 / 2]);
            cellNumbers.Add("5", [300 + 13 + 300 / 2, 300 + 13 + 300 / 2]);
            cellNumbers.Add("4", [300 / 2, 300 + 13 + 300 / 2]);

            cellNumbers.Add("3", [300 * 2 + 26 + 300 / 2, 300 * 2 + 26 + 300 / 2]);
            cellNumbers.Add("2", [300 + 13 + 300 / 2, 300 * 2 + 26 + 300 / 2]);
            cellNumbers.Add("1", [300 / 2, 300 * 2 + 26 + 300 / 2]);
        }
        internal void DrawCellNumbers(RenderWindow rw)
        {
            foreach (var cellNumber in cellNumbers)
            {
                // Создаем текст для каждого ключа
                Text text = new Text(cellNumber.Key, _font, 50);
                // Устанавливаем точку привязки текста в центр
                text.Origin = new Vector2f(text.GetGlobalBounds().Width / 2, text.GetGlobalBounds().Height / 2);
                text.FillColor = Color.Green;
                text.Position = new Vector2f(cellNumber.Value[0], cellNumber.Value[1]);
                rw.Draw(text);
            }
        }
    }
}
