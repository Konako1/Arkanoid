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
      this.ball = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ball)).BeginInit();
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
      // ball
      // 
      this.ball.BackColor = System.Drawing.Color.Transparent;
      this.ball.Location = new System.Drawing.Point(259, 183);
      this.ball.Name = "ball";
      this.ball.Size = new System.Drawing.Size(40, 40);
      this.ball.TabIndex = 1;
      this.ball.TabStop = false;
      // 
      // Arkanoid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(636, 403);
      this.Controls.Add(this.ball);
      this.Controls.Add(this.platform1);
      this.KeyPreview = true;
      this.Name = "Arkanoid";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Text";
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).EndInit();
      ((System.ComponentModel.ISupportInitialize) (this.ball)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox ball;

    private System.Windows.Forms.PictureBox platform1;

    #endregion
  }
}

