namespace nte.erp.client
{
  partial class FormAccounts
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
      PanelCmd = new Panel();
      doNew = new Button();
      doCancel = new Button();
      PanelBody = new Panel();
      AccList = new ListView();
      ColName = new ColumnHeader();
      ColStatus = new ColumnHeader();
      Colnfo = new ColumnHeader();
      PanelCmd.SuspendLayout();
      PanelBody.SuspendLayout();
      SuspendLayout();
      // 
      // PanelCmd
      // 
      PanelCmd.Controls.Add(doNew);
      PanelCmd.Controls.Add(doCancel);
      PanelCmd.Dock = DockStyle.Bottom;
      PanelCmd.Location = new Point(0, 162);
      PanelCmd.Name = "PanelCmd";
      PanelCmd.Size = new Size(542, 35);
      PanelCmd.TabIndex = 0;
      // 
      // doNew
      // 
      doNew.DialogResult = DialogResult.Continue;
      doNew.Location = new Point(3, 6);
      doNew.Name = "doNew";
      doNew.Size = new Size(108, 23);
      doNew.TabIndex = 1;
      doNew.Text = "Novi Nalog";
      doNew.UseVisualStyleBackColor = true;
      doNew.Click += Action_Click;
      // 
      // doCancel
      // 
      doCancel.DialogResult = DialogResult.Cancel;
      doCancel.Location = new Point(443, 6);
      doCancel.Name = "doCancel";
      doCancel.Size = new Size(94, 23);
      doCancel.TabIndex = 0;
      doCancel.Text = "zatvori";
      doCancel.UseVisualStyleBackColor = true;
      // 
      // PanelBody
      // 
      PanelBody.Controls.Add(AccList);
      PanelBody.Dock = DockStyle.Fill;
      PanelBody.Location = new Point(0, 0);
      PanelBody.Name = "PanelBody";
      PanelBody.Size = new Size(542, 162);
      PanelBody.TabIndex = 1;
      // 
      // AccList
      // 
      AccList.BorderStyle = BorderStyle.None;
      AccList.Columns.AddRange(new ColumnHeader[] { ColName, ColStatus, Colnfo });
      AccList.Dock = DockStyle.Fill;
      AccList.FullRowSelect = true;
      AccList.Location = new Point(0, 0);
      AccList.Name = "AccList";
      AccList.Size = new Size(542, 162);
      AccList.TabIndex = 0;
      AccList.UseCompatibleStateImageBehavior = false;
      AccList.View = View.Details;
      // 
      // ColName
      // 
      ColName.Text = "Naziv";
      ColName.Width = 220;
      // 
      // ColStatus
      // 
      ColStatus.Text = "Status";
      ColStatus.TextAlign = HorizontalAlignment.Right;
      ColStatus.Width = 80;
      // 
      // Colnfo
      // 
      Colnfo.Text = "";
      // 
      // FormAccounts
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(542, 197);
      Controls.Add(PanelBody);
      Controls.Add(PanelCmd);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "FormAccounts";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Nalozi";
      PanelCmd.ResumeLayout(false);
      PanelBody.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel PanelCmd;
    private Button doCancel;
    private Panel PanelBody;
    private ListView AccList;
    private ColumnHeader ColName;
    private ColumnHeader ColStatus;
    private ColumnHeader Colnfo;
    private Button doNew;
  }
}