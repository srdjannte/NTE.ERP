namespace nte.erp.client.Invoices.Import
{
  partial class FormDown
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
      doSave = new Button();
      doClose = new Button();
      PanelBody = new Panel();
      FilePanel = new Panel();
      PayableAmount = new TextBox();
      PayableAmountLabel = new Label();
      DueDate = new TextBox();
      DueDateLabel = new Label();
      InvoiceID = new TextBox();
      InvoiceIDLabel = new Label();
      PartyName = new TextBox();
      PartyNameLabel = new Label();
      label1 = new Label();
      doProvider = new Button();
      doFile = new Button();
      FileDialog = new OpenFileDialog();
      PanelCmd.SuspendLayout();
      PanelBody.SuspendLayout();
      FilePanel.SuspendLayout();
      SuspendLayout();
      // 
      // PanelCmd
      // 
      PanelCmd.Controls.Add(doSave);
      PanelCmd.Controls.Add(doClose);
      PanelCmd.Dock = DockStyle.Bottom;
      PanelCmd.Location = new Point(0, 213);
      PanelCmd.Name = "PanelCmd";
      PanelCmd.Size = new Size(475, 35);
      PanelCmd.TabIndex = 2;
      // 
      // doSave
      // 
      doSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doSave.Enabled = false;
      doSave.Location = new Point(293, 6);
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
      doClose.Location = new Point(374, 6);
      doClose.Name = "doClose";
      doClose.Size = new Size(94, 23);
      doClose.TabIndex = 0;
      doClose.Text = "zatvori";
      doClose.UseVisualStyleBackColor = true;
      doClose.Click += Action_Click;
      // 
      // PanelBody
      // 
      PanelBody.BackColor = SystemColors.ControlLightLight;
      PanelBody.Controls.Add(FilePanel);
      PanelBody.Controls.Add(label1);
      PanelBody.Controls.Add(doProvider);
      PanelBody.Controls.Add(doFile);
      PanelBody.Dock = DockStyle.Fill;
      PanelBody.Location = new Point(0, 0);
      PanelBody.Name = "PanelBody";
      PanelBody.Size = new Size(475, 213);
      PanelBody.TabIndex = 3;
      // 
      // FilePanel
      // 
      FilePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      FilePanel.Controls.Add(PayableAmount);
      FilePanel.Controls.Add(PayableAmountLabel);
      FilePanel.Controls.Add(DueDate);
      FilePanel.Controls.Add(DueDateLabel);
      FilePanel.Controls.Add(InvoiceID);
      FilePanel.Controls.Add(InvoiceIDLabel);
      FilePanel.Controls.Add(PartyName);
      FilePanel.Controls.Add(PartyNameLabel);
      FilePanel.Location = new Point(12, 62);
      FilePanel.Name = "FilePanel";
      FilePanel.Size = new Size(451, 145);
      FilePanel.TabIndex = 3;
      // 
      // PayableAmount
      // 
      PayableAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      PayableAmount.Location = new Point(278, 20);
      PayableAmount.Name = "PayableAmount";
      PayableAmount.ReadOnly = true;
      PayableAmount.Size = new Size(170, 23);
      PayableAmount.TabIndex = 7;
      PayableAmount.TextAlign = HorizontalAlignment.Right;
      // 
      // PayableAmountLabel
      // 
      PayableAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      PayableAmountLabel.Location = new Point(362, 2);
      PayableAmountLabel.Name = "PayableAmountLabel";
      PayableAmountLabel.Size = new Size(86, 15);
      PayableAmountLabel.TabIndex = 6;
      PayableAmountLabel.Text = "Iznos";
      PayableAmountLabel.TextAlign = ContentAlignment.TopRight;
      // 
      // DueDate
      // 
      DueDate.Location = new Point(154, 20);
      DueDate.Name = "DueDate";
      DueDate.ReadOnly = true;
      DueDate.Size = new Size(118, 23);
      DueDate.TabIndex = 5;
      // 
      // DueDateLabel
      // 
      DueDateLabel.AutoSize = true;
      DueDateLabel.Location = new Point(157, 2);
      DueDateLabel.Name = "DueDateLabel";
      DueDateLabel.Size = new Size(43, 15);
      DueDateLabel.TabIndex = 4;
      DueDateLabel.Text = "Datum";
      // 
      // InvoiceID
      // 
      InvoiceID.Location = new Point(0, 20);
      InvoiceID.Name = "InvoiceID";
      InvoiceID.ReadOnly = true;
      InvoiceID.Size = new Size(148, 23);
      InvoiceID.TabIndex = 3;
      // 
      // InvoiceIDLabel
      // 
      InvoiceIDLabel.AutoSize = true;
      InvoiceIDLabel.Location = new Point(3, 2);
      InvoiceIDLabel.Name = "InvoiceIDLabel";
      InvoiceIDLabel.Size = new Size(46, 15);
      InvoiceIDLabel.TabIndex = 2;
      InvoiceIDLabel.Text = "Faktura";
      // 
      // PartyName
      // 
      PartyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      PartyName.Location = new Point(0, 64);
      PartyName.Name = "PartyName";
      PartyName.ReadOnly = true;
      PartyName.Size = new Size(448, 23);
      PartyName.TabIndex = 1;
      // 
      // PartyNameLabel
      // 
      PartyNameLabel.AutoSize = true;
      PartyNameLabel.Location = new Point(3, 46);
      PartyNameLabel.Name = "PartyNameLabel";
      PartyNameLabel.Size = new Size(37, 15);
      PartyNameLabel.TabIndex = 0;
      PartyNameLabel.Text = "Firma";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(12, 11);
      label1.Name = "label1";
      label1.Size = new Size(148, 15);
      label1.TabIndex = 2;
      label1.Text = "Izaberite vrstu preuzimanja";
      // 
      // doProvider
      // 
      doProvider.Location = new Point(128, 33);
      doProvider.Name = "doProvider";
      doProvider.Size = new Size(110, 23);
      doProvider.TabIndex = 1;
      doProvider.Text = "SEF";
      doProvider.UseVisualStyleBackColor = true;
      doProvider.Click += Action_Click;
      // 
      // doFile
      // 
      doFile.Location = new Point(12, 33);
      doFile.Name = "doFile";
      doFile.Size = new Size(110, 23);
      doFile.TabIndex = 0;
      doFile.Text = "File";
      doFile.UseVisualStyleBackColor = true;
      doFile.Click += Action_Click;
      // 
      // FileDialog
      // 
      FileDialog.Title = "Izaberi datoteku za uvoz";
      // 
      // FormDown
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doClose;
      ClientSize = new Size(475, 248);
      Controls.Add(PanelBody);
      Controls.Add(PanelCmd);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "FormDown";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Preuzimanje";
      PanelCmd.ResumeLayout(false);
      PanelBody.ResumeLayout(false);
      PanelBody.PerformLayout();
      FilePanel.ResumeLayout(false);
      FilePanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Panel PanelCmd;
    private Button doSave;
    private Button doClose;
    private Panel PanelBody;
    private Button doProvider;
    private Button doFile;
    private OpenFileDialog FileDialog;
    private Label label1;
    private Panel FilePanel;
    private TextBox PartyName;
    private Label PartyNameLabel;
    private TextBox PayableAmount;
    private Label PayableAmountLabel;
    private TextBox DueDate;
    private Label DueDateLabel;
    private TextBox InvoiceID;
    private Label InvoiceIDLabel;
  }
}