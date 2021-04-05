using System;

namespace Arcanoid
{
    public class Levels
    {
        private string[,] LevelStruct;
        public Levels (int level)
        {
            LevelBuilder(level);
        }

        public string[,] Level
        {
            get => LevelStruct;
        }

        private void LevelBuilder(int level)
        {
            if (level == 0)
            {
                LevelStruct = new string[5,2];
                for (int i = 0; i < LevelStruct.GetLength(0); i++)
                for (int j = 0; j < LevelStruct.GetLength(1); j++)
                {
                    LevelStruct[i, j] = "*";
                }
            }
        }
    }
}