using NUnit.Framework;
using Pong.Abstracts;
using Pong.Behavior;
using Pong.Objects;
using Pong.Players;

namespace ObjectCollisionTests
{
    public class HasPlayerScoredTests
    {
        [SetUp]
        public void Setup(){
        }

        [Test]
        public void HasPlayer1ScoredTest1(){
            Assert.IsFalse(CheckPosition.HasPlayer1Scored(Board.Width));
        }

        [Test]
        public void HasPlayer1ScoredTest2()
        {
            Assert.IsTrue(CheckPosition.HasPlayer1Scored(Board.Width + 1));
        }

        [Test]
        public void HasPlayer1ScoredTest3()
        {
            Assert.IsFalse(CheckPosition.HasPlayer1Scored(Board.Width - 1));
        }

        [Test]
        public void HasPlayer2ScoredTest1()
        {
            Assert.IsFalse(CheckPosition.HasPlayer2Scored(Board.XMargin));
        }

        [Test]
        public void HasPlayer2ScoredTest2()
        {
            Assert.IsTrue(CheckPosition.HasPlayer2Scored(Board.XMargin - 1));
        }

        [Test]
        public void HasPlayer2ScoredTest3()
        {
            Assert.IsFalse(CheckPosition.HasPlayer2Scored(Board.XMargin + 1));
        }
    }
}