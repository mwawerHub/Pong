using System;
using Pong.Abstracts;

namespace Pong.Methods
{
    public class UpdatePlayerMethods : ObjectContainer
    {
        public static void UpdatePlayerPosition(ConsoleKey key)
        {
            Player1.Move(key);
            Player2.Move(key);
        }
    }
}
