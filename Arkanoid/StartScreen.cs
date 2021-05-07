using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace rndomNamespace
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "Arkanoid";
            Size = new Size(800, 400);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void authors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сабирджанов Эдем и Худасов Иван", "Авторы");
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            GameModel game = new GameModel(1, 1);
            var gameForm = new Arkanoid(game);
            gameForm.Show();
            Hide();
        }
    }
}
