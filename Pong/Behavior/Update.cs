using System;
using Pong.Abstracts;
using Pong.Globals;

namespace Pong.Behavior
{
    public class Update : Initialize
    {

        private static void UpdatePlayerPosition(ConsoleKey key)
        {
            if (key == 0) return;
            UpdateLastPosition(Player1);
            UpdateLastPosition(Player2);
            Player1.Move(key);
            Player2.Move(key);
            State.PlayerNeedsRedraw = true;
        }

        private static void UpdateBallPosition(){
            if (Ball.CanMove()){
                UpdateLastPosition(Ball);
                Ball.Move();
            }

            if (CheckPosition.HasHitPlayer(Player1, Ball)){
                State.HasHitWall = false;
                State.HasHitPlayer = true;
                Ball.SetAngleAfterPlayerHit(Player1.YStartValue);
                Ball.ChangeDirection();
                Ball.Move();
                return;
            }

            if (CheckPosition.HasHitPlayer(Player2, Ball)){
                State.HasHitWall = false;
                State.HasHitPlayer = true;
                Ball.SetAngleAfterPlayerHit(Player2.YStartValue);
                Ball.ChangeDirection();
                Ball.Move();
                return;
            }

            if (CheckPosition.HasPlayer1Scored(Ball.XStartValue)){
                ResetBallPosition();
                Ball.ChangeDirection();
                Ball.Move();
                return;
            }

            if (CheckPosition.HasPlayer2Scored(Ball.XStartValue)){
                ResetBallPosition();
                Ball.ChangeDirection();
                Ball.Move();
                return;
            }

            if (CheckPosition.HasHitWall(Ball.YStartValue))
            {
                State.HasHitWall = true;
                State.HasHitPlayer = false;
                Ball.SetAngleAfterWallHit(Ball.XStartValue, Ball.YStartValue);
                Ball.ChangeDirection();
                Ball.Move();
                return;
            }
        }

        private static void UpdateLastPosition(Shape shape){
            shape.LastXPosition = shape.XStartValue;
            shape.LastYPosition = shape.YStartValue;
        }

        private static void ResetBallPosition(){
            Ball.XStartValue = (Board.Width + Board.XMargin) / 2;
            Ball.YStartValue = (Board.Height + Board.YMargin) / 2;
            Ball.IsAtStartPosition = true;
        }

        public static void UpdateAll(ConsoleKey key){
            UpdatePlayerPosition(key);
            UpdateBallPosition();
        }
    }
}
