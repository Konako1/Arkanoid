using rndomNamespace.Properties;

namespace rndomNamespace
{
    public class Platform
    {
        private const int Width = 20;
        private readonly int Height;
        private static int Size;

        public Platform (int difficulty)
        {
            Size = 1;
            if (difficulty == 0) Height = 200; //на каждую сложность своя длинна
            if (difficulty == 1) Height = 150;
        }

        public int GetSize => Size;
    }
}