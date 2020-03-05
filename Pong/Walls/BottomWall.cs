using System;
using System.Collections.Generic;
using System.Text;
using Pong.Abstracts;

namespace Pong.Walls
{
    public class BottomWall : Wall
    {
        public BottomWall():base()
        {
            YStartValue = Board.BoardHeight;
        }
    }
}
