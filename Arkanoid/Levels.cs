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
            if (level == 1)
            {
                _levelStruct = new string[5, 4];
                StringBuilder(_levelStruct);
            }

            if (level == 2)
            {
                _levelStruct = new string[5, 6];
                StringBuilder(_levelStruct);
            }
            
            if (level == 3)
            {
                _levelStruct = new string[5, 7];
                StringBuilder(_levelStruct);
            }
            
            if (level == 4)
            {
                _levelStruct = new string[5, 8];
                StringBuilder(_levelStruct);
            }
        }
    }
}