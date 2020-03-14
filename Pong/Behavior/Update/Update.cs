using System;
using Pong.Abstracts;

namespace Pong.Behavior.Update
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
