using System;

namespace rndomNamespace
{
    public class Tile
    {
        private const int Width = 50;
        private const int Height = 20;

        private int Lenght;

        private int[] Tiles;
        

        public Tile(int tileCount)
        {
            Lenght = tileCount;
            Tiles = new int[tileCount];
        }

        public void Add(int tile)
        {
            
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > Lenght)
                    throw new IndexOutOfRangeException();
                return Tiles[index];
            }
            set
            {
                if (index < 0 || index > Lenght)
                    throw new IndexOutOfRangeException();
                Tiles[index] = value;
            }
        }

        public int GetWidth => Width;

        public int GetHeight => Height;
    }
}