using Pong.Behavior;
using Pong.Globals;
using System;
using System.Threading;

namespace Pong
{

    public class Program
    {
        static void Main(string[] args)
        {
            try{
                var bgMusic = new BackgroundMusic();
                bgMusic.Play();
                Initialize.InitializeGame();
                while (true){
                    Thread.Sleep(10);
                    var key = (Console.KeyAvailable) ? Console.ReadKey(true).Key : 0;
                    Update.UpdateAll(key);
                    if (State.ScreenNeedsRedraw) Console.Clear();
                    Draw.DrawAll();

                    State.ScreenNeedsRedraw = false;
                    State.PlayerNeedsRedraw = false;
                }
            }
            catch (Exception e){
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
