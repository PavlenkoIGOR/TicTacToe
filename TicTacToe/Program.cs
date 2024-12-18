using SFML.Graphics;
using SFML.Window;
using TicTacToe.Config;
using sfml = SFML.Window;

namespace TicTacToe
{
    internal class Program
    {
        static RenderWindow wr = new RenderWindow(new VideoMode(926,926), "TicTacToe");
        static void Main(string[] args)
        {            
            wr.Closed += (s,e) => wr.Close();
            Game game = new Game(wr);

            while (wr.IsOpen == true)
            {
                wr.Clear(new Color(255,255,255));
                game.UpdateWindow();
                wr.Display();
                wr.DispatchEvents();
            }
        }
    }
}
