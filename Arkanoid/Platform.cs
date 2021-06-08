using rndomNamespace.Properties;

namespace rndomNamespace
{
    public class Platform
    {
        private const int Height = 40;
        private static int Width;

        public Platform (int difficulty)
        {
            Width = 131; //на каждую сложность своя длинна
        }

        public int GetHeight => Height;
        public int GetWidth => Width;
    }
}