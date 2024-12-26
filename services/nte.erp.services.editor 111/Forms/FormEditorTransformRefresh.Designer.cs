namespace nte.erp.services.invoices
{
  partial class FormEditorTransformRefresh
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditorTransformRefresh));
      panel1 = new Panel();
      doCancel = new Button();
      doSave = new Button();
      panel2 = new Panel();
      ShemaFields = new DataGridView();
      ColItemSave = new DataGridViewCheckBoxColumn();
      ColItemAction = new DataGridViewComboBoxColumn();
      ColName = new DataGridViewTextBoxColumn();
      ColSourceName = new DataGridViewComboBoxColumn();
      ColConvertTo = new DataGridViewComboBoxColumn();
      ColConvertError = new DataGridViewComboBoxColumn();
      ColIfEmpty = new DataGridViewComboBoxColumn();
      ColDefaultValue = new DataGridViewTextBoxColumn();
      ColItemMessage = new DataGridViewTextBoxColumn();
      MainStrip = new ToolStrip();
      CheckAll = new ToolStripButton();
      DeCheckAll = new ToolStripButton();
      toolStripSeparator1 = new ToolStripSeparator();
      ReloadSource = new ToolStripButton();
      ReloadStatus = new ToolStripLabel();
      ReloadSourceLabel = new ToolStripLabel();
      panel1.SuspendLayout();
      panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ShemaFields).BeginInit();
      MainStrip.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.Controls.Add(doCancel);
      panel1.Controls.Add(doSave);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(0, 424);
      panel1.Name = "panel1";
      panel1.Size = new Size(947, 33);
      panel1.TabIndex = 0;
      // 
      // doCancel
      // 
      doCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doCancel.Location = new Point(860, 6);
      doCancel.Name = "doCancel";
      doCancel.Size = new Size(75, 23);
      doCancel.TabIndex = 1;
      doCancel.Text = "cancel";
      doCancel.UseVisualStyleBackColor = true;
      doCancel.Click += Action_Click;
      // 
      // doSave
      // 
      doSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doSave.Location = new Point(779, 6);
      doSave.Name = "doSave";
      doSave.Size = new Size(75, 23);
      doSave.TabIndex = 0;
      doSave.Text = "Save";
      doSave.UseVisualStyleBackColor = true;
      doSave.Click += Action_Click;
      // 
      // panel2
      // 
      panel2.Controls.Add(ShemaFields);
      panel2.Dock = DockStyle.Fill;
      panel2.Location = new Point(0, 25);
      panel2.Name = "panel2";
      panel2.Size = new Size(947, 399);
      panel2.TabIndex = 1;
      // 
      // ShemaFields
      // 
      ShemaFields.AllowUserToAddRows = false;
      ShemaFields.AllowUserToDeleteRows = false;
      ShemaFields.AllowUserToResizeRows = false;
      ShemaFields.BorderStyle = BorderStyle.None;
      ShemaFields.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      ShemaFields.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      ShemaFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ShemaFields.Columns.AddRange(new DataGridViewColumn[] { ColItemSave, ColItemAction, ColName, ColSourceName, ColConvertTo, ColConvertError, ColIfEmpty, ColDefaultValue, ColItemMessage });
      ShemaFields.Dock = DockStyle.Fill;
      ShemaFields.Location = new Point(0, 0);
      ShemaFields.Name = "ShemaFields";
      ShemaFields.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      ShemaFields.RowHeadersVisible = false;
      ShemaFields.Size = new Size(947, 399);
      ShemaFields.StandardTab = true;
      ShemaFields.TabIndex = 2;
      // 
      // ColItemSave
      // 
      ColItemSave.DataPropertyName = "ItemSave";
      ColItemSave.HeaderText = "Save";
      ColItemSave.Name = "ColItemSave";
      ColItemSave.Resizable = DataGridViewTriState.True;
      ColItemSave.SortMode = DataGridViewColumnSortMode.Automatic;
      ColItemSave.Width = 40;
      // 
      // ColItemAction
      // 
      ColItemAction.DataPropertyName = "ItemAction";
      ColItemAction.FlatStyle = FlatStyle.Flat;
      ColItemAction.HeaderText = "Action";
      ColItemAction.Items.AddRange(new object[] { "Ignore", "Add", "Update", "Delete" });
      ColItemAction.Name = "ColItemAction";
      ColItemAction.Resizable = DataGridViewTriState.True;
      ColItemAction.SortMode = DataGridViewColumnSortMode.Automatic;
      ColItemAction.Visible = false;
      ColItemAction.Width = 70;
      // 
      // ColName
      // 
      ColName.DataPropertyName = "Name";
      ColName.HeaderText = "Name";
      ColName.Name = "ColName";
      ColName.Width = 150;
      // 
      // ColSourceName
      // 
      ColSourceName.DataPropertyName = "SourceName";
      ColSourceName.FlatStyle = FlatStyle.Flat;
      ColSourceName.HeaderText = "Source Name";
      ColSourceName.Name = "ColSourceName";
      ColSourceName.Resizable = DataGridViewTriState.True;
      ColSourceName.SortMode = DataGridViewColumnSortMode.Automatic;
      ColSourceName.Width = 150;
      // 
      // ColConvertTo
      // 
      ColConvertTo.DataPropertyName = "ConvertTo";
      ColConvertTo.FlatStyle = FlatStyle.Flat;
      ColConvertTo.HeaderText = "Convert To";
      ColConvertTo.Items.AddRange(new object[] { "Implicit", "String", "Integer", "Percent", "Money", "Date", "Time", "DateTime", "FilePath" });
      ColConvertTo.Name = "ColConvertTo";
      ColConvertTo.Resizable = DataGridViewTriState.True;
      ColConvertTo.SortMode = DataGridViewColumnSortMode.Automatic;
      ColConvertTo.Width = 90;
      // 
      // ColConvertError
      // 
      ColConvertError.DataPropertyName = "ConvertError";
      ColConvertError.FlatStyle = FlatStyle.Flat;
      ColConvertError.HeaderText = "On Error";
      ColConvertError.Items.AddRange(new object[] { "Stop", "Skip" });
      ColConvertError.Name = "ColConvertError";
      ColConvertError.Resizable = DataGridViewTriState.True;
      ColConvertError.SortMode = DataGridViewColumnSortMode.Automatic;
      ColConvertError.Width = 90;
      // 
      // ColIfEmpty
      // 
      ColIfEmpty.DataPropertyName = "IfEmpty";
      ColIfEmpty.FlatStyle = FlatStyle.Flat;
      ColIfEmpty.HeaderText = "If Empty";
      ColIfEmpty.Items.AddRange(new object[] { "Ignore", "Remove", "Stop", "Default" });
      ColIfEmpty.Name = "ColIfEmpty";
      ColIfEmpty.Resizable = DataGridViewTriState.True;
      ColIfEmpty.SortMode = DataGridViewColumnSortMode.Automatic;
      ColIfEmpty.ToolTipText = "If no value ";
      ColIfEmpty.Width = 90;
      // 
      // ColDefaultValue
      // 
      ColDefaultValue.HeaderText = "Default";
      ColDefaultValue.Name = "ColDefaultValue";
      ColDefaultValue.Width = 60;
      // 
      // ColItemMessage
      // 
      ColItemMessage.DataPropertyName = "ItemMessage";
      ColItemMessage.HeaderText = "Message";
      ColItemMessage.Name = "ColItemMessage";
      ColItemMessage.ReadOnly = true;
      ColItemMessage.Width = 200;
      // 
      // MainStrip
      // 
      MainStrip.GripStyle = ToolStripGripStyle.Hidden;
      MainStrip.Items.AddRange(new ToolStripItem[] { CheckAll, DeCheckAll, toolStripSeparator1, ReloadSource, ReloadStatus, ReloadSourceLabel });
      MainStrip.Location = new Point(0, 0);
      MainStrip.Name = "MainStrip";
      MainStrip.Size = new Size(947, 25);
      MainStrip.TabIndex = 2;
      MainStrip.Text = "toolStrip1";
      // 
      // CheckAll
      // 
      CheckAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
      CheckAll.Image = (Image)resources.GetObject("CheckAll.Image");
      CheckAll.ImageTransparentColor = Color.Magenta;
      CheckAll.Name = "CheckAll";
      CheckAll.Size = new Size(61, 22);
      CheckAll.Text = "Check All";
      CheckAll.Click += Action_Click;
      // 
      // DeCheckAll
      // 
      DeCheckAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
      DeCheckAll.Image = (Image)resources.GetObject("DeCheckAll.Image");
      DeCheckAll.ImageTransparentColor = Color.Magenta;
      DeCheckAll.Name = "DeCheckAll";
      DeCheckAll.Size = new Size(73, 22);
      DeCheckAll.Text = "Decheck All";
      DeCheckAll.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(6, 25);
      // 
      // ReloadSource
      // 
      ReloadSource.DisplayStyle = ToolStripItemDisplayStyle.Image;
      ReloadSource.Image = (Image)resources.GetObject("ReloadSource.Image");
      ReloadSource.ImageTransparentColor = Color.Magenta;
      ReloadSource.Name = "ReloadSource";
      ReloadSource.Size = new Size(23, 22);
      ReloadSource.Text = "Reload Source";
      ReloadSource.Click += Action_Click;
      // 
      // ReloadStatus
      // 
      ReloadStatus.Name = "ReloadStatus";
      ReloadStatus.Size = new Size(0, 22);
      // 
      // ReloadSourceLabel
      // 
      ReloadSourceLabel.Name = "ReloadSourceLabel";
      ReloadSourceLabel.Size = new Size(16, 22);
      ReloadSourceLabel.Text = "...";
      // 
      // FormEditorTransformRefresh
      // 
      AcceptButton = doSave;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doCancel;
      ClientSize = new Size(947, 457);
      Controls.Add(panel2);
      Controls.Add(MainStrip);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "FormEditorTransformRefresh";
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Refresh Fields";
      Shown += FormEditorTransformRefresh_Shown;
      panel1.ResumeLayout(false);
      panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)ShemaFields).EndInit();
      MainStrip.ResumeLayout(false);
      MainStrip.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Button doCancel;
    private Button doSave;
    private ToolStrip MainStrip;
    private DataGridView ShemaFields;
    private ToolStripButton CheckAll;
    private ToolStripButton DeCheckAll;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton ReloadSource;
    private ToolStripLabel ReloadStatus;
    private ToolStripLabel ReloadSourceLabel;
    private DataGridViewCheckBoxColumn ColItemSave;
    private DataGridViewComboBoxColumn ColItemAction;
    private DataGridViewTextBoxColumn ColName;
    private DataGridViewComboBoxColumn ColSourceName;
    private DataGridViewComboBoxColumn ColConvertTo;
    private DataGridViewComboBoxColumn ColConvertError;
    private DataGridViewComboBoxColumn ColIfEmpty;
    private DataGridViewTextBoxColumn ColDefaultValue;
    private DataGridViewTextBoxColumn ColItemMessage;
  }
}