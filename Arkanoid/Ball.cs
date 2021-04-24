namespace rndomNamespace
{
    public class Ball
    {
        private int _speed;
        const int size = 40;

        public int Speed
        {
            get => _speed;
            private set
            {
                if (value == 0) _speed = 2; // пока выбраны условные значения, возможно изменятся в будущем
                if (value == 1) _speed = 3;
                if (value == 2) _speed = 4;
            }
        }

        public int Size => size;

        public Ball(int difficulty)
        {
            Speed = difficulty;
        }
    }
}