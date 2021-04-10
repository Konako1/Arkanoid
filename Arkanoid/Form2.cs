﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rndomNamespace
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            GameModel game = new GameModel(1, 3);
            var Form = new Arkanoid(game);
            Form.Show();
        }

        private void Exit_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autors_pictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сабирджанов Эдем и Худасов Иван", "Авторы");
        }
    }
}