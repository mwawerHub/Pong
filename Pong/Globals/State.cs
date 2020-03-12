namespace Pong.Globals
{
    public class State
    {
        public static bool ScreenNeedsRedraw { get; set; }
        public static bool PlayerNeedsRedraw { get; set; }
        public static bool HasHitWall { get; set; }
        public static bool HasHitPlayer { get; set; }


        static State(){
            ScreenNeedsRedraw = true;
            PlayerNeedsRedraw = true;
            HasHitPlayer = false;
            HasHitWall = false;
        }
    }
}
