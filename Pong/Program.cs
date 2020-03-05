using System;
using System.Threading;
using Pong.Abstracts;
using Pong.Methods;
using Pong.Players;
using Pong.Walls;

namespace Pong
{

    public class Program
    {
        static void Main(string[] args)
        {
            InitializeAllMethod.InitializeGame();

            while (true)
            {
                Console.Clear();
                Thread.Sleep(10);
                DrawAllMethod.DrawAll();

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    UpdateAllMethod.UpdatePosition(key);
                }

            }
        }
    }
}
