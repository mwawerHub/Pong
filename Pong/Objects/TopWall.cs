using Pong.Abstracts;

namespace Pong.Objects
{
    public class TopWall : Wall
    {
        public TopWall() : base(){
            YStartValue = Board.BoardYMargin;
        }
    }
}
