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
        public readonly int BallSpeed;
        public readonly int BallSize;
        public readonly int PlatformHeight;
        public readonly int PlatformWidth;
        public readonly string[,] LevelStruct;

        public readonly int Difficulty;
        public readonly int Level;
        public GameModel(int difficulty, int level)
        {
            Difficulty = difficulty;
            Level = level;
            
            Ball ball = new Ball(difficulty);
            Platform platform = new Platform(difficulty);
            Levels levels = new Levels(level);

            BallSpeed = ball.Speed;
            BallSize = ball.Size;
            
            PlatformHeight = platform.GetHeight;
            PlatformWidth = platform.GetWidth;

            LevelStruct = levels.Level;
        }
    }

    public partial class Arkanoid : Form
    {
        private bool isKeyLeftPressed = false;
        private bool isKeyRightPressed = false;

        public readonly int Level;
        public readonly int Difficulty;

        private readonly int _platformWidth;
        private readonly int _platformPosition;

        private readonly int _windowHeight;
        private readonly int _windowWidth;

        private readonly int _ballSize;

        private double _speedX, _speedY; // Скорость для шарика, путем ускорения отталкивания для sx,xy (по умолчанию 1.5, потом мб увеличим в зависимости от сложности)

        private double _coordinateX, _coordinateY; //

        private Timer timer1 = new Timer();

        private Timer timer2 = new Timer();

        public Arkanoid(GameModel gameModel)
        {
            InitializeComponent();

            Level = gameModel.Level;
            Difficulty = gameModel.Difficulty;

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arkanoid";
            
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

            PictureBox tile = new PictureBox();

            tile.Image = Properties.Resources.tile;
            tile.Size = new Size(50, 20);
            tile.Location = new Point(100, 100);

            string[,] levelStruct = gameModel.LevelStruct;
            LevelBuilder(levelStruct);
            
            gameOverScreen.Image = Properties.Resources.bg;
            gameOverScreen.Location = new Point(0, 0);
            gameOverScreen.Size = new Size(1920, 1080);
            gameOverScreen.Visible = false;
            
            

            GameModel game = gameModel;

            timer1.Interval = 10;
            timer1.Tick += update;
            timer1.Start();

            timer2.Interval = 10;
            timer2.Tick += new EventHandler(Elapsed);
            timer2.Start();

            KeyDown += Arkanoid_KeyDown;
            KeyUp += Arkanoid_KeyUp;
            
        }

        private void Elapsed(object sender, EventArgs e)
        {
            _coordinateX += _speedX; // Движение по х
            _coordinateY += _speedY; // Движение по y
            ball.Left = (int) _coordinateX; // 
            ball.Top = (int) _coordinateY; // 
            if (ball.Top <= 0)
            {
                _speedY = -_speedY;
                ball.Top += 5;
            }

            if (platform1.Left - ball.Width < ball.Left && platform1.Left + platform1.Width > ball.Left &&
                ball.Top + ball.Height >= _platformPosition)
            {
                _speedY = -_speedY;
                ball.Top -= 5;
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
                gameOverScreen.Visible = true;

                Button mainMenu = new Button();
                Button retry = new Button();

                mainMenu.Size = new Size(100, 60);
                retry.Size = new Size(100, 60);

                mainMenu.Location = new Point(_windowWidth / 2 - 50, (_windowHeight * 3) / 4 - 30);
                retry.Location = new Point(_windowWidth / 2 - 50, _windowHeight / 2 - 30);

                mainMenu.Text = "Exit To Menu";
                retry.Text = "Retry";

                Controls.Add(mainMenu);
                Controls.Add(retry);
                
                mainMenu.BringToFront();
                retry.BringToFront();

                retry.Click += new EventHandler(retry_click);
                mainMenu.Click += new EventHandler(mainMenu_click);

                timer1.Stop();
                timer2.Stop(); // в планах запилить менюшку с Начать заново / Главное меню / Ваш рекорд
            }
        }

        private void retry_click(object sender, EventArgs e)
        {
            GameModel game = new GameModel(Difficulty, Level);
            var gameForm = new Arkanoid(game);
            Close();
            gameForm.Show();
        }

        private void mainMenu_click(object sender, EventArgs e)
        {
            Close();
            var startScreen = new Form2();
            Close();
            startScreen.Show();
        }

        private void Arkanoid_KeyUp(object sender, KeyEventArgs e)
        {
            isKeyLeftPressed = false;
            isKeyRightPressed = false;
        }

        private void update(object obj, EventArgs e)
        {
            if (isKeyLeftPressed)
            {
                if (platform1.Left < 3) return;
                platform1.Location = new Point(platform1.Location.X - 10, platform1.Location.Y);
            }

            if (isKeyRightPressed)
            {
                if (platform1.Right > _windowWidth - 19) return;
                platform1.Location = new Point(platform1.Location.X + 10, platform1.Location.Y);
            }
        }

        private void Arkanoid_KeyDown(object obj, KeyEventArgs e)
        {
            int currentKey = e.KeyValue;
            switch (currentKey)
            {
                case 37:
                    if (platform1.Left < 3) return;
                    isKeyLeftPressed = true;
                    break;
                case 39:
                    if (platform1.Right > _windowWidth - 19) return;
                    isKeyRightPressed = true;
                    break;
            }
        }

        private void timer2_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        private void LevelBuilder(string[,] levelStruct)
        {
            Tile tileBlock = new Tile();
            int height = tileBlock.GetHeight;
            int width = tileBlock.GetWidth;

            for (int i = 0; i < levelStruct.GetLength(0); i++)
            {
                for (int j = 0; j < levelStruct.GetLength(1); j++)
                {
                    if (levelStruct[i, j] == "*")
                    {
                        PictureBox tile = new PictureBox();

                        tile.Image = Properties.Resources.tile;
                        tile.Size = new Size(width, height);
                        tile.Location = new Point(100 + i * 55, 100 + j * 25);

                        Controls.Add(tile);
                    }
                }
            }
        }
    }
}