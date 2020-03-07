using System;
using Pong.Globals;

namespace Pong.Methods
{
     public class Update
    {
        public static void UpdateAll(ConsoleKey key)
        {
            UpdatePlayer.UpdatePlayerPosition(key);
            State.ScreenNeedsRefresh = true;
        }
    }
}
