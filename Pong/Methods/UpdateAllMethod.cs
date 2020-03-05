using System;
using Pong.Globals;

namespace Pong.Methods
{
     public class UpdateAllMethod
    {
        public static void UpdateAll(ConsoleKey key)
        {
            UpdatePlayerMethods.UpdatePlayerPosition(key);
            State.ScreenNeedsRefresh = true;
        }
    }
}
