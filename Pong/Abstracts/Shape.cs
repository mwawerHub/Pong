using Pong.Interfaces;

namespace Pong.Abstracts
{
    public abstract class Shape : IMovement
    {
        public byte Width { get; set; }
        public byte Height { get; set; }
        public byte XStartValue { get; set; }
        public byte YStartValue { get; set; }
        public byte LastXPosition { get; set; }
        public byte LastYPosition { get; set; }

        public abstract void Draw();

        public void MoveLeft(byte x = 1) { XStartValue -= x; }

        public void MoveRight(byte x = 1) { XStartValue += x; }

        public void MoveUp(byte y = 1) { YStartValue -= y; }

        public void MoveDown(byte y = 1) { YStartValue += y; }
    }
}
