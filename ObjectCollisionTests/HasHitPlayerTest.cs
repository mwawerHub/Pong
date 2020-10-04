using NUnit.Framework;
using Pong.Abstracts;
using Pong.Behavior;
using Pong.Objects;
using Pong.Players;

namespace ObjectCollisionTests
{
    public class HasHitPlayerTests
    {
        private Player1 player1;
        private Player2 player2;
        private Ball ball;

        private const sbyte p1XOffset = 1;
        private const sbyte p2XOffset = -1;

        /*  Player pixel count
         *
         * [] - TopPixel
         * [] - UpperMiddlePixel
         * [] - MiddlePixel
         * [] - LowerMiddlePixel
         * [] - BottomPixel
         */

        private const sbyte TopPixelOffset = 0;
        private const sbyte UpperMiddlePixelOffset = 1;
        private const sbyte MiddlePixelOffset = 2;
        private const sbyte LowerMiddlePixelOffset = 3;
        private const sbyte BottomPixelOffset = 4;

        [SetUp]
        public void Setup() {
            player1 = new Player1();
            player2 = new Player2();
            ball = new Ball();
        }

        private void SetBallPositionForPlayer(sbyte xOffset, sbyte yOffset, ConsolePlayer player) {
            ball.XStartValue = (byte)(player.XStartValue + xOffset);
            ball.YStartValue = (byte)(player.YStartValue + yOffset);
        }

        #region PLAYER1

        [Test]
        public void HasHitTopPixelOfPlayer1() {
            SetBallPositionForPlayer(p1XOffset, TopPixelOffset, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitUpperMiddlePixelOfPlayer1() {
            SetBallPositionForPlayer(p1XOffset, UpperMiddlePixelOffset, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitMiddlePixelOfPlayer1() {
            SetBallPositionForPlayer(p1XOffset, MiddlePixelOffset, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitLowerMiddlePixelOfPlayer1() {
            SetBallPositionForPlayer(p1XOffset, LowerMiddlePixelOffset, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitBottomPixelOfPlayer1() {
            SetBallPositionForPlayer(p1XOffset, BottomPixelOffset, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        #endregion PLAYER1

        #region PLAYER2

        [Test]
        public void HasHitTopPixelOfPlayer2() {
            SetBallPositionForPlayer(p2XOffset, TopPixelOffset, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitUpperMiddlePixelOfPlayer2() {
            SetBallPositionForPlayer(p2XOffset, UpperMiddlePixelOffset, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitMiddlePixelOfPlayer2() {
            SetBallPositionForPlayer(p2XOffset, MiddlePixelOffset, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitLowerMiddlePixelOfPlayer2() {
            SetBallPositionForPlayer(p2XOffset, LowerMiddlePixelOffset, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitBottomPixelOfPlayer2() {
            SetBallPositionForPlayer(p2XOffset, BottomPixelOffset, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        #endregion PLAYER2

        [Test]
        public void ShouldNotHitPlayer1() {
            var hasHit = false;
            for (sbyte j = -1; j < 1; j++) {
                for (sbyte i = 0; i < player1.Height + 2; i++) {
                    SetBallPositionForPlayer(j, i, player1);
                    if (CheckPosition.HasHitPlayer(player1, ball)) {
                        hasHit = true;
                    }
                }
            }
            Assert.IsFalse(hasHit);
        }

        [Test]
        public void ShouldNotHitPlayer2() {
            var hasHit = false;
            for (sbyte j = -1; j < 1; j++) {
                for (sbyte i = 0; i < player2.Height + 2; i++) {
                    SetBallPositionForPlayer(j, i, player2);
                    if (CheckPosition.HasHitPlayer(player2, ball)) {
                        hasHit = true;
                    }
                }
            }
            Assert.IsFalse(hasHit);
        }
    }
}