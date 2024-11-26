namespace nte.erp.viewer.Forms
{
  partial class ControlSetup
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      statusStrip1 = new StatusStrip();
      label1 = new Label();
      SuspendLayout();
      // 
      // statusStrip1
      // 
      statusStrip1.Location = new Point(0, 491);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(889, 22);
      statusStrip1.TabIndex = 0;
      statusStrip1.Text = "statusStrip1";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(32, 37);
      label1.Name = "label1";
      label1.Size = new Size(37, 15);
      label1.TabIndex = 1;
      label1.Text = "Setup";
      // 
      // ControlSetup
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(label1);
      Controls.Add(statusStrip1);
      Name = "ControlSetup";
      Size = new Size(889, 513);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip1;
    private Label label1;
  }
}
