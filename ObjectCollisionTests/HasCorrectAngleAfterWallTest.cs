using NUnit.Framework;
using Pong.Abstracts;
using Pong.Enums;
using Pong.Objects;
using Pong.Players;
using System;

namespace ObjectCollisionTests
{
    public class HasBallCorrectAngleAfterWallHitTests
    {
        public Ball ball;

        [SetUp]
        public void Setup() {
            ball = new Ball();
        }

        [Test]
        public void HasAngleOf30Test1() {
            ball.Angle = Angle.Angle60;
            ball.SetAngleAfterWallHit(Board.XMargin, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasAngleOf30Test2() {
            ball.Angle = Angle.Angle60;
            ball.SetAngleAfterWallHit((byte)Math.Floor((Board.Width + Board.XMargin) * 0.25), Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasAngleOf60Test1() {
            ball.SetAngleAfterWallHit((byte)((Board.Width + Board.XMargin) * 0.25) + 1, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf60Test2() {
            ball.SetAngleAfterWallHit((byte)((Board.Width + Board.XMargin) * 0.5) - 1, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf60Test3() {
            ball.Angle = Angle.Angle30;
            ball.SetAngleAfterWallHit(Board.XMargin, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf60Test4() {
            ball.Angle = Angle.Angle30;
            ball.SetAngleAfterWallHit((byte)Math.Floor((Board.Width + Board.XMargin) * 0.25), Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf90() {
            ball.SetAngleAfterWallHit((byte)((Board.Width + Board.XMargin) * 0.5), Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle90);
        }

        [Test]
        public void HasAngleOf120Test1() {
            ball.SetAngleAfterWallHit((byte)((Board.Width + Board.XMargin) * 0.5) + 1, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasAngleOf120Test2() {
            ball.SetAngleAfterWallHit((byte)Math.Floor((Board.Width + Board.XMargin) * 0.75), Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasAngleOf150Test1() {
            ball.SetAngleAfterWallHit((byte)((Board.Width + Board.XMargin) * 0.75) + 1, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle150);
        }

        [Test]
        public void HasAngleOf150Test2() {
            ball.SetAngleAfterWallHit(Board.Width, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle150);
        }
    }
}