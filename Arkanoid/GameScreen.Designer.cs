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
      this.timer1 = new System.Timers.Timer();
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.ball)).BeginInit();
      ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
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
      this.ball.Location = new System.Drawing.Point(292, 236);
      this.ball.Name = "ball";
      this.ball.Size = new System.Drawing.Size(40, 40);
      this.ball.TabIndex = 1;
      this.ball.TabStop = false;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1D;
      this.timer1.SynchronizingObject = this;
      this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
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
      ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Timers.Timer timer1;

    private System.Windows.Forms.PictureBox ball;

    private System.Windows.Forms.PictureBox platform1;

    #endregion
  }
}

