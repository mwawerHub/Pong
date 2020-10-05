using Pong.Abstracts;
using Pong.Objects;

namespace Pong.Behavior
{
    public class CheckPosition
    {
        public static bool HasHitWall(int y) {
            return (y == Board.YMargin + 1 || y == Board.Height - 1);
        }

        public static bool HasHitPlayer(Shape player, Ball ball) {
            var offset = -1;

            if (player.XStartValue == Board.XMargin)
                offset = 1;

            return ((ball.XStartValue == player.XStartValue + offset)
                && ball.YStartValue >= player.YStartValue
                && ball.YStartValue <= player.YStartValue + player.Width);
        }

        public static bool HasPlayer1Scored(int x) {
            return (x > Board.Width);
        }

        public static bool HasPlayer2Scored(int x) {
            return (x < Board.XMargin);
        }

        public static bool HasPlayerReachedWall(ConsolePlayer player) {
            return (player.YStartValue == Board.YMargin || player.YStartValue == Board.Height - player.Height - 3);
        }
    }
}