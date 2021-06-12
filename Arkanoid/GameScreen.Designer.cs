namespace rndomNamespace
{
  partial class Arkanoid
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
      this.platform1 = new System.Windows.Forms.PictureBox();
      this.gameOverScreen = new System.Windows.Forms.PictureBox();
      this.winScreen = new System.Windows.Forms.PictureBox();
      this.scoreLable = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.gameOverScreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.winScreen)).BeginInit();
      this.SuspendLayout();
      // 
      // platform1
      // 
      this.platform1.Location = new System.Drawing.Point(0, 0);
      this.platform1.Name = "platform1";
      this.platform1.Size = new System.Drawing.Size(0, 0);
      this.platform1.TabIndex = 0;
      this.platform1.TabStop = false;
      // 
      // gameOverScreen
      // 
      this.gameOverScreen.Location = new System.Drawing.Point(109, 149);
      this.gameOverScreen.Name = "gameOverScreen";
      this.gameOverScreen.Size = new System.Drawing.Size(100, 50);
      this.gameOverScreen.TabIndex = 2;
      this.gameOverScreen.TabStop = false;
      // 
      // winScreen
      // 
      this.winScreen.Location = new System.Drawing.Point(0, 0);
      this.winScreen.Name = "winScreen";
      this.winScreen.Size = new System.Drawing.Size(100, 50);
      this.winScreen.TabIndex = 5;
      this.winScreen.TabStop = false;
      // 
      // scoreLable
      // 
      this.scoreLable.BackColor = System.Drawing.SystemColors.Menu;
      this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.scoreLable.Location = new System.Drawing.Point(358, 64);
      this.scoreLable.Name = "scoreLable";
      this.scoreLable.Size = new System.Drawing.Size(100, 23);
      this.scoreLable.TabIndex = 4;
      this.scoreLable.Text = "label1";
      // 
      // Arkanoid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 761);
      this.Controls.Add(this.scoreLable);
      this.Controls.Add(this.winScreen);
      this.Controls.Add(this.gameOverScreen);
      this.Controls.Add(this.platform1);
      this.DoubleBuffered = true;
      this.KeyPreview = true;
      this.Name = "Arkanoid";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Text";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyDown);
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.gameOverScreen)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.winScreen)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label scoreLable;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox winScreen;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.PictureBox gameOverScreen;

    private System.Windows.Forms.PictureBox platform1;

    #endregion
  }
}

