using System;
using Pong.Abstracts;

namespace Pong.Methods
{
    public class DrawAllMethod : ObjectContainer
    {
        public static void DrawAll()
        {
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                Player1.Draw();
                Player2.Draw();
                BottomWall.Draw();
                TopWall.Draw();
                Ball.Draw();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("You need to use InitializeGame method before. " + e.Message);
            }

        }




    }
}
