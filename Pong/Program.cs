using System;
using Pong.Players;

namespace Pong
{

    public class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player1();
            var player2 = new Player2();

            while (true)
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;

                player1.Draw();
                player2.Draw();

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;

                    player1.Move(key);
                    player2.Move(key);
                }

                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
