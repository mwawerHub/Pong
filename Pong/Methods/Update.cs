using System;
using Pong.Globals;

namespace Pong.Methods
{
     public class Update : Initialize
     { 

        private static void UpdatePlayerPosition(ConsoleKey key)
        {
            if (key == 0) return;
            Player1.Move(key);
            Player2.Move(key);
        }

        private static void UpdateBallPosition()
        {
            if(Ball.CanMove()) Ball.Move();
        }
        
        public static void UpdateAll(ConsoleKey key)
        {
            UpdatePlayerPosition(key);
            UpdateBallPosition();
            State.ScreenNeedsRefresh = true;
        }
    }
}
