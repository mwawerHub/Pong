using System;
using NUnit.Framework;
using Pong.Enums;
using Pong.Globals;
using Pong.Objects;

namespace ObjectCollisionTests
{
    public class IfAngleOf60AndDirSE
    {
        public Ball ball;

        [SetUp]
        public void Setup(){
            ball = new Ball();
            ball.Angle = Angle.Angle30;
            ball.Direction = Direction.SE;
            ball.IsAtStartPosition = false;
            State.HasHitWall = true;
            ball.ChangeDirection();
        }

        [Test]
        public void ShouldHaveDirNETest(){
            Assert.IsTrue(ball.Direction == Direction.NE,ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNETest1(){
            Assert.IsFalse(ball.Direction == Direction.E, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNETest2(){
            Assert.IsFalse(ball.Direction == Direction.NW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNETest3(){
            Assert.IsFalse(ball.Direction == Direction.SW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNETest4(){
            Assert.IsFalse(ball.Direction == Direction.SE, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNETest5(){
            Assert.IsFalse(ball.Direction == Direction.W, ball.Direction.ToString());
        }
    }
}