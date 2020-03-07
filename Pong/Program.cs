using System;
using System.Threading;
using Pong.Globals;
using Pong.Methods;

namespace Pong
{

    public class Program
    {
        static void Main(string[] args)
        {
            Initialize.InitializeGame();

            while (true)
            {
                Thread.Sleep(5);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    Update.UpdateAll(key);
                }

                if (State.ScreenNeedsRefresh)
                {
                    Console.Clear();
                    Draw.DrawAll();
                }

                State.ScreenNeedsRefresh = false;
            }
        }
    }
}
