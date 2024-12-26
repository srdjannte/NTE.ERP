namespace nte.erp.services.invoices
{
  partial class FormEditorExportSourceMap
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
      MapKind = new ComboBox();
      NameLabel = new Label();
      MapQuery = new TextBox();
      MapName = new TextBox();
      MapKindLabel = new Label();
      MapQueryLabel = new Label();
      panel1 = new Panel();
      doCancel = new Button();
      doSave = new Button();
      MapFilter = new TextBox();
      MapFilterLabel = new Label();
      MapReplaceKey = new TextBox();
      MapReplaceKeyLabel = new Label();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // MapKind
      // 
      MapKind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      MapKind.FormattingEnabled = true;
      MapKind.Items.AddRange(new object[] { "Query", "Table", "Table1", "Table2", "Table3", "Table4", "Table5" });
      MapKind.Location = new Point(265, 27);
      MapKind.Name = "MapKind";
      MapKind.Size = new Size(137, 23);
      MapKind.TabIndex = 1;
      MapKind.SelectedIndexChanged += Action_Click;
      // 
      // NameLabel
      // 
      NameLabel.AutoSize = true;
      NameLabel.Location = new Point(12, 9);
      NameLabel.Name = "NameLabel";
      NameLabel.Size = new Size(39, 15);
      NameLabel.TabIndex = 320;
      NameLabel.Text = "Name";
      // 
      // MapQuery
      // 
      MapQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      MapQuery.Location = new Point(12, 123);
      MapQuery.Multiline = true;
      MapQuery.Name = "MapQuery";
      MapQuery.Size = new Size(390, 55);
      MapQuery.TabIndex = 4;
      MapQuery.WordWrap = false;
      // 
      // MapName
      // 
      MapName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      MapName.Location = new Point(12, 27);
      MapName.Name = "MapName";
      MapName.Size = new Size(247, 23);
      MapName.TabIndex = 0;
      // 
      // MapKindLabel
      // 
      MapKindLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      MapKindLabel.AutoSize = true;
      MapKindLabel.Location = new Point(265, 9);
      MapKindLabel.Name = "MapKindLabel";
      MapKindLabel.Size = new Size(43, 15);
      MapKindLabel.TabIndex = 323;
      MapKindLabel.Text = "Source";
      // 
      // MapQueryLabel
      // 
      MapQueryLabel.AutoSize = true;
      MapQueryLabel.Location = new Point(12, 105);
      MapQueryLabel.Name = "MapQueryLabel";
      MapQueryLabel.Size = new Size(39, 15);
      MapQueryLabel.TabIndex = 324;
      MapQueryLabel.Text = "Query";
      // 
      // panel1
      // 
      panel1.Controls.Add(doCancel);
      panel1.Controls.Add(doSave);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(0, 184);
      panel1.Name = "panel1";
      panel1.Size = new Size(411, 33);
      panel1.TabIndex = 325;
      // 
      // doCancel
      // 
      doCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doCancel.Location = new Point(327, 4);
      doCancel.Name = "doCancel";
      doCancel.Size = new Size(75, 23);
      doCancel.TabIndex = 6;
      doCancel.Text = "cancel";
      doCancel.UseVisualStyleBackColor = true;
      doCancel.Click += Action_Click;
      // 
      // doSave
      // 
      doSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doSave.Location = new Point(246, 4);
      doSave.Name = "doSave";
      doSave.Size = new Size(75, 23);
      doSave.TabIndex = 5;
      doSave.Text = "Save";
      doSave.UseVisualStyleBackColor = true;
      doSave.Click += Action_Click;
      // 
      // MapFilter
      // 
      MapFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      MapFilter.Location = new Point(12, 76);
      MapFilter.Name = "MapFilter";
      MapFilter.Size = new Size(247, 23);
      MapFilter.TabIndex = 2;
      // 
      // MapFilterLabel
      // 
      MapFilterLabel.AutoSize = true;
      MapFilterLabel.Location = new Point(12, 58);
      MapFilterLabel.Name = "MapFilterLabel";
      MapFilterLabel.Size = new Size(33, 15);
      MapFilterLabel.TabIndex = 326;
      MapFilterLabel.Text = "Filter";
      // 
      // MapReplaceKey
      // 
      MapReplaceKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      MapReplaceKey.Location = new Point(265, 76);
      MapReplaceKey.Name = "MapReplaceKey";
      MapReplaceKey.Size = new Size(137, 23);
      MapReplaceKey.TabIndex = 3;
      // 
      // MapReplaceKeyLabel
      // 
      MapReplaceKeyLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      MapReplaceKeyLabel.AutoSize = true;
      MapReplaceKeyLabel.Location = new Point(265, 58);
      MapReplaceKeyLabel.Name = "MapReplaceKeyLabel";
      MapReplaceKeyLabel.Size = new Size(70, 15);
      MapReplaceKeyLabel.TabIndex = 328;
      MapReplaceKeyLabel.Text = "Replace Key";
      // 
      // FormEditorExportSourceMap
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doCancel;
      ClientSize = new Size(411, 217);
      Controls.Add(MapReplaceKey);
      Controls.Add(MapReplaceKeyLabel);
      Controls.Add(MapFilter);
      Controls.Add(MapFilterLabel);
      Controls.Add(panel1);
      Controls.Add(MapQueryLabel);
      Controls.Add(MapKindLabel);
      Controls.Add(MapName);
      Controls.Add(MapKind);
      Controls.Add(NameLabel);
      Controls.Add(MapQuery);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "FormEditorExportSourceMap";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Map";
      panel1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ComboBox MapKind;
    private Label NameLabel;
    private TextBox MapQuery;
    private TextBox MapName;
    private Label MapKindLabel;
    private Label MapQueryLabel;
    private Panel panel1;
    private Button doCancel;
    private Button doSave;
    private TextBox MapFilter;
    private Label MapFilterLabel;
    private TextBox MapReplaceKey;
    private Label MapReplaceKeyLabel;
  }
}