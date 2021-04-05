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

namespace Arcanoid
{
    public class GameModel
    {
        public readonly int Level;
        public readonly int Speed;
        public readonly int BallSize;
        public GameModel(int difficulty, int level)
        {
            Level = level;
            
            Ball ball = new Ball(difficulty);
            
            Speed = ball.Speed;
            BallSize = ball.Size;
            
            
        }
    }
    
    public partial class Arkanoid : Form
    {
        public Arkanoid(GameModel gameModel)
        {
            GameModel game = gameModel;
            var centerX = ClientSize.Width;
            var centerY = ClientSize.Height;
            int ballSize = game.BallSize;
            
            Paint += (sender, args) =>
            {
                args.Graphics.TranslateTransform(centerX, centerY);
                args.Graphics.FillEllipse(Brushes.Gold, ballSize, ballSize, ballSize, ballSize);
            };
        }
    }
}
