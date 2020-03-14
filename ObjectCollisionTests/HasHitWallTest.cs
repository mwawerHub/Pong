using NUnit.Framework;
using Pong.Abstracts;
using Pong.Behavior;

namespace ObjectCollisionTests
{
    public class HasHitWallTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HasHitWallTest1(){
            Assert.IsFalse(CheckPosition.HasHitWall(Board.YMargin - 1));
        }

        [Test]
        public void HasHitWallTest2(){
            Assert.IsFalse(CheckPosition.HasHitWall(Board.YMargin + 1));
        }

        [Test]
        public void HasHitWallTest3()
        {
            Assert.IsFalse(CheckPosition.HasHitWall(Board.Height - 1));
        }

        [Test]
        public void HasHitWallTest4()
        {
            Assert.IsFalse(CheckPosition.HasHitWall(Board.Height + 1));
        }

        [Test]
        public void HasHitWallTest5(){
            Assert.IsFalse(!CheckPosition.HasHitWall(Board.YMargin));
        }

        [Test]
        public void HasHitWallTest6(){
            Assert.IsFalse(!CheckPosition.HasHitWall(Board.Height));
        }
    }
}