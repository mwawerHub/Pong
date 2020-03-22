using Pong.Objects;
using Pong.Players;
using Pong.PrepareConsole;
using System;
using Pong.Abstracts;

namespace Pong.Behavior {
    public class Initialize
     {
         protected static Player1 Player1;
         protected static Player2 Player2;
         protected static BottomWall BottomWall;
         protected static TopWall TopWall;
         protected static Ball Ball;
         protected static ScoreBoard ScoreBoard;


         public static void InitializeGame()
         {

             Console.CursorVisible = false;
             try{
                 ConsoleHelper.SetConsoleFont();
                 Console.SetWindowSize(1, 1);
                 Console.SetWindowPosition(0, 0);
                 Console.SetBufferSize(91, 71);
                 Console.SetWindowSize(91, 71);
                 Console.Title = "Pong";
                 Introduction.DrawInstructions();
                 Console.ReadKey();
             }
             catch (Exception e)
             {
                 Console.WriteLine(e);
                 Console.ReadKey();
             }

             ScoreBoard = new ScoreBoard();
             Player1 = new Player1();
             Player2 = new Player2();
             BottomWall = new BottomWall();
             TopWall = new TopWall();
             Ball = new Ball();
         }
     }
 }