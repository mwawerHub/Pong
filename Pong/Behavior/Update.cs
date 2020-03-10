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
            Player1.Move(key);
            Player2.Move(key);
        }

        private static void UpdateBallPosition()
        {
            if (Ball.CanMove()) Ball.Move();

            if (CheckPosition.HasHitPlayer(Player1, Ball))
            {
                Ball.ChangeDirection();
                Ball.SetAngle(Player1.YStartValue);
                Ball.Move();
                return;
            }

            if (CheckPosition.HasHitPlayer(Player2, Ball))
            {
                Ball.ChangeDirection();
                Ball.SetAngle(Player2.YStartValue);
                Ball.Move();
                return;
            }

            if (CheckPosition.HasPlayer1Scored(Ball.XStartValue))
            {
                ResetBallPosition();

                Ball.ChangeDirection();
                Ball.Move();
                return;
            }

            if (CheckPosition.HasPlayer2Scored(Ball.XStartValue))
            {
                ResetBallPosition();

                Ball.ChangeDirection();
                Ball.Move();
                return;
            }

            if (CheckPosition.HasHitWall(Ball.YStartValue))
            {
                Ball.ChangeDirection();
                Ball.Move();
                return;
            }
        }

        private static void ResetBallPosition()
        {
            Ball.XStartValue = (Board.BoardWidth + Board.BoardXMargin ) / 2;
            Ball.YStartValue = (Board.BoardHeight + Board.BoardYMargin) / 2;
            Ball.IsAtStartPosition = true;
        }

        public static void UpdateAll(ConsoleKey key)
        {
            UpdatePlayerPosition(key);
            UpdateBallPosition();
            State.ScreenNeedsRefresh = true;
        }
    }
}
