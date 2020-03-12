using System;
using System.Threading;
using Pong.Behavior;
using Pong.Globals;

namespace Pong
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 111;
            Console.WindowWidth = 111;
            Initialize.InitializeGame();
            while (true){
                Thread.Sleep(10);
                var key = (Console.KeyAvailable) ? Console.ReadKey(true).Key : 0;
                Update.UpdateAll(key);
                if(State.ScreenNeedsRedraw) Console.Clear();
                Draw.DrawAll();
                State.ScreenNeedsRedraw = false;
                State.PlayerNeedsRedraw = false;
            }
        }
    }
}
