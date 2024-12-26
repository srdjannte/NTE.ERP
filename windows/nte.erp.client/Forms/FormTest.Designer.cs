namespace nte.erp.client
{
  partial class FormTest
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
      button1 = new Button();
      button2 = new Button();
      textBox1 = new TextBox();
      textBox2 = new TextBox();
      SuspendLayout();
      // 
      // button1
      // 
      button1.Location = new Point(29, 23);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 0;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      button1.Click += Action_Click;
      // 
      // button2
      // 
      button2.Location = new Point(29, 96);
      button2.Name = "button2";
      button2.Size = new Size(75, 23);
      button2.TabIndex = 1;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      button2.Click += Action_Click;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(29, 67);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(244, 23);
      textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      textBox2.Location = new Point(29, 125);
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(244, 23);
      textBox2.TabIndex = 3;
      // 
      // FormTest
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(395, 216);
      Controls.Add(textBox2);
      Controls.Add(textBox1);
      Controls.Add(button2);
      Controls.Add(button1);
      Name = "FormTest";
      Text = "FormTest";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private TextBox textBox1;
    private TextBox textBox2;
  }
}