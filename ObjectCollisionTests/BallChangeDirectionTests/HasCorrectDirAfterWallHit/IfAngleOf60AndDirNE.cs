using System;
using NUnit.Framework;
using Pong.Enums;
using Pong.Globals;
using Pong.Objects;

namespace ObjectCollisionTests
{
    public class IfAngleOf60AndDirNE
    {
        public Ball ball;

        [SetUp]
        public void Setup(){
            ball = new Ball();
            ball.Angle = Angle.Angle60;
            ball.Direction = Direction.NE;
            ball.IsAtStartPosition = false;
            State.HasHitWall = true;
            ball.ChangeDirection();

        }

        [Test]
        public void ShouldHaveDirSETest(){
            Assert.IsTrue(ball.Direction == Direction.SE,ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSETest1(){
            Assert.IsFalse(ball.Direction == Direction.E, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSETest2(){
            Assert.IsFalse(ball.Direction == Direction.NE, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSETest3(){
            Assert.IsFalse(ball.Direction == Direction.SW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSETest4(){
            Assert.IsFalse(ball.Direction == Direction.NW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSETest5(){
            Assert.IsFalse(ball.Direction == Direction.W, ball.Direction.ToString());
        }
    }
}