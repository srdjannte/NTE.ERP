namespace nte.erp.services.invoices
{
  partial class FormEditorSourceManage
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
      CmdPanel = new Panel();
      doCancel = new Button();
      doSave = new Button();
      ListView = new DataGridView();
      ColName = new DataGridViewTextBoxColumn();
      ColKind = new DataGridViewTextBoxColumn();
      ColAction = new DataGridViewButtonColumn();
      ColMessage = new DataGridViewTextBoxColumn();
      ColIndex = new DataGridViewTextBoxColumn();
      CmdPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListView).BeginInit();
      SuspendLayout();
      // 
      // CmdPanel
      // 
      CmdPanel.Controls.Add(doCancel);
      CmdPanel.Controls.Add(doSave);
      CmdPanel.Dock = DockStyle.Bottom;
      CmdPanel.Location = new Point(0, 314);
      CmdPanel.Name = "CmdPanel";
      CmdPanel.Size = new Size(649, 37);
      CmdPanel.TabIndex = 0;
      // 
      // doCancel
      // 
      doCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doCancel.Location = new Point(571, 6);
      doCancel.Name = "doCancel";
      doCancel.Size = new Size(75, 23);
      doCancel.TabIndex = 3;
      doCancel.Text = "cancel";
      doCancel.UseVisualStyleBackColor = true;
      doCancel.Click += Action_Click;
      // 
      // doSave
      // 
      doSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doSave.Location = new Point(490, 6);
      doSave.Name = "doSave";
      doSave.Size = new Size(75, 23);
      doSave.TabIndex = 2;
      doSave.Text = "Apply";
      doSave.UseVisualStyleBackColor = true;
      doSave.Click += Action_Click;
      // 
      // ListView
      // 
      ListView.AllowUserToAddRows = false;
      ListView.AllowUserToDeleteRows = false;
      ListView.AllowUserToResizeRows = false;
      ListView.BackgroundColor = SystemColors.Control;
      ListView.BorderStyle = BorderStyle.None;
      ListView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      ListView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      ListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ListView.Columns.AddRange(new DataGridViewColumn[] { ColName, ColKind, ColAction, ColMessage, ColIndex });
      ListView.Dock = DockStyle.Fill;
      ListView.Location = new Point(0, 0);
      ListView.Name = "ListView";
      ListView.ReadOnly = true;
      ListView.RowHeadersVisible = false;
      ListView.Size = new Size(649, 314);
      ListView.TabIndex = 1;
      ListView.CellContentClick += ListView_CellContentClick;
      ListView.CellDoubleClick += ListView_CellDoubleClick;
      ListView.DataBindingComplete += ListView_DataBindingComplete;
      // 
      // ColName
      // 
      ColName.DataPropertyName = "Name";
      ColName.Frozen = true;
      ColName.HeaderText = "Name";
      ColName.Name = "ColName";
      ColName.ReadOnly = true;
      ColName.Width = 200;
      // 
      // ColKind
      // 
      ColKind.DataPropertyName = "Kind";
      ColKind.HeaderText = "Kind";
      ColKind.Name = "ColKind";
      ColKind.ReadOnly = true;
      ColKind.Width = 70;
      // 
      // ColAction
      // 
      ColAction.DataPropertyName = "Action";
      ColAction.FlatStyle = FlatStyle.Flat;
      ColAction.HeaderText = "";
      ColAction.Name = "ColAction";
      ColAction.ReadOnly = true;
      ColAction.ToolTipText = "Action";
      ColAction.Width = 60;
      // 
      // ColMessage
      // 
      ColMessage.DataPropertyName = "Message";
      ColMessage.HeaderText = "";
      ColMessage.Name = "ColMessage";
      ColMessage.ReadOnly = true;
      ColMessage.ToolTipText = "Message";
      ColMessage.Width = 300;
      // 
      // ColIndex
      // 
      ColIndex.DataPropertyName = "Index";
      ColIndex.HeaderText = "Index";
      ColIndex.Name = "ColIndex";
      ColIndex.ReadOnly = true;
      ColIndex.Visible = false;
      // 
      // FormEditorSourceManage
      // 
      AcceptButton = doSave;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doCancel;
      ClientSize = new Size(649, 351);
      Controls.Add(ListView);
      Controls.Add(CmdPanel);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "FormEditorSourceManage";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Source Manage";
      CmdPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)ListView).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Panel CmdPanel;
    private DataGridView ListView;
    private Button doCancel;
    private Button doSave;
    private DataGridViewTextBoxColumn ColName;
    private DataGridViewTextBoxColumn ColKind;
    private DataGridViewButtonColumn ColAction;
    private DataGridViewTextBoxColumn ColMessage;
    private DataGridViewTextBoxColumn ColIndex;
  }
}