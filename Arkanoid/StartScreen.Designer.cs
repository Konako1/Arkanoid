using System.Drawing;

namespace rndomNamespace
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.authors = new System.Windows.Forms.PictureBox();
            this.newGame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.authors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.newGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // authors
            // 
            this.authors.Image = global::rndomNamespace.Properties.Resources.authors;
            this.authors.Location = new System.Drawing.Point(326, 183);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(138, 40);
            this.authors.TabIndex = 0;
            this.authors.TabStop = false;
            this.authors.Click += new System.EventHandler(this.authors_Click);
            // 
            // newGame
            // 
            this.newGame.Image = global::rndomNamespace.Properties.Resources.newgame;
            this.newGame.Location = new System.Drawing.Point(301, 123);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(182, 40);
            this.newGame.TabIndex = 1;
            this.newGame.TabStop = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rndomNamespace.Properties.Resources.waw;
            this.pictureBox1.Location = new System.Drawing.Point(241, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.Image = global::rndomNamespace.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(346, 243);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(105, 33);
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-83, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 253);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(611, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 253);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 458);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.authors);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize) (this.authors)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.newGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox authors;

        private System.Windows.Forms.PictureBox exit;

        private System.Windows.Forms.PictureBox newGame;

        private System.Windows.Forms.PictureBox pictureBox1;


        #endregion
    }
}