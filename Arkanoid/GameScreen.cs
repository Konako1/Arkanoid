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
using rndomNamespace.Properties;
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
        private bool isKeyLeftPressed;
        private bool isKeyRightPressed;

        public readonly int Level;
        public readonly int Difficulty;

        private readonly int _platformWidth;
        private readonly int _platformPosition;

        private readonly int _windowHeight;
        private readonly int _windowWidth;

        private readonly int _ballSize;
        private BufferedGraphics ball;

        private int _speedX, _speedY; // Скорость для шарика, путем ускорения отталкивания для sx,xy (по умолчанию 1.5, потом мб увеличим в зависимости от сложности)

        private int _coordinateX;
        private int _coordinateY; //

        private Timer timer1 = new Timer();

        private Timer timer2 = new Timer();

        private PictureBox[,] _level;
        private int[] _levelSize;

        private int _score = 0;

        public Arkanoid(GameModel gameModel)
        {
            InitializeComponent();

            winScreen.Visible = false;
            winScreen.Size = new Size(800, 800);
            winScreen.Location = new Point(0, 0);
            scoreLable.Visible = false;

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

            _coordinateX = _windowWidth / 2 - _ballSize / 2;
            _coordinateY = _windowHeight - 100 - gameModel.BallSpeed - _ballSize;

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
            FormClosing += Form_Closing;

            timer1.Interval = 10;
            timer1.Tick += update;
            timer1.Start();

            timer2.Interval = 10;
            timer2.Tick += Elapsed;
            timer2.Start();
            
            InitializeGraphics();

            KeyDown += Arkanoid_KeyDown;
            KeyUp += Arkanoid_KeyUp;

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            ball.Dispose();
            Dispose();
        }

        private void InitializeGraphics()
        {
            BufferedGraphicsContext context = new BufferedGraphicsContext();
            ball = context.Allocate(CreateGraphics(), ClientRectangle);
            context.MaximumBuffer = ClientRectangle.Size;
        }

        private void Elapsed(object sender, EventArgs e)
        {
            _coordinateX += _speedX; // Движение по х
            _coordinateY += _speedY; // Движение по y 
            if (_coordinateX <= 0 || _coordinateX + _ballSize >= _windowWidth - 19)
            {
                _speedX = -_speedX;
            }

            if (platform1.Location.X <= _coordinateX + _ballSize / 2 && platform1.Location.X + _platformWidth >= _coordinateX + _ballSize / 2 &&
                platform1.Location.Y == _coordinateY + _ballSize)
            {
                _speedY = -_speedY;
            }

            if (_coordinateY <= 0)
            {
                _speedY = -_speedY;
            }

            if (ball.Graphics != null)
            {
                ball.Graphics.Clear(BackColor);
                ball.Graphics.DrawEllipse(new Pen(Brushes.Blue), _coordinateX, _coordinateY, _ballSize, _ballSize);
                ball.Render(); //выводим то, что отрисовано в буфере
            }

            var isLevelComplete = true;
            
            for (int i = 0; i < _level.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < _level.GetUpperBound(1) + 1; j++)
                {
                    if (_level[i, j].Visible)
                        isLevelComplete = false;
                    
                    if (!_level[i, j].Visible) continue;
                    
                    if (_coordinateX + _ballSize / 2 >= 120 + i * (100 + 5) &&
                            _coordinateX + _ballSize / 2 <= 220 + i * (100 + 5)) // ширина плитки
                    {
                        if (_coordinateY <= 130 + j * (30 + 5) &&
                            _coordinateY >= 100 + j * (30 + 5)) // отскок верхней стороной шарика от нижней границы
                        {
                            _level[i, j].Visible = false;
                            _speedY = -_speedY;
                            _score += 50;
                        }
                        else if (_coordinateY + _ballSize >=
                                 100 + j * (30 + 5) && // отскок нижней стороной шарика от верхней границы
                                 _coordinateY + _ballSize <= 130 + j * (30 + 5))
                        {
                            _level[i, j].Visible = false;
                            _speedY = -_speedY;
                            _score += 50;
                        }
                    }
                    if (_coordinateY + _ballSize / 2 >= 100 + j * (30 + 5) &&
                             _coordinateY + _ballSize <= 130 + j * (30 + 5))
                    {
                        if (_coordinateX <= 220 + i * (100 + 5) && _coordinateX >= 120 + i * (100 + 5))
                        {
                            _level[i, j].Visible = false;
                            _speedX = -_speedX;
                            _score += 50;
                        }
                        else if (_coordinateX + _ballSize >= 120 + i * (100 + 5) &&
                                 _coordinateX + _ballSize <= 220 + i * (100 + 5))
                        {
                            _level[i, j].Visible = false;
                            _speedX = -_speedX;
                            _score += 50;
                        }
                        
                    }
                }
            }
            
            if (_coordinateY + _ballSize >= _windowHeight - _ballSize)
            {
                BackColor = Color.Black;
                platform1.Visible = false;

                PictureBox mainMenu = new PictureBox();
                PictureBox retry = new PictureBox();
                PictureBox youDead = new PictureBox();
                
                youDead.Size = new Size(884, 224);
                youDead.Location = new Point(_windowWidth / 2 - youDead.Size.Width / 2, _windowHeight / 8);
                youDead.Image = Resources.you_died;
                Controls.Add(youDead);
                youDead.BringToFront();
                
                InitializeEndButtons(mainMenu, retry);
                
                retry.Click += retry_click;
                mainMenu.Click += mainMenu_click;

                 // в планах запилить менюшку с Начать заново / Главное меню / Ваш рекорд
            }

            if (isLevelComplete)
            {
                PictureBox mainMenu = new PictureBox();
                PictureBox retry = new PictureBox();
                
                winScreen.Visible = true;

                scoreLable.Visible = true;
                scoreLable.Text = "Your score: " + _score * Difficulty;
                scoreLable.Size = new Size(200, 50);
                scoreLable.Location = new Point(_windowWidth / 2 - scoreLable.Size.Width / 2, _windowHeight / 8);
                scoreLable.Show();
                scoreLable.BringToFront();
                
                InitializeEndButtons(mainMenu, retry);
                
                retry.Click += retry_click;
                mainMenu.Click += mainMenu_click;
            }
        }

        private void InitializeEndButtons(PictureBox mainMenu, PictureBox retry)
        {
            mainMenu.Size = new Size(148, 55);
            retry.Size = new Size(182, 56);
            
            mainMenu.Location = new Point(_windowWidth / 2 - mainMenu.Size.Width / 2, (_windowHeight * 3) / 4 - 30);
            retry.Location = new Point(_windowWidth / 2 - retry.Size.Width / 2, _windowHeight / 2 - 30);
            
            mainMenu.Image = Resources.game_exit;
            retry.Image = Resources.game_restart;
            
            Controls.Add(mainMenu);
            Controls.Add(retry);
            
            mainMenu.BringToFront();
            retry.BringToFront();
            
            timer1.Stop();
            timer2.Stop();
        }

        private void retry_click(object sender, EventArgs e)
        {
            GameModel game = new GameModel(Difficulty, Level);
            var gameForm = new Arkanoid(game);
            gameForm.Show();
            Close();
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

        private void LevelBuilder(string[,] levelStruct)
        {
            Tile tileBlock = new Tile(levelStruct.Length);
            int height = tileBlock.GetHeight;
            int width = tileBlock.GetWidth;
            _level = new PictureBox[levelStruct.GetUpperBound(0) + 1, levelStruct.GetUpperBound(1) + 1];
            _levelSize = new int[] {0, 0};

            for (int i = 0; i < levelStruct.GetLength(0); i++)
            {
                for (int j = 0; j < levelStruct.GetLength(1); j++)
                {
                    if (levelStruct[i, j] == "*")
                    {
                        PictureBox tile = new PictureBox();
                        tile.Image = Properties.Resources.tile;
                        tile.Size = new Size(width, height);
                        tile.Location = new Point(120 + i * (width + 5), 100 + j * (height + 5));

                        Controls.Add(tile);
                        _level[i, j] = tile;
                    }
                    else
                    {
                        _level[i, j] = null;
                    }

                    _levelSize[0] += 105;
                }

                _levelSize[1] += 55;
            }

            _levelSize[0] -= 5;
            _levelSize[1] -= 5;
        }

        private void DrawTiles(Graphics g)
        {
            /*for (int i = 0; i < UPPER; i++)
            {
                for (int j = 0; j < UPPER; j++)
                {
                    
                }
            }*/
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawTiles(e.Graphics);
        }
    }
}