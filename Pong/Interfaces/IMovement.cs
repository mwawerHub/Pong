namespace Pong.Interfaces
{
    internal interface IMovement
    {
        void MoveLeft(byte x);

        void MoveRight(byte x);

        void MoveUp(byte y);

        void MoveDown(byte y);
    }
}