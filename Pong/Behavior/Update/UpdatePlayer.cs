using System;
using Pong.Globals;

namespace Pong.Behavior
{
    public class UpdatePlayer : Update
    {
        public static void UpdatePlayerPosition(ConsoleKey key){
            if (key == 0) return;
            UpdateLastPosition(Player1);
            UpdateLastPosition(Player2);
            Player1.Move(key);
            Player2.Move(key);
            State.PlayerNeedsRedraw = true;
        }
    }
}