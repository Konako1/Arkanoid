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
            this.exit_pictureBox = new System.Windows.Forms.PictureBox();
            this.autors_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autors_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_pictureBox
            // 
            this.exit_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_pictureBox.Image = global::rndomNamespace.Properties.Resources.exit;
            this.exit_pictureBox.Location = new System.Drawing.Point(143, 332);
            this.exit_pictureBox.Name = "exit_pictureBox";
            this.exit_pictureBox.Size = new System.Drawing.Size(118, 50);
            this.exit_pictureBox.TabIndex = 3;
            this.exit_pictureBox.TabStop = false;
            this.exit_pictureBox.Click += new System.EventHandler(this.Exit_pictureBox_Click);
            // 
            // autors_pictureBox
            // 
            this.autors_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autors_pictureBox.Image = global::rndomNamespace.Properties.Resources.autors;
            this.autors_pictureBox.Location = new System.Drawing.Point(130, 240);
            this.autors_pictureBox.Name = "autors_pictureBox";
            this.autors_pictureBox.Size = new System.Drawing.Size(162, 50);
            this.autors_pictureBox.TabIndex = 2;
            this.autors_pictureBox.TabStop = false;
            this.autors_pictureBox.Click += new System.EventHandler(this.Autors_pictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::rndomNamespace.Properties.Resources.newgame;
            this.pictureBox2.Location = new System.Drawing.Point(106, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rndomNamespace.Properties.Resources.waw;
            this.pictureBox1.Location = new System.Drawing.Point(50, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 420);
            this.Controls.Add(this.exit_pictureBox);
            this.Controls.Add(this.autors_pictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid";
            ((System.ComponentModel.ISupportInitialize)(this.exit_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autors_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox autors_pictureBox;
        private System.Windows.Forms.PictureBox exit_pictureBox;
    }
}