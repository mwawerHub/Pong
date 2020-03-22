namespace Pong.Globals
{
    public class State
    {
        public static bool ScreenNeedsRedraw { get; set; }
        public static bool PlayerNeedsRedraw { get; set; }
        public static bool BallNeedsRedraw { get; set; }
        public static bool HasHitWall { get; set; }


        static State(){
            ScreenNeedsRedraw = true;
            PlayerNeedsRedraw = true;
            BallNeedsRedraw = true;
            HasHitWall = false;
        }
    }
}
