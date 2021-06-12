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
            comboBlock.Items.Add("20");
            comboBlock.Items.Add("30");
            comboBlock.Items.Add("35");
            comboBlock.Items.Add("40");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void authors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сабирджанов Эдем и Худасов Иван", "Авторы");
        }
        
        private void slojn_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            bool statusMenu = false;
            bool statusLabel = true;
            ClickVis(statusMenu, statusLabel);
        }

        private int checkspeed = 2;
        private int checklevel = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            bool statusMenu = true;
            bool statusLabel = false;
            ClickVis(statusMenu, statusLabel);
            if (comboSpeed.Text == "Медленная" || comboSpeed.Text == "") checkspeed = 1;
            if (comboSpeed.Text == "Средняя") checkspeed = 2;
            if (comboSpeed.Text == "Высокая") checkspeed = 3;
            if (comboBlock.Text == "20" || comboBlock.Text == "") checklevel = 1;
            if (comboBlock.Text == "30") checklevel = 2;
            if (comboBlock.Text == "35") checklevel = 3;
            if (comboBlock.Text == "40") checklevel = 4;
        }
        
        private void ClickVis(bool statusMenu, bool statusLabel)
        {
            newGame.Visible = statusMenu;
            slojn.Visible = statusMenu;
            authors.Visible = statusMenu;
            exit.Visible = statusMenu;
            labelSpeed.Visible = statusLabel;
            labelBlock.Visible = statusLabel;
            comboSpeed.Visible = statusLabel;
            comboBlock.Visible = statusLabel;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            GameModel game = new GameModel(checkspeed,checklevel);
            var gameForm = new Arkanoid(game);
            gameForm.Show();
            Hide();
        }
    }
}
