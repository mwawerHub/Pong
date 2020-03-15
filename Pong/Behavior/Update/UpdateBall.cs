using Pong.Abstracts;
using Pong.Globals;

namespace Pong.Behavior.Update {
    public class UpdateBall : Update
    {
        public static void UpdateBallPosition(){
            if (!Ball.CanMove()) return;
            UpdateLastPosition(Ball);

            if (CheckPosition.HasHitWall(Ball.YStartValue)){
                State.HasHitWall = true;
                Ball.SetAngleAfterWallHit(Ball.XStartValue, Ball.YStartValue);
                MoveBall();
                return;
            }

            if (CheckPosition.HasPlayer1Scored(Ball.XStartValue)) {
                ResetBallPosition();
                MoveBall();
                return;
            }

            if (CheckPosition.HasPlayer2Scored(Ball.XStartValue)) {
                ResetBallPosition();
                MoveBall();
                return;
            }

            if (CheckPosition.HasHitPlayer(Player1, Ball)){
                PlayerHit(Player1);
                return;
            }

            if (CheckPosition.HasHitPlayer(Player2, Ball)){
                PlayerHit(Player2);
                return;
            }

            Ball.Move();
        }

        private static void PlayerHit(ConsolePlayer player){
            State.HasHitWall = false;
            Ball.SetAngleAfterPlayerHit(player.YStartValue);
            MoveBall();
        }

        private static void MoveBall(){
            Ball.ChangeDirection();
            Ball.Move();
        }
    }
}
