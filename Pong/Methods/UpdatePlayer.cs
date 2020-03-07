using System;
using Pong.Abstracts;

namespace Pong.Methods
{
    public class UpdatePlayer : Initialize
    {
        public static void UpdatePlayerPosition(ConsoleKey key)
        {
            Player1.Move(key);
            Player2.Move(key);
        }
    }
}
