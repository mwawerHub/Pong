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


        [SetUp]
        public void Setup(){ 
            player1 = new Player1();
            player2 = new Player2();
            ball = new Ball();
        }

        private void SetBallPositionForPlayer1(sbyte x, sbyte y){
            ball.XStartValue = (byte)(player1.XStartValue + x);
            ball.YStartValue = (byte)(player1.YStartValue + y);
        }

        private void SetBallPositionForPlayer2(byte x, byte y){
            ball.XStartValue = (byte)(player2.XStartValue + x);
            ball.YStartValue = (byte)(player2.YStartValue + y);
        }

        [Test]
        public void HasHitPlayerTest1(){
            SetBallPositionForPlayer1(0, 0);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1,ball));
        }

        [Test]
        public void HasHitPlayerTest2(){
            SetBallPositionForPlayer1(0, 1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest3(){
            SetBallPositionForPlayer1(0, 2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest4(){
            SetBallPositionForPlayer1(0, 3);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest5(){
            SetBallPositionForPlayer1(0, 4);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest6(){
            SetBallPositionForPlayer1(0, 5);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest7(){
            SetBallPositionForPlayer1(0, -1);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest8(){
            SetBallPositionForPlayer1(1, 0);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayerTest9(){
            SetBallPositionForPlayer1(-1, 0);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player1, ball));
        }

    }
}