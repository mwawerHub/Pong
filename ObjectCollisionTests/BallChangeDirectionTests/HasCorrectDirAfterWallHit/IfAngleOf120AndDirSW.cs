using NUnit.Framework;
using Pong.Enums;
using Pong.Globals;
using Pong.Objects;

namespace ObjectCollisionTests
{
    public class IfAngleOf120AndDirSW
    {
        public Ball ball;

        [SetUp]
        public void Setup(){
            ball = new Ball();
            ball.Angle = Angle.Angle120;
            ball.Direction = Direction.SW;
            ball.IsAtStartPosition = false;
            State.HasHitWall = true;
            ball.ChangeDirection();
        }

        [Test]
        public void ShouldHaveDirNWTest(){
            Assert.IsTrue(ball.Direction == Direction.NW,ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNWTest1(){
            Assert.IsFalse(ball.Direction == Direction.E, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNWTest2(){
            Assert.IsFalse(ball.Direction == Direction.NE, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNWTest3(){
            Assert.IsFalse(ball.Direction == Direction.SW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNWTest4(){
            Assert.IsFalse(ball.Direction == Direction.SE, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirNWTest5(){
            Assert.IsFalse(ball.Direction == Direction.W, ball.Direction.ToString());
        }
    }
}