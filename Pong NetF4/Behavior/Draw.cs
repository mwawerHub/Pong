using Pong.Globals;
using System;

namespace Pong.Behavior
{
    public class Draw : Initialize
    {
        public static void DrawAll() {
            Console.ForegroundColor = ConsoleColor.White;
            try {
                if (State.ScreenNeedsRedraw) {
                    BottomWall.Draw();
                    TopWall.Draw();
                    ScoreBoard.DrawScoreBoard();
                    Player1.Draw();
                    Player2.Draw();
                }
                else if (State.PlayerNeedsRedraw) {
                    Player1.Draw();
                    Player2.Draw();
                }
                Ball.Draw();
            }
            catch (Exception e) {
                throw new InvalidOperationException("You need to use InitializeGame method before. " + e.Message);
            }
        }
    }
}