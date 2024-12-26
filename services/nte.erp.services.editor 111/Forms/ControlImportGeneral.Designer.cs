namespace nte.erp.services.invoices.Forms.Editor
{
  partial class ControlImportGeneral
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
      ExportLogDebug = new CheckBox();
      ExportFileNameLabel = new Label();
      ExportFileName = new TextBox();
      ExportLogTo = new CheckBox();
      ExportKindLabel = new Label();
      ExportKind = new ComboBox();
      ExportChangeTextLabel = new Label();
      ExportChangeText = new TextBox();
      ExportCreatedTextLabel = new Label();
      ExportCreatedText = new TextBox();
      ExportDescriptionLabel = new Label();
      ExportDescription = new TextBox();
      ExportNameLabel = new Label();
      ExportName = new TextBox();
      SuspendLayout();
      // 
      // ExportLogDebug
      // 
      ExportLogDebug.AutoSize = true;
      ExportLogDebug.Location = new Point(64, 155);
      ExportLogDebug.Name = "ExportLogDebug";
      ExportLogDebug.Size = new Size(61, 19);
      ExportLogDebug.TabIndex = 27;
      ExportLogDebug.Text = "Debug";
      ExportLogDebug.UseVisualStyleBackColor = true;
      // 
      // ExportFileNameLabel
      // 
      ExportFileNameLabel.AutoSize = true;
      ExportFileNameLabel.Location = new Point(12, 235);
      ExportFileNameLabel.Name = "ExportFileNameLabel";
      ExportFileNameLabel.Size = new Size(60, 15);
      ExportFileNameLabel.TabIndex = 26;
      ExportFileNameLabel.Text = "File Name";
      // 
      // ExportFileName
      // 
      ExportFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportFileName.Font = new Font("Segoe UI", 9F);
      ExportFileName.Location = new Point(12, 254);
      ExportFileName.Name = "ExportFileName";
      ExportFileName.ReadOnly = true;
      ExportFileName.Size = new Size(895, 23);
      ExportFileName.TabIndex = 25;
      // 
      // ExportLogTo
      // 
      ExportLogTo.AutoSize = true;
      ExportLogTo.Location = new Point(12, 155);
      ExportLogTo.Name = "ExportLogTo";
      ExportLogTo.Size = new Size(46, 19);
      ExportLogTo.TabIndex = 24;
      ExportLogTo.Text = "Log";
      ExportLogTo.UseVisualStyleBackColor = true;
      // 
      // ExportKindLabel
      // 
      ExportKindLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportKindLabel.AutoSize = true;
      ExportKindLabel.Location = new Point(755, 8);
      ExportKindLabel.Name = "ExportKindLabel";
      ExportKindLabel.Size = new Size(31, 15);
      ExportKindLabel.TabIndex = 23;
      ExportKindLabel.Text = "Kind";
      // 
      // ExportKind
      // 
      ExportKind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportKind.DropDownStyle = ComboBoxStyle.DropDownList;
      ExportKind.Enabled = false;
      ExportKind.FormattingEnabled = true;
      ExportKind.Items.AddRange(new object[] { "Export", "Import" });
      ExportKind.Location = new Point(755, 27);
      ExportKind.Name = "ExportKind";
      ExportKind.Size = new Size(152, 23);
      ExportKind.TabIndex = 22;
      ExportKind.TabStop = false;
      // 
      // ExportChangeTextLabel
      // 
      ExportChangeTextLabel.AutoSize = true;
      ExportChangeTextLabel.Location = new Point(12, 183);
      ExportChangeTextLabel.Name = "ExportChangeTextLabel";
      ExportChangeTextLabel.Size = new Size(55, 15);
      ExportChangeTextLabel.TabIndex = 21;
      ExportChangeTextLabel.Text = "Changed";
      // 
      // ExportChangeText
      // 
      ExportChangeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportChangeText.Location = new Point(12, 202);
      ExportChangeText.Name = "ExportChangeText";
      ExportChangeText.ReadOnly = true;
      ExportChangeText.Size = new Size(662, 23);
      ExportChangeText.TabIndex = 20;
      ExportChangeText.TabStop = false;
      // 
      // ExportCreatedTextLabel
      // 
      ExportCreatedTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportCreatedTextLabel.AutoSize = true;
      ExportCreatedTextLabel.Location = new Point(682, 183);
      ExportCreatedTextLabel.Name = "ExportCreatedTextLabel";
      ExportCreatedTextLabel.Size = new Size(48, 15);
      ExportCreatedTextLabel.TabIndex = 19;
      ExportCreatedTextLabel.Text = "Created";
      // 
      // ExportCreatedText
      // 
      ExportCreatedText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportCreatedText.Location = new Point(680, 202);
      ExportCreatedText.Name = "ExportCreatedText";
      ExportCreatedText.ReadOnly = true;
      ExportCreatedText.Size = new Size(227, 23);
      ExportCreatedText.TabIndex = 18;
      ExportCreatedText.TabStop = false;
      // 
      // ExportDescriptionLabel
      // 
      ExportDescriptionLabel.AutoSize = true;
      ExportDescriptionLabel.Location = new Point(12, 64);
      ExportDescriptionLabel.Name = "ExportDescriptionLabel";
      ExportDescriptionLabel.Size = new Size(67, 15);
      ExportDescriptionLabel.TabIndex = 17;
      ExportDescriptionLabel.Text = "Description";
      // 
      // ExportDescription
      // 
      ExportDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportDescription.Location = new Point(12, 82);
      ExportDescription.Multiline = true;
      ExportDescription.Name = "ExportDescription";
      ExportDescription.Size = new Size(895, 67);
      ExportDescription.TabIndex = 15;
      // 
      // ExportNameLabel
      // 
      ExportNameLabel.AutoSize = true;
      ExportNameLabel.Location = new Point(12, 8);
      ExportNameLabel.Name = "ExportNameLabel";
      ExportNameLabel.Size = new Size(39, 15);
      ExportNameLabel.TabIndex = 16;
      ExportNameLabel.Text = "Name";
      // 
      // ExportName
      // 
      ExportName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      ExportName.Location = new Point(12, 27);
      ExportName.Name = "ExportName";
      ExportName.Size = new Size(737, 23);
      ExportName.TabIndex = 14;
      // 
      // ControlImportGeneral
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(ExportLogDebug);
      Controls.Add(ExportFileNameLabel);
      Controls.Add(ExportFileName);
      Controls.Add(ExportLogTo);
      Controls.Add(ExportKindLabel);
      Controls.Add(ExportKind);
      Controls.Add(ExportChangeTextLabel);
      Controls.Add(ExportChangeText);
      Controls.Add(ExportCreatedTextLabel);
      Controls.Add(ExportCreatedText);
      Controls.Add(ExportDescriptionLabel);
      Controls.Add(ExportDescription);
      Controls.Add(ExportNameLabel);
      Controls.Add(ExportName);
      Name = "ControlImportGeneral";
      Size = new Size(922, 326);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private CheckBox ExportLogDebug;
    private Label ExportFileNameLabel;
    private TextBox ExportFileName;
    private CheckBox ExportLogTo;
    private Label ExportKindLabel;
    private ComboBox ExportKind;
    private Label ExportChangeTextLabel;
    private TextBox ExportChangeText;
    private Label ExportCreatedTextLabel;
    private TextBox ExportCreatedText;
    private Label ExportDescriptionLabel;
    private TextBox ExportDescription;
    private Label ExportNameLabel;
    private TextBox ExportName;
  }
}
