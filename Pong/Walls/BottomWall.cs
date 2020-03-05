using Pong.Abstracts;

namespace Pong.Walls
{
    public class BottomWall : Wall
    {
        public BottomWall():base()
        {
            YStartValue = Board.BoardHeight;
        }
    }
}
