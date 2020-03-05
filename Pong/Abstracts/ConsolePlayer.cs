using System;

namespace Pong.Abstracts
{
    public abstract class ConsolePlayer : Shape
    {
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (var i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(XStartValue, YStartValue + i);
                Console.WriteLine("o");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public virtual void Move(ConsoleKey key) { }
    }
}
