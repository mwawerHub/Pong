using System;

namespace Pong.Abstracts
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
