using Pong.Abstracts;
using Pong.Objects;

namespace Pong.Behavior
{
    public class CheckPosition
    {
        public static bool HasHitWall(int y){
            return (y == Board.YMargin || y == Board.Height);
        }

        public static bool HasPlayer1Scored(int x){
            return (x > Board.Width);
        }

        public static bool HasPlayer2Scored(int x){
            return (x < Board.XMargin);
        }

        public static bool HasHitPlayer(Shape player, Ball ball){
            return (ball.XStartValue == player.XStartValue && ball.YStartValue >= player.YStartValue &&
                    ball.YStartValue <= player.YStartValue + 5);
        }
    }
}
