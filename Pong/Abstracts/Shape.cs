using Pong.Interfaces;

namespace Pong.Abstracts
{
    public abstract class Shape : IMovement
    {
        public byte Width { get; set; }
        public byte Height { get; set; }
        public byte XStartValue { get; set; }
        public byte YStartValue { get; set; }

        public abstract void Draw();

        public void MoveLeft(byte x = 1)
        {
            XStartValue--;
        }

        public void MoveRight(byte x = 1)
        {
            XStartValue++;
        }

        public void MoveUp(byte y = 1)
        {
            YStartValue--;
        }

        public void MoveDown(byte y = 1)
        {
            YStartValue++;
        }
    }
}
