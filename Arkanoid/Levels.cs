using System;

namespace rndomNamespace
{
    public class Levels
    {
        private string[,] _levelStruct;
        public Levels (int level)
        {
            LevelBuilder(level);
        }

        public string[,] Level => _levelStruct;

        private void StringBuilder(string[,] levelStruct)
        {
            for (int i = 0; i < levelStruct.GetLength(0); i++)
            for (int j = 0; j < levelStruct.GetLength(1); j++)
            {
                _levelStruct[i, j] = "*";
            }
        }

        private void LevelBuilder(int level)
        {
            if (level == 0)
            {
                _levelStruct = new string[5,2];
                StringBuilder(_levelStruct);
            }

            if (level == 1)
            {
                _levelStruct = new string[8, 3];
                StringBuilder(_levelStruct);
            }
        }
    }
}