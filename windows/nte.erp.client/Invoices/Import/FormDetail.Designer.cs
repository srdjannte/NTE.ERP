namespace nte.erp.client.Invoices.Import
{
  partial class FormDetail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetail));
      PanelBody = new ControlDetail();
      PanelCmd = new Panel();
      doSave = new Button();
      doClose = new Button();
      PanelCmd.SuspendLayout();
      SuspendLayout();
      // 
      // PanelBody
      // 
      PanelBody.BackColor = SystemColors.Control;
      PanelBody.Dock = DockStyle.Fill;
      PanelBody.Location = new Point(0, 0);
      PanelBody.Name = "PanelBody";
      PanelBody.Size = new Size(948, 605);
      PanelBody.TabIndex = 0;
      // 
      // PanelCmd
      // 
      PanelCmd.Controls.Add(doSave);
      PanelCmd.Controls.Add(doClose);
      PanelCmd.Dock = DockStyle.Bottom;
      PanelCmd.Location = new Point(0, 605);
      PanelCmd.Name = "PanelCmd";
      PanelCmd.Size = new Size(948, 35);
      PanelCmd.TabIndex = 1;
      // 
      // doSave
      // 
      doSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doSave.Enabled = false;
      doSave.Location = new Point(761, 6);
      doSave.Name = "doSave";
      doSave.Size = new Size(75, 23);
      doSave.TabIndex = 1;
      doSave.Text = "Snimi";
      doSave.UseVisualStyleBackColor = true;
      doSave.Click += Action_Click;
      // 
      // doClose
      // 
      doClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doClose.Location = new Point(842, 6);
      doClose.Name = "doClose";
      doClose.Size = new Size(94, 23);
      doClose.TabIndex = 0;
      doClose.Text = "zatvori";
      doClose.UseVisualStyleBackColor = true;
      doClose.Click += Action_Click;
      // 
      // FormDetail
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doClose;
      ClientSize = new Size(948, 640);
      Controls.Add(PanelBody);
      Controls.Add(PanelCmd);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "FormDetail";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Ulazna Faktura";
      PanelCmd.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private ControlDetail PanelBody;
    private Panel PanelCmd;
    private Button doSave;
    private Button doClose;
  }
}