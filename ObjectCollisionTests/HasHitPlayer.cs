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

        private void SetBallPositionForPlayer(sbyte x, sbyte y, ConsolePlayer player){
            ball.XStartValue = (byte)(player.XStartValue + x);
            ball.YStartValue = (byte)(player.YStartValue + y);
        }

        #region PLAYER1

        [Test]
        public void HasHitPlayer1Test1(){
            SetBallPositionForPlayer(0, 0, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1,ball));
        }

        [Test]
        public void HasHitPlayer1Test2(){
            SetBallPositionForPlayer(0, 1, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test3(){
            SetBallPositionForPlayer(0, 2, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test4(){
            SetBallPositionForPlayer(0, 3, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test5(){
            SetBallPositionForPlayer(0, 4, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test6(){
            SetBallPositionForPlayer(0, 5, player1);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test7(){
            SetBallPositionForPlayer(0, -1, player1);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test8(){
            SetBallPositionForPlayer(1, 0, player1);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player1, ball));
        }

        [Test]
        public void HasHitPlayer1Test9(){
            SetBallPositionForPlayer(-1, 0, player1);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player1, ball));
        }

        #endregion

        #region PLAYER2

        [Test]
        public void HasHitPlayer2Test1()
        {
            SetBallPositionForPlayer(0, 0, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test2()
        {
            SetBallPositionForPlayer(0, 1, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test3()
        {
            SetBallPositionForPlayer(0, 2, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test4()
        {
            SetBallPositionForPlayer(0, 3, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test5()
        {
            SetBallPositionForPlayer(0, 4, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test6()
        {
            SetBallPositionForPlayer(0, 5, player2);
            Assert.IsTrue(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test7()
        {
            SetBallPositionForPlayer(0, -1, player2);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test8()
        {
            SetBallPositionForPlayer(1, 0, player2);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player2, ball));
        }

        [Test]
        public void HasHitPlayer2Test9()
        {
            SetBallPositionForPlayer(-1, 0, player2);
            Assert.IsFalse(CheckPosition.HasHitPlayer(player2, ball));
        }

        #endregion

    }
}