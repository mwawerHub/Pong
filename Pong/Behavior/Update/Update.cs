using System;
using Pong.Abstracts;
<<<<<<< HEAD

namespace Pong.Behavior.Update
=======
using Pong.Globals;

namespace Pong.Behavior
>>>>>>> 3a1e68f09178a6982d9e200ea2e2de501577c48c
{
    public class Update : Initialize
    {
        protected static void UpdateLastPosition(Shape shape){
            shape.LastXPosition = shape.XStartValue;
            shape.LastYPosition = shape.YStartValue;
        }

        protected static void ResetBallPosition(){
            Ball.XStartValue = (Board.Width + Board.XMargin) / 2;
            Ball.YStartValue = (Board.Height + Board.YMargin) / 2;
            Ball.IsAtStartPosition = true;
        }

        public static void UpdateAll(ConsoleKey key){
            UpdatePlayer.UpdatePlayerPosition(key);
            UpdateBall.UpdateBallPosition();
        }
    }
}
