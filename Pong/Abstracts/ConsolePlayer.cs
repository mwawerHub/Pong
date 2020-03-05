using System;
using System.Collections.Generic;
using System.Text;

namespace Pong
{
    public abstract class ConsolePlayer : Shape
    {
        public override void Draw()
        {
            for (var i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(XStartValue, YStartValue + i);
                Console.WriteLine("o");
            }
        }

        public virtual void Move(ConsoleKey key) { }
    }
}
