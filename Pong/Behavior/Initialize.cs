using Pong.Objects;
using Pong.Players;
using Pong.PrepareConsole;
using System;

namespace Pong.Behavior
{
    public class Initialize
    {
        protected static Player1 Player1;
        protected static Player2 Player2;
        protected static BottomWall BottomWall;
        protected static TopWall TopWall;
        protected static Ball Ball;


        public static void InitializeGame(){

            Console.CursorVisible = false;
            try{
                Console.SetWindowSize(1, 1);
                Console.SetBufferSize(500, 500);
                ConsoleHelper.SetConsoleFont();
                Console.SetBufferSize(150, 150);
                Console.SetWindowPosition(20, 20);
                Console.SetWindowSize(111, 111);
            }
            catch (Exception e){
                Console.WriteLine(e);
                Console.ReadKey();
            }

            Player1 = new Player1();
            Player2 = new Player2();
            BottomWall = new BottomWall();
            TopWall = new TopWall();
            Ball = new Ball();
        }
    }
}
