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
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).BeginInit();
      this.SuspendLayout();
      // 
      // platform1
      // 
      this.platform1.Location = new System.Drawing.Point(241, 336);
      this.platform1.Name = "platform1";
      this.platform1.Size = new System.Drawing.Size(131, 40);
      this.platform1.TabIndex = 0;
      this.platform1.TabStop = false;
      // 
      // Arkanoid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 412);
      this.Controls.Add(this.platform1);
      this.KeyPreview = true;
      this.Name = "Arkanoid";
      this.Text = "Text";
      ((System.ComponentModel.ISupportInitialize) (this.platform1)).EndInit();
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox platform1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
  }
}

