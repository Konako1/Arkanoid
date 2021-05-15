using rndomNamespace.Properties;

namespace rndomNamespace
{
    public class Platform
    {
        private const int Height = 40;
        private static int Width;

        public Platform (int difficulty)
        {
            if (difficulty == 1) Width = 131; //на каждую сложность своя длинна
            if (difficulty == 2) Width = 131;
        }

        public int GetHeight => Height;
        public int GetWidth => Width;
    }
}