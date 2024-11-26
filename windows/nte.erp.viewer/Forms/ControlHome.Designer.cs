namespace nte.erp.viewer
{
  partial class ControlHome
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
      flowLayoutPanel1 = new FlowLayoutPanel();
      button1 = new Button();
      button2 = new Button();
      button3 = new Button();
      button4 = new Button();
      statusStrip1 = new StatusStrip();
      flowLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.Controls.Add(button1);
      flowLayoutPanel1.Controls.Add(button2);
      flowLayoutPanel1.Controls.Add(button3);
      flowLayoutPanel1.Controls.Add(button4);
      flowLayoutPanel1.Dock = DockStyle.Fill;
      flowLayoutPanel1.Location = new Point(0, 0);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new Size(925, 492);
      flowLayoutPanel1.TabIndex = 2;
      // 
      // button1
      // 
      button1.Location = new Point(3, 3);
      button1.Name = "button1";
      button1.Size = new Size(162, 47);
      button1.TabIndex = 1;
      button1.Text = "Ulazne Fakture";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(171, 3);
      button2.Name = "button2";
      button2.Size = new Size(164, 47);
      button2.TabIndex = 2;
      button2.Text = "Izlazne Fakture";
      button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      button3.Location = new Point(341, 3);
      button3.Name = "button3";
      button3.Size = new Size(164, 47);
      button3.TabIndex = 3;
      button3.Text = "Izvodi";
      button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      button4.Location = new Point(511, 3);
      button4.Name = "button4";
      button4.Size = new Size(164, 47);
      button4.TabIndex = 4;
      button4.Text = "Dokumenta";
      button4.UseVisualStyleBackColor = true;
      // 
      // statusStrip1
      // 
      statusStrip1.Location = new Point(0, 470);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(925, 22);
      statusStrip1.TabIndex = 5;
      statusStrip1.Text = "statusStrip1";
      // 
      // ControlHome
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(statusStrip1);
      Controls.Add(flowLayoutPanel1);
      Name = "ControlHome";
      Size = new Size(925, 492);
      flowLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private StatusStrip statusStrip1;
  }
}
