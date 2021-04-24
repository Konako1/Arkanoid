using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace rndomNamespace
{
    public class GameModel
    {
        public readonly int Level;
        public readonly int BallSpeed;
        public readonly int BallSize;
        public readonly int PlatformHeight;
        public readonly int PlatformWidth;
        public GameModel(int difficulty, int level)
        {
            Level = level;
            
            Ball ball = new Ball(difficulty);
            Platform platform = new Platform(difficulty);
            
            BallSpeed = ball.Speed;
            BallSize = ball.Size;
            
            PlatformHeight = platform.GetHeight;
            PlatformWidth = platform.GetWidth;
        }
    }

    public partial class Arkanoid : Form
    {
        private readonly int _platformWidth;
        private readonly int _platformPosition;
        
        private readonly int _windowHeight;
        private readonly int _windowWidth;
        
        private readonly int _ballSize;

        private double _speedX, _speedY; // Скорость для шарика, путем ускорения отталкивания для sx,xy (по умолчанию 1.5, потом мб увеличим в зависимости от сложности)
        private double _coordinateX , _coordinateY; //

        private Timer _movementTimer = new Timer {Interval = 100};

        public Arkanoid(GameModel gameModel)
        {
            InitializeComponent();
            
            StartPosition = FormStartPosition.CenterScreen;
            
            _windowHeight = 800; // планируется добавить разный размер окон, а мб и нет
            _windowWidth = 800;
            Size = new Size(_windowWidth, _windowHeight);
            MinimumSize = new Size(_windowWidth, _windowHeight);
            MaximumSize = new Size(_windowWidth, _windowHeight);
            
            _platformPosition = _windowHeight - 100;
            int platformWidth = gameModel.PlatformWidth;
            int platformHeight = gameModel.PlatformHeight;
            if (platformWidth == 131) platform1.Image = Properties.Resources.platform1;
            platform1.Size = new Size(platformWidth, platformHeight);
            platform1.Location = new Point(_windowWidth / 2 - platformWidth / 2, _platformPosition);
            _platformWidth = platformWidth;
            
            _ballSize = gameModel.BallSize;
            _speedX = gameModel.BallSpeed; 
            _speedY = gameModel.BallSpeed;
            ball.Image = Properties.Resources.ball;
            ball.Size = new Size(_ballSize, _ballSize);
            ball.Location = new Point(_windowWidth / 2 - _ballSize / 2, _platformPosition - _ballSize - 2);

            _coordinateX = ball.Left;
            _coordinateY = ball.Top;
            
            GameModel game = gameModel;
            
            KeyDown += Form1_KeyDown;
            _movementTimer.Tick += _movementTimer_Tick;
        }

        private void _movementTimer_Tick(object obj, EventArgs e)
        {
            
        }

        private void DoMovement()
        {
            
        }
        
        private void Form1_KeyDown(object obj, KeyEventArgs e)
        {
            //if (e.IsRepeat)
            int currentKey = e.KeyValue;
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

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _coordinateX += _speedX; // Движение по х
            _coordinateY += _speedY; // Движение по y
            ball.Left = (int)_coordinateX; // 
            ball.Top = (int)_coordinateY; // 
            if (ball.Top <=0)
            {
                _speedY = -_speedY;
                ball.Top += 5;
            }
            if (platform1.Left - ball.Width < ball.Left && platform1.Left + platform1.Width > ball.Left && ball.Top + ball.Height >= _platformPosition)
            {
                _speedY = -_speedY;
                ball.Top-= 5;
            }
            if (ball.Right > _windowWidth - 19) // Проверка, правый бок
            {
                _speedX = -_speedX; // Отталкивание в противоположную сторону
            }
            if (ball.Left <= 0)
            {
                _speedX = -_speedX;
            }

            if (ball.Bottom > _windowHeight - _ballSize)
            {
                Close(); // в планах запилить менюшку с Начать заново / Главное меню / Ваш рекорд
            }
        }
    }
}
