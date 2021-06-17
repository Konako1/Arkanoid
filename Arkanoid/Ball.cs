namespace rndomNamespace
{
    public class Ball
    {
        private int _speed;
        const int size = 20;

        public int Speed
        {
            get => _speed;
            private set => _speed = value * 2;
        }

        public int Size => size;

        public Ball(int difficulty)
        {
            Speed = difficulty;
        }
    }
}