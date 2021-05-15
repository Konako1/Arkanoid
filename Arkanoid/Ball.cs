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
                if (value == 1) _speed = 1; // пока выбраны условные значения, возможно изменятся в будущем
                if (value == 2) _speed = 2;
                if (value == 3) _speed = 3;
            }
        }

        public int Size => size;

        public Ball(int difficulty)
        {
            Speed = difficulty;
        }
    }
}