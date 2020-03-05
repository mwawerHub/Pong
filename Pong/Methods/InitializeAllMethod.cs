using Pong.Abstracts;
using Pong.Players;
using Pong.Walls;

namespace Pong.Methods
{
    public class InitializeAllMethod : ObjectContainer
    {
        public static void InitializeGame()
        {
            Player1 = new Player1();
            Player2 = new Player2();
            BottomWall = new BottomWall();
            TopWall = new TopWall();
            Ball = new Ball();
        }
    }
}
