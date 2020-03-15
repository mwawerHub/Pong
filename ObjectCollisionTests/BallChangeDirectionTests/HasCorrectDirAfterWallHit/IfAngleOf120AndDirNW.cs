using NUnit.Framework;
using Pong.Enums;
using Pong.Globals;
using Pong.Objects;

namespace ObjectCollisionTests
{
    public class IfAngleOf120AndDirNW
    {
        public Ball ball;

        [SetUp]
        public void Setup(){
            ball = new Ball();
            ball.Angle = Angle.Angle120;
            ball.Direction = Direction.NW;
            ball.IsAtStartPosition = false;
            State.HasHitWall = true;
            ball.ChangeDirection();
        }

        [Test]
        public void ShouldHaveDirSWTest(){
            Assert.IsTrue(ball.Direction == Direction.SW,ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSWTest1(){
            Assert.IsFalse(ball.Direction == Direction.E, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSWTest2(){
            Assert.IsFalse(ball.Direction == Direction.NE, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSWTest3(){
            Assert.IsFalse(ball.Direction == Direction.NW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSWTest4(){
            Assert.IsFalse(ball.Direction == Direction.NW, ball.Direction.ToString());
        }

        [Test]
        public void ShouldNotHaveDirSWTest5(){
            Assert.IsFalse(ball.Direction == Direction.W, ball.Direction.ToString());
        }
    }
}