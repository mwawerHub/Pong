using NUnit.Framework;
using Pong.Enums;
using Pong.Objects;
using Pong.Players;

namespace ObjectCollisionTests
{
    public class HasBallCorrectAngleAfterPlayerHitTests
    {
        public Ball ball;
        public Player1 player1;
        public Player2 player2;

        [SetUp]
        public void Setup(){
            ball = new Ball();
            player1 = new Player1();
            player2 = new Player2();
        }

        [Test]
        public void HasAngleOf30()
        {
            ball.YStartValue = player1.YStartValue;
            ball.SetAngleAfterPlayerHit(player1.YStartValue);
            Assert.IsTrue(ball.Angle == Angle.Angle30);
        }

        [Test]
        public void HasAngleOf60(){
            ball.YStartValue = (byte)(player1.YStartValue + 1);
            ball.SetAngleAfterPlayerHit(player1.YStartValue);
            Assert.IsTrue(ball.Angle == Angle.Angle60);
        }

        [Test]
        public void HasAngleOf90(){
            ball.YStartValue = (byte)(player1.YStartValue + 2);
            ball.SetAngleAfterPlayerHit(player1.YStartValue);
            Assert.IsTrue(ball.Angle == Angle.Angle90);
        }

        [Test]
        public void HasAngleOf120(){
            ball.YStartValue = (byte)(player1.YStartValue + 3);
            ball.SetAngleAfterPlayerHit(player1.YStartValue);
            Assert.IsTrue(ball.Angle == Angle.Angle120);
        }

        [Test]
        public void HasAngleOf150(){
            ball.YStartValue = (byte)(player1.YStartValue + 4);
            ball.SetAngleAfterPlayerHit(player1.YStartValue);
            Assert.IsTrue(ball.Angle == Angle.Angle150);
        }
    }
}