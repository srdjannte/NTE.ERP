namespace nte.erp.client
{
  partial class FormConfigDestination
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
      SendToSEFPanel = new Panel();
      linkLabel1 = new LinkLabel();
      label12 = new Label();
      ExportSendSEFApiKey = new TextBox();
      label11 = new Label();
      ExportSendSEFURI = new TextBox();
      SendToMRPanel = new Panel();
      SendMRTestDebug = new CheckBox();
      SendMRTestID = new LinkLabel();
      SendMRTestFile = new LinkLabel();
      SendMRLog = new TextBox();
      label9 = new Label();
      ExportSendMRSoftwareID = new TextBox();
      label8 = new Label();
      ExportSendMRCompanyID = new TextBox();
      label7 = new Label();
      ExportSendMRPassword = new TextBox();
      label6 = new Label();
      ExportSendMRUsername = new TextBox();
      label5 = new Label();
      ExportSendMRURI = new TextBox();
      SendToFilePanel = new Panel();
      label16 = new Label();
      ExportSendFileLocation = new TextBox();
      SendMainPanel = new Panel();
      ExportSendManage = new LinkLabel();
      label1 = new Label();
      ExportSendName = new TextBox();
      label4 = new Label();
      ExportSendProvider = new ComboBox();
      SendToSEFPanel.SuspendLayout();
      SendToMRPanel.SuspendLayout();
      SendToFilePanel.SuspendLayout();
      SendMainPanel.SuspendLayout();
      SuspendLayout();
      // 
      // SendToSEFPanel
      // 
      SendToSEFPanel.Controls.Add(linkLabel1);
      SendToSEFPanel.Controls.Add(label12);
      SendToSEFPanel.Controls.Add(ExportSendSEFApiKey);
      SendToSEFPanel.Controls.Add(label11);
      SendToSEFPanel.Controls.Add(ExportSendSEFURI);
      SendToSEFPanel.Dock = DockStyle.Top;
      SendToSEFPanel.Location = new Point(0, 437);
      SendToSEFPanel.Name = "SendToSEFPanel";
      SendToSEFPanel.Size = new Size(535, 90);
      SendToSEFPanel.TabIndex = 317;
      // 
      // linkLabel1
      // 
      linkLabel1.AutoSize = true;
      linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
      linkLabel1.Location = new Point(8, 64);
      linkLabel1.Name = "linkLabel1";
      linkLabel1.Size = new Size(75, 15);
      linkLabel1.TabIndex = 315;
      linkLabel1.TabStop = true;
      linkLabel1.Text = "Test with File";
      // 
      // label12
      // 
      label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label12.AutoSize = true;
      label12.Location = new Point(376, 10);
      label12.Name = "label12";
      label12.Size = new Size(47, 15);
      label12.TabIndex = 28;
      label12.Text = "Api Key";
      // 
      // ExportSendSEFApiKey
      // 
      ExportSendSEFApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendSEFApiKey.Font = new Font("Segoe UI", 9F);
      ExportSendSEFApiKey.Location = new Point(376, 28);
      ExportSendSEFApiKey.Name = "ExportSendSEFApiKey";
      ExportSendSEFApiKey.Size = new Size(147, 23);
      ExportSendSEFApiKey.TabIndex = 27;
      // 
      // label11
      // 
      label11.AutoSize = true;
      label11.Location = new Point(8, 10);
      label11.Name = "label11";
      label11.Size = new Size(92, 15);
      label11.TabIndex = 26;
      label11.Text = "WebService URL";
      // 
      // ExportSendSEFURI
      // 
      ExportSendSEFURI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSendSEFURI.Font = new Font("Segoe UI", 9F);
      ExportSendSEFURI.Location = new Point(8, 28);
      ExportSendSEFURI.Name = "ExportSendSEFURI";
      ExportSendSEFURI.Size = new Size(362, 23);
      ExportSendSEFURI.TabIndex = 25;
      // 
      // SendToMRPanel
      // 
      SendToMRPanel.Controls.Add(SendMRTestDebug);
      SendToMRPanel.Controls.Add(SendMRTestID);
      SendToMRPanel.Controls.Add(SendMRTestFile);
      SendToMRPanel.Controls.Add(SendMRLog);
      SendToMRPanel.Controls.Add(label9);
      SendToMRPanel.Controls.Add(ExportSendMRSoftwareID);
      SendToMRPanel.Controls.Add(label8);
      SendToMRPanel.Controls.Add(ExportSendMRCompanyID);
      SendToMRPanel.Controls.Add(label7);
      SendToMRPanel.Controls.Add(ExportSendMRPassword);
      SendToMRPanel.Controls.Add(label6);
      SendToMRPanel.Controls.Add(ExportSendMRUsername);
      SendToMRPanel.Controls.Add(label5);
      SendToMRPanel.Controls.Add(ExportSendMRURI);
      SendToMRPanel.Dock = DockStyle.Top;
      SendToMRPanel.Location = new Point(0, 125);
      SendToMRPanel.Name = "SendToMRPanel";
      SendToMRPanel.Size = new Size(535, 312);
      SendToMRPanel.TabIndex = 314;
      // 
      // SendMRTestDebug
      // 
      SendMRTestDebug.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      SendMRTestDebug.AutoSize = true;
      SendMRTestDebug.CheckAlign = ContentAlignment.MiddleRight;
      SendMRTestDebug.ForeColor = Color.Blue;
      SendMRTestDebug.Location = new Point(462, 162);
      SendMRTestDebug.Name = "SendMRTestDebug";
      SendMRTestDebug.Size = new Size(61, 19);
      SendMRTestDebug.TabIndex = 316;
      SendMRTestDebug.Text = "Debug";
      SendMRTestDebug.UseVisualStyleBackColor = true;
      // 
      // SendMRTestID
      // 
      SendMRTestID.AutoSize = true;
      SendMRTestID.LinkBehavior = LinkBehavior.HoverUnderline;
      SendMRTestID.Location = new Point(91, 162);
      SendMRTestID.Name = "SendMRTestID";
      SendMRTestID.Size = new Size(68, 15);
      SendMRTestID.TabIndex = 315;
      SendMRTestID.TabStop = true;
      SendMRTestID.Text = "Test with ID";
      // 
      // SendMRTestFile
      // 
      SendMRTestFile.AutoSize = true;
      SendMRTestFile.LinkBehavior = LinkBehavior.HoverUnderline;
      SendMRTestFile.Location = new Point(8, 162);
      SendMRTestFile.Name = "SendMRTestFile";
      SendMRTestFile.Size = new Size(75, 15);
      SendMRTestFile.TabIndex = 314;
      SendMRTestFile.TabStop = true;
      SendMRTestFile.Text = "Test with File";
      // 
      // SendMRLog
      // 
      SendMRLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      SendMRLog.BorderStyle = BorderStyle.None;
      SendMRLog.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      SendMRLog.Location = new Point(8, 182);
      SendMRLog.Multiline = true;
      SendMRLog.Name = "SendMRLog";
      SendMRLog.ReadOnly = true;
      SendMRLog.Size = new Size(515, 116);
      SendMRLog.TabIndex = 33;
      SendMRLog.WordWrap = false;
      // 
      // label9
      // 
      label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label9.AutoSize = true;
      label9.Location = new Point(376, 112);
      label9.Name = "label9";
      label9.Size = new Size(67, 15);
      label9.TabIndex = 32;
      label9.Text = "Software ID";
      // 
      // ExportSendMRSoftwareID
      // 
      ExportSendMRSoftwareID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendMRSoftwareID.Font = new Font("Segoe UI", 9F);
      ExportSendMRSoftwareID.Location = new Point(376, 130);
      ExportSendMRSoftwareID.Name = "ExportSendMRSoftwareID";
      ExportSendMRSoftwareID.Size = new Size(147, 23);
      ExportSendMRSoftwareID.TabIndex = 31;
      // 
      // label8
      // 
      label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label8.AutoSize = true;
      label8.Location = new Point(376, 60);
      label8.Name = "label8";
      label8.Size = new Size(73, 15);
      label8.TabIndex = 30;
      label8.Text = "Company ID";
      // 
      // ExportSendMRCompanyID
      // 
      ExportSendMRCompanyID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendMRCompanyID.Font = new Font("Segoe UI", 9F);
      ExportSendMRCompanyID.Location = new Point(376, 78);
      ExportSendMRCompanyID.Name = "ExportSendMRCompanyID";
      ExportSendMRCompanyID.Size = new Size(147, 23);
      ExportSendMRCompanyID.TabIndex = 29;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(8, 112);
      label7.Name = "label7";
      label7.Size = new Size(57, 15);
      label7.TabIndex = 28;
      label7.Text = "Password";
      // 
      // ExportSendMRPassword
      // 
      ExportSendMRPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSendMRPassword.Font = new Font("Segoe UI", 9F);
      ExportSendMRPassword.Location = new Point(8, 130);
      ExportSendMRPassword.Name = "ExportSendMRPassword";
      ExportSendMRPassword.Size = new Size(362, 23);
      ExportSendMRPassword.TabIndex = 27;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(8, 60);
      label6.Name = "label6";
      label6.Size = new Size(60, 15);
      label6.TabIndex = 26;
      label6.Text = "Username";
      // 
      // ExportSendMRUsername
      // 
      ExportSendMRUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSendMRUsername.Font = new Font("Segoe UI", 9F);
      ExportSendMRUsername.Location = new Point(8, 78);
      ExportSendMRUsername.Name = "ExportSendMRUsername";
      ExportSendMRUsername.Size = new Size(362, 23);
      ExportSendMRUsername.TabIndex = 25;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(8, 9);
      label5.Name = "label5";
      label5.Size = new Size(92, 15);
      label5.TabIndex = 24;
      label5.Text = "WebService URL";
      // 
      // ExportSendMRURI
      // 
      ExportSendMRURI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSendMRURI.Font = new Font("Segoe UI", 9F);
      ExportSendMRURI.Location = new Point(8, 27);
      ExportSendMRURI.Name = "ExportSendMRURI";
      ExportSendMRURI.Size = new Size(515, 23);
      ExportSendMRURI.TabIndex = 23;
      // 
      // SendToFilePanel
      // 
      SendToFilePanel.Controls.Add(label16);
      SendToFilePanel.Controls.Add(ExportSendFileLocation);
      SendToFilePanel.Dock = DockStyle.Top;
      SendToFilePanel.Location = new Point(0, 68);
      SendToFilePanel.Name = "SendToFilePanel";
      SendToFilePanel.Size = new Size(535, 57);
      SendToFilePanel.TabIndex = 315;
      // 
      // label16
      // 
      label16.AutoSize = true;
      label16.Location = new Point(8, 8);
      label16.Name = "label16";
      label16.Size = new Size(74, 15);
      label16.TabIndex = 24;
      label16.Text = "File Location";
      // 
      // ExportSendFileLocation
      // 
      ExportSendFileLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSendFileLocation.Font = new Font("Segoe UI", 9F);
      ExportSendFileLocation.Location = new Point(8, 26);
      ExportSendFileLocation.Name = "ExportSendFileLocation";
      ExportSendFileLocation.Size = new Size(515, 23);
      ExportSendFileLocation.TabIndex = 23;
      // 
      // SendMainPanel
      // 
      SendMainPanel.Controls.Add(ExportSendManage);
      SendMainPanel.Controls.Add(label1);
      SendMainPanel.Controls.Add(ExportSendName);
      SendMainPanel.Controls.Add(label4);
      SendMainPanel.Controls.Add(ExportSendProvider);
      SendMainPanel.Dock = DockStyle.Top;
      SendMainPanel.Location = new Point(0, 0);
      SendMainPanel.Name = "SendMainPanel";
      SendMainPanel.Size = new Size(535, 68);
      SendMainPanel.TabIndex = 316;
      // 
      // ExportSendManage
      // 
      ExportSendManage.AutoSize = true;
      ExportSendManage.LinkBehavior = LinkBehavior.HoverUnderline;
      ExportSendManage.Location = new Point(53, 21);
      ExportSendManage.Name = "ExportSendManage";
      ExportSendManage.Size = new Size(58, 15);
      ExportSendManage.TabIndex = 315;
      ExportSendManage.TabStop = true;
      ExportSendManage.Text = "(manage)";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(8, 21);
      label1.Name = "label1";
      label1.Size = new Size(39, 15);
      label1.TabIndex = 313;
      label1.Text = "Name";
      // 
      // ExportSendName
      // 
      ExportSendName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSendName.Location = new Point(8, 40);
      ExportSendName.Name = "ExportSendName";
      ExportSendName.Size = new Size(362, 23);
      ExportSendName.TabIndex = 314;
      // 
      // label4
      // 
      label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label4.AutoSize = true;
      label4.Location = new Point(376, 20);
      label4.Name = "label4";
      label4.Size = new Size(51, 15);
      label4.TabIndex = 312;
      label4.Text = "Provider";
      // 
      // ExportSendProvider
      // 
      ExportSendProvider.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendProvider.DropDownStyle = ComboBoxStyle.DropDownList;
      ExportSendProvider.FormattingEnabled = true;
      ExportSendProvider.Items.AddRange(new object[] { "", "SEF", "MojeRacun" });
      ExportSendProvider.Location = new Point(376, 39);
      ExportSendProvider.Name = "ExportSendProvider";
      ExportSendProvider.Size = new Size(147, 23);
      ExportSendProvider.TabIndex = 311;
      ExportSendProvider.SelectedIndexChanged += ExportSendProvider_SelectedIndexChanged;
      // 
      // FormOwnerSourceSetup
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(535, 404);
      Controls.Add(SendToSEFPanel);
      Controls.Add(SendToMRPanel);
      Controls.Add(SendToFilePanel);
      Controls.Add(SendMainPanel);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Name = "FormOwnerSourceSetup";
      ShowIcon = false;
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Setup";
      SendToSEFPanel.ResumeLayout(false);
      SendToSEFPanel.PerformLayout();
      SendToMRPanel.ResumeLayout(false);
      SendToMRPanel.PerformLayout();
      SendToFilePanel.ResumeLayout(false);
      SendToFilePanel.PerformLayout();
      SendMainPanel.ResumeLayout(false);
      SendMainPanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Panel SendToSEFPanel;
    private Label label12;
    private TextBox ExportSendSEFApiKey;
    private Label label11;
    private TextBox ExportSendSEFURI;
    private Panel SendToMRPanel;
    private CheckBox SendMRTestDebug;
    private LinkLabel SendMRTestID;
    private LinkLabel SendMRTestFile;
    private TextBox SendMRLog;
    private Label label9;
    private TextBox ExportSendMRSoftwareID;
    private Label label8;
    private TextBox ExportSendMRCompanyID;
    private Label label7;
    private TextBox ExportSendMRPassword;
    private Label label6;
    private TextBox ExportSendMRUsername;
    private Label label5;
    private TextBox ExportSendMRURI;
    private Panel SendToFilePanel;
    private Label label16;
    private TextBox ExportSendFileLocation;
    private Panel SendMainPanel;
    private LinkLabel ExportSendManage;
    private Label label1;
    private TextBox ExportSendName;
    private Label label4;
    private ComboBox ExportSendProvider;
    private LinkLabel linkLabel1;
  }
}