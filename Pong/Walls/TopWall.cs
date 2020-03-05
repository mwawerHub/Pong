using Pong.Abstracts;

namespace Pong.Walls
{
    public class TopWall : Wall
    {
        public TopWall():base()
        {
            YStartValue = Board.BoardYMargin;
        }
    }
}
