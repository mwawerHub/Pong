﻿using Pong.Abstracts;
using Pong.Enums;
using Pong.Globals;
using System;

namespace Pong.Objects
{
    public class Ball : Shape
    {
        public const byte MovementSpeed = 40;

        private static readonly Random Rng = new Random();
        private bool _diagonal = false;

        public Direction Direction { get; set; }
        public Angle Angle { get; set; }
        public DateTime LastBallMovement { get; set; }
        public bool IsAtStartPosition { get; set; }

        public Ball() {
            Height = 1;
            Width = 1;
            XStartValue = (Board.Width + Board.XMargin) / 2;
            YStartValue = (Board.Height + Board.YMargin) / 2;
            IsAtStartPosition = true;
            ChangeDirection();
        }

        public override void Draw() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(LastXPosition, LastYPosition);
            Console.Write(" ");

            if (State.BallNeedsRedraw)
                for (var i = 0; i < Width; i++) {
                    Console.SetCursorPosition(XStartValue + i, YStartValue);
                    Console.WriteLine("o");
                }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool CanMove() {
            return ((DateTime.Now - LastBallMovement).TotalMilliseconds > MovementSpeed);
        }

        public void SetAngleAfterWallHit(byte x, byte y) {
            if (y <= Board.YMargin + 1 || y >= Board.Height - 1)
                if (x <= Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.Quarter))
                    Angle = (Angle == Angle.Angle30) ? Angle.Angle60 : Angle.Angle30;
                else if (x > Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.Quarter)
                    && x < Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.Half))
                    Angle = Angle.Angle60;
                else if (x == Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.Half))
                    Angle = Angle.Angle90;
                else if (x <= Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.ThreeFourth)
                    && x > Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.Half))
                    Angle = Angle.Angle120;
                else if (x > Math.Floor((Board.Width + Board.XMargin) * AreaPercentage.ThreeFourth))
                    Angle = (Angle == Angle.Angle150) ? Angle.Angle120 : Angle.Angle150;
        }

        public void SetAngleAfterPlayerHit(byte y) {
            if (YStartValue - y < 0) Angle = Angle.Angle30;
            else if (YStartValue - y > 4) Angle = Angle.Angle150;
            else Angle = (Angle)(YStartValue - y);
        }

        public void ChangeDirection() {
            if (IsAtStartPosition) {
                Angle = (Angle)Rng.Next(0, 4);
                Direction = (Angle == Angle.Angle90) ? Direction.E : (Direction)Rng.Next(0, 5);
            }
            else {
                if (Angle == Angle.Angle30) {
                    switch (Direction) {
                        case Direction.NE:
                            Direction = (State.HasHitWall) ? Direction.SE : Direction.NW;
                            break;

                        case Direction.E:
                            Direction = Direction.NW;
                            break;

                        case Direction.SE:
                            Direction = (State.HasHitWall) ? Direction.NE : Direction.NW;
                            break;

                        case Direction.SW:
                            Direction = (State.HasHitWall) ? Direction.NW : Direction.NE;
                            break;

                        case Direction.W:
                            Direction = Direction.NE;
                            break;

                        case Direction.NW:
                            Direction = (State.HasHitWall) ? Direction.SW : Direction.NE;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle60) {
                    switch (Direction) {
                        case Direction.NE:
                            Direction = (State.HasHitWall) ? Direction.SE : Direction.NW;
                            break;

                        case Direction.E:
                            Direction = Direction.NW;
                            break;

                        case Direction.SE:
                            Direction = (State.HasHitWall) ? Direction.NE : Direction.NW;
                            break;

                        case Direction.SW:
                            Direction = (State.HasHitWall) ? Direction.NW : Direction.NE;
                            break;

                        case Direction.W:
                            Direction = Direction.NE;
                            break;

                        case Direction.NW:
                            Direction = (State.HasHitWall) ? Direction.SW : Direction.NE;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle90) {
                    switch (Direction) {
                        case Direction.NE:
                            Direction = Direction.W;
                            break;

                        case Direction.E:
                            Direction = Direction.W;
                            break;

                        case Direction.SE:
                            Direction = Direction.W;
                            break;

                        case Direction.SW:
                            Direction = Direction.E;
                            break;

                        case Direction.W:
                            Direction = Direction.E;
                            break;

                        case Direction.NW:
                            Direction = Direction.E;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle120) {
                    switch (Direction) {
                        case Direction.NE:
                            Direction = (State.HasHitWall) ? Direction.SE : Direction.SW;
                            break;

                        case Direction.E:
                            Direction = Direction.SW;
                            break;

                        case Direction.SE:
                            Direction = (State.HasHitWall) ? Direction.NE : Direction.SW;
                            break;

                        case Direction.SW:
                            Direction = (State.HasHitWall) ? Direction.NW : Direction.SE;
                            break;

                        case Direction.W:
                            Direction = Direction.SE;
                            break;

                        case Direction.NW:
                            Direction = (State.HasHitWall) ? Direction.SW : Direction.SE;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else if (Angle == Angle.Angle150) {
                    switch (Direction) {
                        case Direction.NE:
                            Direction = (State.HasHitWall) ? Direction.SE : Direction.SW;
                            break;

                        case Direction.E:
                            Direction = Direction.SW;
                            break;

                        case Direction.SE:
                            Direction = (State.HasHitWall) ? Direction.NE : Direction.SW;
                            break;

                        case Direction.SW:
                            Direction = (State.HasHitWall) ? Direction.NW : Direction.SE;
                            break;

                        case Direction.W:
                            Direction = Direction.SE;
                            break;

                        case Direction.NW:
                            Direction = (State.HasHitWall) ? Direction.SW : Direction.SE;
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        private byte[] CalculateMovement() {
            switch (Angle) {
                case Angle.Angle30:
                    return new byte[] { 1, 2 };

                case Angle.Angle60:
                    return new byte[] { 2, 1 };

                case Angle.Angle90:
                    return new byte[] { 1, 1 };

                case Angle.Angle120:
                    return new byte[] { 2, 1 };

                case Angle.Angle150:
                    return new byte[] { 1, 2 };

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Move() {
            var xModifier = CalculateMovement()[0];
            var yModifier = CalculateMovement()[1];
            _diagonal = !_diagonal;

            switch (Direction) {
                case Direction.NE:
                    if (!_diagonal) {
                        MoveUp();
                        MoveRight();
                        State.BallNeedsRedraw = true;
                    }
                    else if (xModifier == 2) MoveRight();
                    else if (yModifier == 2) MoveUp();
                    break;

                case Direction.E:
                    MoveRight();
                    State.BallNeedsRedraw = true;
                    break;

                case Direction.SE:
                    if (!_diagonal) {
                        MoveDown();
                        MoveRight();
                        State.BallNeedsRedraw = true;
                    }
                    else if (xModifier == 2) MoveRight();
                    else if (yModifier == 2) MoveDown();
                    break;

                case Direction.SW:
                    if (!_diagonal) {
                        MoveDown();
                        MoveLeft();
                        State.BallNeedsRedraw = true;
                    }
                    else if (xModifier == 2) MoveLeft();
                    else if (yModifier == 2) MoveDown();
                    break;

                case Direction.W:
                    MoveLeft();
                    State.BallNeedsRedraw = true;
                    break;

                case Direction.NW:
                    if (!_diagonal) {
                        MoveUp();
                        MoveLeft();
                        State.BallNeedsRedraw = true;
                    }
                    else if (xModifier == 2) MoveLeft();
                    else if (yModifier == 2) MoveUp();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            IsAtStartPosition = false;
            LastBallMovement = DateTime.Now;
        }
    }
}