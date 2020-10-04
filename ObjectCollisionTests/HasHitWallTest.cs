using NUnit.Framework;
using Pong.Abstracts;
using Pong.Behavior;

namespace ObjectCollisionTests
{
    public class HasHitWallTests
    {
        private const sbyte TopWallOffset = 1;
        private const sbyte BottomWallOffset = -1;

        [SetUp]
        public void Setup() {
        }

        [Test]
        public void HasHitWallTopWall() {
            Assert.IsTrue(CheckPosition.HasHitWall(Board.YMargin + TopWallOffset));
        }

        [Test]
        public void HasHitBottomWall() {
            Assert.IsTrue(CheckPosition.HasHitWall(Board.Height + BottomWallOffset));
        }
    }
}