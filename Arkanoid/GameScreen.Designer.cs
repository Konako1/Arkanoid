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
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.gameOverScreen)).BeginInit();
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
      // Arkanoid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 761);
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
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox gameOverScreen;

    private System.Windows.Forms.PictureBox platform1;

    #endregion
  }
}

