using System;
using System.Collections.Generic;
using System.Text;

namespace Pong
{
    interface IMovement
    {
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        void MoveDown();
    }
}
