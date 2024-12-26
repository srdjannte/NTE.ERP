namespace nte.erp.client
{
  partial class ControlHome
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
      MenuPanel = new FlowLayoutPanel();
      doParty = new Button();
      doInvoiceImport = new Button();
      doInvoiceExport = new Button();
      doStatements = new Button();
      doDocuments = new Button();
      PageStatus = new StatusStrip();
      CmdPanel = new Panel();
      doConfig = new Button();
      OwnerPanel = new Panel();
      OwnerInfo = new Label();
      OwnerName = new Label();
      EmptyPanel = new Panel();
      doOwnerOpenFile = new Button();
      label1 = new Label();
      doOwnerNew = new Button();
      MenuPanel.SuspendLayout();
      CmdPanel.SuspendLayout();
      OwnerPanel.SuspendLayout();
      EmptyPanel.SuspendLayout();
      SuspendLayout();
      // 
      // MenuPanel
      // 
      MenuPanel.AutoSize = true;
      MenuPanel.Controls.Add(doParty);
      MenuPanel.Controls.Add(doInvoiceImport);
      MenuPanel.Controls.Add(doInvoiceExport);
      MenuPanel.Controls.Add(doStatements);
      MenuPanel.Controls.Add(doDocuments);
      MenuPanel.Dock = DockStyle.Top;
      MenuPanel.Location = new Point(0, 80);
      MenuPanel.Name = "MenuPanel";
      MenuPanel.Size = new Size(925, 51);
      MenuPanel.TabIndex = 2;
      // 
      // doParty
      // 
      doParty.Location = new Point(3, 3);
      doParty.Name = "doParty";
      doParty.Size = new Size(150, 45);
      doParty.TabIndex = 5;
      doParty.Text = "Adresar";
      doParty.UseVisualStyleBackColor = true;
      doParty.Click += Action_Click;
      // 
      // doInvoiceImport
      // 
      doInvoiceImport.Location = new Point(159, 3);
      doInvoiceImport.Name = "doInvoiceImport";
      doInvoiceImport.Size = new Size(150, 45);
      doInvoiceImport.TabIndex = 1;
      doInvoiceImport.Text = "Ulazne Fakture";
      doInvoiceImport.UseVisualStyleBackColor = true;
      doInvoiceImport.Click += Action_Click;
      // 
      // doInvoiceExport
      // 
      doInvoiceExport.Location = new Point(315, 3);
      doInvoiceExport.Name = "doInvoiceExport";
      doInvoiceExport.Size = new Size(150, 45);
      doInvoiceExport.TabIndex = 2;
      doInvoiceExport.Text = "Izlazne Fakture";
      doInvoiceExport.UseVisualStyleBackColor = true;
      doInvoiceExport.Click += Action_Click;
      // 
      // doStatements
      // 
      doStatements.Location = new Point(471, 3);
      doStatements.Name = "doStatements";
      doStatements.Size = new Size(150, 45);
      doStatements.TabIndex = 3;
      doStatements.Text = "Izvodi";
      doStatements.UseVisualStyleBackColor = true;
      doStatements.Click += Action_Click;
      // 
      // doDocuments
      // 
      doDocuments.Location = new Point(627, 3);
      doDocuments.Name = "doDocuments";
      doDocuments.Size = new Size(150, 45);
      doDocuments.TabIndex = 4;
      doDocuments.Text = "Dokumenta";
      doDocuments.UseVisualStyleBackColor = true;
      doDocuments.Click += Action_Click;
      // 
      // PageStatus
      // 
      PageStatus.Location = new Point(0, 470);
      PageStatus.Name = "PageStatus";
      PageStatus.Size = new Size(925, 22);
      PageStatus.TabIndex = 5;
      PageStatus.Text = "statusStrip1";
      // 
      // CmdPanel
      // 
      CmdPanel.Controls.Add(doConfig);
      CmdPanel.Dock = DockStyle.Top;
      CmdPanel.Location = new Point(0, 131);
      CmdPanel.Name = "CmdPanel";
      CmdPanel.Size = new Size(925, 66);
      CmdPanel.TabIndex = 6;
      // 
      // doConfig
      // 
      doConfig.Location = new Point(3, 23);
      doConfig.Name = "doConfig";
      doConfig.Size = new Size(109, 26);
      doConfig.TabIndex = 0;
      doConfig.Text = "Podešavanje";
      doConfig.UseVisualStyleBackColor = true;
      doConfig.Click += Action_Click;
      // 
      // OwnerPanel
      // 
      OwnerPanel.Controls.Add(OwnerInfo);
      OwnerPanel.Controls.Add(OwnerName);
      OwnerPanel.Dock = DockStyle.Top;
      OwnerPanel.Location = new Point(0, 0);
      OwnerPanel.Name = "OwnerPanel";
      OwnerPanel.Size = new Size(925, 80);
      OwnerPanel.TabIndex = 7;
      // 
      // OwnerInfo
      // 
      OwnerInfo.AutoSize = true;
      OwnerInfo.Location = new Point(5, 51);
      OwnerInfo.Name = "OwnerInfo";
      OwnerInfo.Size = new Size(10, 15);
      OwnerInfo.TabIndex = 1;
      OwnerInfo.Text = ".";
      // 
      // OwnerName
      // 
      OwnerName.AutoSize = true;
      OwnerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      OwnerName.Location = new Point(5, 16);
      OwnerName.Name = "OwnerName";
      OwnerName.Size = new Size(22, 21);
      OwnerName.TabIndex = 0;
      OwnerName.Text = "...";
      // 
      // EmptyPanel
      // 
      EmptyPanel.Controls.Add(doOwnerOpenFile);
      EmptyPanel.Controls.Add(label1);
      EmptyPanel.Controls.Add(doOwnerNew);
      EmptyPanel.Dock = DockStyle.Top;
      EmptyPanel.Location = new Point(0, 197);
      EmptyPanel.Name = "EmptyPanel";
      EmptyPanel.Size = new Size(925, 117);
      EmptyPanel.TabIndex = 8;
      // 
      // doOwnerOpenFile
      // 
      doOwnerOpenFile.Location = new Point(118, 77);
      doOwnerOpenFile.Name = "doOwnerOpenFile";
      doOwnerOpenFile.Size = new Size(107, 24);
      doOwnerOpenFile.TabIndex = 2;
      doOwnerOpenFile.Text = "Učitaj";
      doOwnerOpenFile.UseVisualStyleBackColor = true;
      doOwnerOpenFile.Click += Action_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.Location = new Point(3, 13);
      label1.Name = "label1";
      label1.Size = new Size(192, 21);
      label1.TabIndex = 1;
      label1.Text = "Nema te otvoren nalog!";
      // 
      // doOwnerNew
      // 
      doOwnerNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      doOwnerNew.Location = new Point(5, 77);
      doOwnerNew.Name = "doOwnerNew";
      doOwnerNew.Size = new Size(107, 24);
      doOwnerNew.TabIndex = 0;
      doOwnerNew.Text = "Novi Nalog";
      doOwnerNew.UseVisualStyleBackColor = true;
      doOwnerNew.Click += Action_Click;
      // 
      // ControlHome
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(EmptyPanel);
      Controls.Add(CmdPanel);
      Controls.Add(PageStatus);
      Controls.Add(MenuPanel);
      Controls.Add(OwnerPanel);
      Name = "ControlHome";
      Size = new Size(925, 492);
      MenuPanel.ResumeLayout(false);
      CmdPanel.ResumeLayout(false);
      OwnerPanel.ResumeLayout(false);
      OwnerPanel.PerformLayout();
      EmptyPanel.ResumeLayout(false);
      EmptyPanel.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private FlowLayoutPanel MenuPanel;
    private Button doInvoiceImport;
    private Button doInvoiceExport;
    private Button doStatements;
    private Button doDocuments;
    private StatusStrip PageStatus;
    private Panel CmdPanel;
    private Button doConfig;
    private Panel OwnerPanel;
    private Label OwnerInfo;
    private Label OwnerName;
    private Panel EmptyPanel;
    private Button doOwnerOpenFile;
    private Label label1;
    private Button doOwnerNew;
    private Button doParty;
  }
}
