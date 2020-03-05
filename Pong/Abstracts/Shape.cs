using System;
using System.Collections.Generic;
using System.Text;

namespace Pong
{
    public abstract class Shape : IMovement
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int XStartValue { get; set; }
        public int YStartValue { get; set; }

        public abstract void Draw();

        public void MoveLeft()
        {
            XStartValue--;
        }

        public void MoveRight()
        {
            XStartValue++;
        }

        public void MoveUp()
        {
            YStartValue--;
        }

        public void MoveDown()
        {
            YStartValue++;
        }
    }
}
