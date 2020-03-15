using NUnit.Framework;
using Pong.Abstracts;
using Pong.Enums;
using Pong.Objects;
using Pong.Players;

namespace ObjectCollisionTests
{
    public class HasBallCorrectAngleAfterWallHitTests
    {
        public Ball ball;

        [SetUp]
        public void Setup(){
            ball = new Ball();
        }

        [Test]
        public void HasAngleOf30Test1()
        {
            ball.SetAngleAfterWallHit(Board.XMargin,Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasAngleOf30Test2()
        {
            ball.SetAngleAfterWallHit(Board.XMargin + 1, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasAngleOf30Test3()
        {
            ball.SetAngleAfterWallHit(27, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasNotAngleOf30Test2()
        {
            ball.SetAngleAfterWallHit(28, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasAngleOf60Test1(){
            ball.SetAngleAfterWallHit(28, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf60Test2()
        {
            ball.SetAngleAfterWallHit(54, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasNotAngleOf60Test1()
        {
            ball.SetAngleAfterWallHit(55, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasNotAngleOf60Test2()
        {
            ball.SetAngleAfterWallHit(27, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf90Test1(){
            ball.SetAngleAfterWallHit(55, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle90);
        }

        [Test]
        public void HasNotAngleOf90Test1(){
            ball.SetAngleAfterWallHit(54, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle90);
        }

        [Test]
        public void HasNotAngleOf90Test2(){
            ball.SetAngleAfterWallHit(56, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle90);
        }

        [Test]
        public void HasAngleOf120Test1(){
            ball.SetAngleAfterWallHit(56, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasAngleOf120Test2(){
            ball.SetAngleAfterWallHit(82, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasNotAngleOf120Test1()
        {
            ball.SetAngleAfterWallHit(85, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasNotAngleOf120Test2()
        {
            ball.SetAngleAfterWallHit(55, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasAngleOf150Test1(){
            ball.SetAngleAfterWallHit(85, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle150);
        }

        [Test]
        public void HasAngleOf150Test2(){
            ball.SetAngleAfterWallHit(Board.Width, Board.YMargin);
            Assert.IsTrue(ball.Angle == Angle.Angle150);
        }

        [Test]
        public void HasNotAngleOf150Test1()
        {
            ball.SetAngleAfterWallHit(82, Board.YMargin);
            Assert.IsFalse(ball.Angle == Angle.Angle150);
        }

    }
}