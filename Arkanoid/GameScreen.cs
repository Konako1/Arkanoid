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
        public readonly int PlatformHeight;
        public readonly int PlatformWidth;
        public GameModel(int difficulty, int level)
        {
            Level = level;
            
            Ball ball = new Ball(difficulty);
            Platform platform = new Platform(difficulty);
            
            Speed = ball.Speed;
            BallSize = ball.Size;
            
            PlatformHeight = platform.GetHeight;
            PlatformWidth = platform.GetWidth;
        }
    }

    public partial class Arkanoid : Form
    {
        private readonly int _platformWidth;
        private readonly int _windowHeight;
        private readonly int _windowWidth;

        public Arkanoid(GameModel gameModel)
        {
            InitializeComponent();
            
            _windowHeight = 800; // планируется добавить разный размер окон, а мб и нет
            _windowWidth = 800;
            int ballSize = gameModel.BallSize;
            int platformWidth = gameModel.PlatformWidth;
            int platformHeight = gameModel.PlatformHeight;
            
            StartPosition = FormStartPosition.CenterScreen;
            
            Size = new Size(_windowWidth, _windowHeight);
            MinimumSize = new Size(_windowWidth, _windowHeight);
            MaximumSize = new Size(_windowWidth, _windowHeight);

            ball.Image = Properties.Resources.ball;
            ball.Size = new Size(ballSize, ballSize);
            ball.Location = new Point(_windowWidth / 2 - ballSize / 2, 700 - ballSize);
            
            if (platformWidth == 131) platform1.Image = Properties.Resources.platform1;
            platform1.Size = new Size(platformWidth, platformHeight);
            platform1.Location = new Point(_windowWidth / 2 - platformWidth / 2, 700);
            _platformWidth = platformWidth;
            
            GameModel game = gameModel;
            KeyDown += Form1_KeyDown;
        }
        
        private void Form1_KeyDown(object obj, KeyEventArgs e)
        {
            int currentKey = e.KeyValue;
            //int platform = 
            switch (currentKey)
            {
                case 37:
                    if (platform1.Left < 3) return;
                    
                    platform1.Location = new Point(platform1.Location.X - 10, platform1.Location.Y);
                    break;
                case 39:
                    if (platform1.Right > _windowWidth - 19) return;
                    
                    platform1.Location = new Point(platform1.Location.X + 10, platform1.Location.Y);
                    break;
            }
        }
    }
}
