namespace nte.erp.services.invoices
{
  partial class FormEditorSourceTest
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
      ExportNameLabel = new Label();
      TestID = new TextBox();
      TestQueries = new CheckBox();
      doTest = new Button();
      doCancel = new Button();
      TestWorker = new System.ComponentModel.BackgroundWorker();
      TestLog = new Label();
      LinkSourceSaveTestFile = new LinkLabel();
      SaveFileTestDialog = new SaveFileDialog();
      SuspendLayout();
      // 
      // ExportNameLabel
      // 
      ExportNameLabel.AutoSize = true;
      ExportNameLabel.Location = new Point(132, 11);
      ExportNameLabel.Name = "ExportNameLabel";
      ExportNameLabel.Size = new Size(42, 15);
      ExportNameLabel.TabIndex = 3;
      ExportNameLabel.Text = "Test ID";
      // 
      // TestID
      // 
      TestID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      TestID.Location = new Point(180, 8);
      TestID.Name = "TestID";
      TestID.Size = new Size(90, 23);
      TestID.TabIndex = 1;
      // 
      // TestQueries
      // 
      TestQueries.AutoSize = true;
      TestQueries.Location = new Point(12, 10);
      TestQueries.Name = "TestQueries";
      TestQueries.Size = new Size(90, 19);
      TestQueries.TabIndex = 0;
      TestQueries.Text = "Test Queries";
      TestQueries.UseVisualStyleBackColor = true;
      TestQueries.CheckedChanged += TestQueries_CheckedChanged;
      // 
      // doTest
      // 
      doTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      doTest.Location = new Point(111, 140);
      doTest.Name = "doTest";
      doTest.Size = new Size(74, 23);
      doTest.TabIndex = 2;
      doTest.Text = "Test";
      doTest.UseVisualStyleBackColor = true;
      doTest.Click += Action_Click;
      // 
      // doCancel
      // 
      doCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      doCancel.Location = new Point(195, 140);
      doCancel.Name = "doCancel";
      doCancel.Size = new Size(75, 23);
      doCancel.TabIndex = 3;
      doCancel.Text = "cancel";
      doCancel.UseVisualStyleBackColor = true;
      doCancel.Click += Action_Click;
      // 
      // TestWorker
      // 
      TestWorker.WorkerReportsProgress = true;
      TestWorker.WorkerSupportsCancellation = true;
      TestWorker.DoWork += TestWorker_DoWork;
      TestWorker.ProgressChanged += TestWorker_ProgressChanged;
      TestWorker.RunWorkerCompleted += TestWorker_RunWorkerCompleted;
      // 
      // TestLog
      // 
      TestLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TestLog.Location = new Point(12, 38);
      TestLog.Name = "TestLog";
      TestLog.Size = new Size(258, 88);
      TestLog.TabIndex = 7;
      TestLog.Text = "...";
      // 
      // LinkSourceSaveTestFile
      // 
      LinkSourceSaveTestFile.AutoSize = true;
      LinkSourceSaveTestFile.LinkBehavior = LinkBehavior.HoverUnderline;
      LinkSourceSaveTestFile.Location = new Point(12, 144);
      LinkSourceSaveTestFile.Name = "LinkSourceSaveTestFile";
      LinkSourceSaveTestFile.Size = new Size(56, 15);
      LinkSourceSaveTestFile.TabIndex = 4;
      LinkSourceSaveTestFile.TabStop = true;
      LinkSourceSaveTestFile.Text = "Save As...";
      LinkSourceSaveTestFile.Click += Action_Click;
      // 
      // SaveFileTestDialog
      // 
      SaveFileTestDialog.DefaultExt = "xml";
      SaveFileTestDialog.Filter = "Xml file|*.xml|All files(s)|*.*";
      SaveFileTestDialog.Title = "Save Test File As";
      // 
      // FormEditorSourceTest
      // 
      AcceptButton = doTest;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doCancel;
      ClientSize = new Size(282, 171);
      Controls.Add(LinkSourceSaveTestFile);
      Controls.Add(TestLog);
      Controls.Add(doCancel);
      Controls.Add(doTest);
      Controls.Add(TestQueries);
      Controls.Add(ExportNameLabel);
      Controls.Add(TestID);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "FormEditorSourceTest";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Test Source";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label ExportNameLabel;
    private TextBox TestID;
    private CheckBox TestQueries;
    private Button doTest;
    private Button doCancel;
    private System.ComponentModel.BackgroundWorker TestWorker;
    private Label TestLog;
    private LinkLabel LinkSourceSaveTestFile;
    private SaveFileDialog SaveFileTestDialog;
  }
}