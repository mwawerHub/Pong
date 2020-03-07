﻿using Pong.Abstracts;
using Pong.Players;
using Pong.Walls;

namespace Pong.Methods
{
    public class Initialize
    {
        protected static Player1 Player1;
        protected static Player2 Player2;
        protected static BottomWall BottomWall;
        protected static TopWall TopWall;
        protected static Ball Ball;

        public static void InitializeGame()
        {
            Player1 = new Player1();
            Player2 = new Player2();
            BottomWall = new BottomWall();
            TopWall = new TopWall();
            Ball = new Ball();
        }
    }
}