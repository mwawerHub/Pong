using System;
using Pong.Abstracts;

namespace Pong.Methods
{
     public class UpdateAllMethod : ObjectContainer
    {
        public static void UpdatePosition(ConsoleKey key)
        {
            Player1.Move(key);
            Player2.Move(key);
        }
    }
}
