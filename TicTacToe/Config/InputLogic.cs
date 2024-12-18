using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Config
{
    internal class InputLogic
    {
        CellNumbers _cellNumbers;
        public InputLogic()
        {
            _cellNumbers = new CellNumbers();
        }
        internal void DrawFromInput()
        {
            //int input = default;
            string userInput = string.Empty;
            bool input;
            sbyte inputValue = default;
            do
            {
                userInput = Console.ReadLine();
                input = sbyte.TryParse(userInput, out inputValue);
                //input = int.Parse(Console.ReadLine());
            } while (!input || inputValue <= 0 || inputValue >= 10 || inputValue == null);

            switch (inputValue)
            {
                case 9:
                    break;

                case 8:
                    break;

                case 7:
                    break;

                case 6:
                    break;

                case 5:
                    break;

                case 4:
                    break;

                case 3:
                    break;

                case 2:
                    break;

                case 1:
                    break;

            }
        }
    }
}
