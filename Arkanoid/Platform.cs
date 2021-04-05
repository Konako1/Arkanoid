using Arcanoid.Properties;

namespace Arcanoid
{
    public class Platform
    {
        private const int Width = 20;
        private readonly int Height;

        public Platform (int difficulty)
        {
            if (difficulty == 0) Height = 200; //на каждую сложность своя длинна
            if (difficulty == 1) Height = 150;
        }
    }
}