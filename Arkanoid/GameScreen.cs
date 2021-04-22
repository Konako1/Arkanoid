using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rndomNamespace
{
    public class GameModel
    {
        public readonly int Level;
        public readonly int Speed;
        public readonly int BallSize;
        public readonly int PlatformSize;
        public GameModel(int difficulty, int level)
        {
            Level = level;
            
            Ball ball = new Ball(difficulty);
            Platform platform = new Platform(difficulty);
            
            Speed = ball.Speed;
            BallSize = ball.Size;
            PlatformSize = platform.GetSize; 
        }
    }

    public partial class Arkanoid : Form
    {
        private void Form1_KeyDown(object obj, KeyEventArgs e)
        {
            int currentKey = e.KeyValue;
            //int platform = 
            switch (currentKey)
            {
                case 37:
                    if (platform1.Left < 0) return;
                    
                    platform1.Location = new Point(platform1.Location.X - 5, platform1.Location.Y);
                    break;
                case 39:
                    if (platform1.Right > 700) return;
                    
                    platform1.Location = new Point(platform1.Location.X + 5, platform1.Location.Y);
                    break;
            }
        }
        
        public Arkanoid(GameModel gameModel)
        {
            InitializeComponent();
            if (gameModel.PlatformSize == 1) platform1.Image = Properties.Resources.platform1;
            GameModel game = gameModel;
            KeyDown += Form1_KeyDown;
        }
    }
}
