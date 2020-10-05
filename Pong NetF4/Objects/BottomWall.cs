using Pong.Abstracts;

namespace Pong.Objects
{
    public class BottomWall : Wall
    {
        public BottomWall() : base() {
            YStartValue = Board.Height;
        }
    }
}