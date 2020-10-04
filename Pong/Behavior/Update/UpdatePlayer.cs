using Pong.Abstracts;
using Pong.Globals;
using System;

namespace Pong.Behavior.Update
{
    public class UpdatePlayer : Update
    {
        private static ConsoleKey key;

        public static void UpdatePlayerPosition(ConsoleKey pressedKey) {
            if (pressedKey == 0) return;
            key = pressedKey;
            UpdatePosition(Player1);
            UpdatePosition(Player2);
        }

        private static void UpdatePosition(ConsolePlayer player) {
            UpdateLastPosition(player);
            player.Move(key);
            if (CheckPosition.HasPlayerReachedWall(player))
                ResetPosition(player);
            else State.PlayerNeedsRedraw = true;
        }
    }
}