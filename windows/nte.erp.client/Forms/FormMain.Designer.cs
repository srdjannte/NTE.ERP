namespace nte.erp.client
{
  partial class FormMain
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      MainMenu = new MenuStrip();
      MenuFile = new ToolStripMenuItem();
      MenuFileHomePage = new ToolStripMenuItem();
      MenuFileParty = new ToolStripMenuItem();
      MenuFileInvoiceImport = new ToolStripMenuItem();
      MenuFileInvoiceExport = new ToolStripMenuItem();
      MenuFileStatement = new ToolStripMenuItem();
      MenuFileDocument = new ToolStripMenuItem();
      MenuFileSetup = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      MenuFileConfig = new ToolStripMenuItem();
      MenuFileOwners = new ToolStripMenuItem();
      toolStripSeparator2 = new ToolStripSeparator();
      MenuFileClose = new ToolStripMenuItem();
      MenuPage = new ToolStripMenuItem();
      MenuOptions = new ToolStripMenuItem();
      MenuHelp = new ToolStripMenuItem();
      MainStrip = new ToolStrip();
      MenuStripGoHome = new ToolStripButton();
      MenuStripSeparator1 = new ToolStripSeparator();
      MenuStripFindText = new ToolStripTextBox();
      MenuStripFind = new ToolStripSplitButton();
      MenuStripWide = new ToolStripLabel();
      MenuStripConfig = new ToolStripButton();
      MainHome = new Panel();
      MainPage = new Panel();
      MainSetup = new Panel();
      MainConfig = new Panel();
      MainDetails = new Panel();
      FindPanel = new Panel();
      MenuOptionsShow = new ToolStripMenuItem();
      MainMenu.SuspendLayout();
      MainStrip.SuspendLayout();
      SuspendLayout();
      // 
      // MainMenu
      // 
      MainMenu.Items.AddRange(new ToolStripItem[] { MenuFile, MenuPage, MenuOptions, MenuHelp });
      MainMenu.Location = new Point(0, 0);
      MainMenu.Name = "MainMenu";
      MainMenu.Size = new Size(992, 24);
      MainMenu.TabIndex = 0;
      MainMenu.Text = "menuStrip1";
      // 
      // MenuFile
      // 
      MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuFileHomePage, MenuFileParty, MenuFileInvoiceImport, MenuFileInvoiceExport, MenuFileStatement, MenuFileDocument, MenuFileSetup, toolStripSeparator1, MenuFileConfig, MenuFileOwners, toolStripSeparator2, MenuFileClose });
      MenuFile.Name = "MenuFile";
      MenuFile.Size = new Size(65, 20);
      MenuFile.Text = "Program";
      // 
      // MenuFileHomePage
      // 
      MenuFileHomePage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      MenuFileHomePage.Name = "MenuFileHomePage";
      MenuFileHomePage.Size = new Size(151, 22);
      MenuFileHomePage.Text = "Početna";
      MenuFileHomePage.Click += Action_Click;
      // 
      // MenuFileParty
      // 
      MenuFileParty.Name = "MenuFileParty";
      MenuFileParty.Size = new Size(151, 22);
      MenuFileParty.Text = "Adresar";
      MenuFileParty.Click += Action_Click;
      // 
      // MenuFileInvoiceImport
      // 
      MenuFileInvoiceImport.Name = "MenuFileInvoiceImport";
      MenuFileInvoiceImport.Size = new Size(151, 22);
      MenuFileInvoiceImport.Text = "Ulazne Fakture";
      MenuFileInvoiceImport.Click += Action_Click;
      // 
      // MenuFileInvoiceExport
      // 
      MenuFileInvoiceExport.Name = "MenuFileInvoiceExport";
      MenuFileInvoiceExport.Size = new Size(151, 22);
      MenuFileInvoiceExport.Text = "Izlazne Fakture";
      MenuFileInvoiceExport.Click += Action_Click;
      // 
      // MenuFileStatement
      // 
      MenuFileStatement.Name = "MenuFileStatement";
      MenuFileStatement.Size = new Size(151, 22);
      MenuFileStatement.Text = "Izvodi";
      MenuFileStatement.Click += Action_Click;
      // 
      // MenuFileDocument
      // 
      MenuFileDocument.Name = "MenuFileDocument";
      MenuFileDocument.Size = new Size(151, 22);
      MenuFileDocument.Text = "Dokumenta";
      MenuFileDocument.Click += Action_Click;
      // 
      // MenuFileSetup
      // 
      MenuFileSetup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      MenuFileSetup.Name = "MenuFileSetup";
      MenuFileSetup.Size = new Size(151, 22);
      MenuFileSetup.Text = "Nov Nalog";
      MenuFileSetup.Visible = false;
      MenuFileSetup.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(148, 6);
      // 
      // MenuFileConfig
      // 
      MenuFileConfig.Name = "MenuFileConfig";
      MenuFileConfig.Size = new Size(151, 22);
      MenuFileConfig.Text = "Podešavanje";
      MenuFileConfig.Click += Action_Click;
      // 
      // MenuFileOwners
      // 
      MenuFileOwners.Name = "MenuFileOwners";
      MenuFileOwners.Size = new Size(151, 22);
      MenuFileOwners.Text = "Nalozi";
      MenuFileOwners.Click += Action_Click;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(148, 6);
      // 
      // MenuFileClose
      // 
      MenuFileClose.Name = "MenuFileClose";
      MenuFileClose.Size = new Size(151, 22);
      MenuFileClose.Text = "Izađi";
      MenuFileClose.Click += Action_Click;
      // 
      // MenuPage
      // 
      MenuPage.Name = "MenuPage";
      MenuPage.Size = new Size(45, 20);
      MenuPage.Text = "Page";
      MenuPage.DropDownOpening += Action_Click;
      // 
      // MenuOptions
      // 
      MenuOptions.DropDownItems.AddRange(new ToolStripItem[] { MenuOptionsShow });
      MenuOptions.Name = "MenuOptions";
      MenuOptions.Size = new Size(53, 20);
      MenuOptions.Text = "Opcije";
      // 
      // MenuHelp
      // 
      MenuHelp.Name = "MenuHelp";
      MenuHelp.Size = new Size(57, 20);
      MenuHelp.Text = "Pomoć";
      // 
      // MainStrip
      // 
      MainStrip.GripStyle = ToolStripGripStyle.Hidden;
      MainStrip.Items.AddRange(new ToolStripItem[] { MenuStripGoHome, MenuStripSeparator1, MenuStripFindText, MenuStripFind, MenuStripWide, MenuStripConfig });
      MainStrip.Location = new Point(0, 24);
      MainStrip.Name = "MainStrip";
      MainStrip.Size = new Size(992, 25);
      MainStrip.TabIndex = 1;
      MainStrip.Text = "Main Actions";
      MainStrip.Resize += Action_Resize;
      // 
      // MenuStripGoHome
      // 
      MenuStripGoHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MenuStripGoHome.Image = (Image)resources.GetObject("MenuStripGoHome.Image");
      MenuStripGoHome.ImageTransparentColor = Color.Magenta;
      MenuStripGoHome.Name = "MenuStripGoHome";
      MenuStripGoHome.Size = new Size(23, 22);
      MenuStripGoHome.Text = "Početna";
      MenuStripGoHome.ToolTipText = "Prikaži Početnu Stranu";
      MenuStripGoHome.Click += Action_Click;
      // 
      // MenuStripSeparator1
      // 
      MenuStripSeparator1.Name = "MenuStripSeparator1";
      MenuStripSeparator1.Size = new Size(6, 25);
      // 
      // MenuStripFindText
      // 
      MenuStripFindText.Name = "MenuStripFindText";
      MenuStripFindText.Size = new Size(250, 25);
      MenuStripFindText.TextChanged += Action_FindText;
      // 
      // MenuStripFind
      // 
      MenuStripFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MenuStripFind.Image = (Image)resources.GetObject("MenuStripFind.Image");
      MenuStripFind.ImageTransparentColor = Color.Magenta;
      MenuStripFind.Name = "MenuStripFind";
      MenuStripFind.Size = new Size(32, 22);
      MenuStripFind.Text = "toolStripSplitButton1";
      MenuStripFind.ButtonClick += Action_Click;
      // 
      // MenuStripWide
      // 
      MenuStripWide.AutoSize = false;
      MenuStripWide.Name = "MenuStripWide";
      MenuStripWide.Size = new Size(200, 22);
      // 
      // MenuStripConfig
      // 
      MenuStripConfig.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MenuStripConfig.Image = (Image)resources.GetObject("MenuStripConfig.Image");
      MenuStripConfig.ImageTransparentColor = Color.Magenta;
      MenuStripConfig.Name = "MenuStripConfig";
      MenuStripConfig.Size = new Size(23, 22);
      MenuStripConfig.Text = "Podešavanja";
      MenuStripConfig.ToolTipText = "Podešavanja";
      MenuStripConfig.Click += Action_Click;
      // 
      // MainHome
      // 
      MainHome.Dock = DockStyle.Fill;
      MainHome.Location = new Point(0, 49);
      MainHome.Name = "MainHome";
      MainHome.Size = new Size(992, 462);
      MainHome.TabIndex = 3;
      // 
      // MainPage
      // 
      MainPage.Dock = DockStyle.Fill;
      MainPage.Location = new Point(0, 49);
      MainPage.Name = "MainPage";
      MainPage.Size = new Size(992, 462);
      MainPage.TabIndex = 4;
      // 
      // MainSetup
      // 
      MainSetup.Dock = DockStyle.Fill;
      MainSetup.Location = new Point(0, 49);
      MainSetup.Name = "MainSetup";
      MainSetup.Size = new Size(992, 462);
      MainSetup.TabIndex = 4;
      // 
      // MainConfig
      // 
      MainConfig.Dock = DockStyle.Fill;
      MainConfig.Location = new Point(0, 49);
      MainConfig.Name = "MainConfig";
      MainConfig.Size = new Size(992, 462);
      MainConfig.TabIndex = 5;
      // 
      // MainDetails
      // 
      MainDetails.Dock = DockStyle.Fill;
      MainDetails.Location = new Point(0, 49);
      MainDetails.Name = "MainDetails";
      MainDetails.Size = new Size(992, 462);
      MainDetails.TabIndex = 6;
      // 
      // FindPanel
      // 
      FindPanel.BackColor = SystemColors.ControlDark;
      FindPanel.Location = new Point(29, 54);
      FindPanel.Name = "FindPanel";
      FindPanel.Size = new Size(414, 162);
      FindPanel.TabIndex = 0;
      FindPanel.Visible = false;
      // 
      // MenuOptionsShow
      // 
      MenuOptionsShow.Name = "MenuOptionsShow";
      MenuOptionsShow.Size = new Size(180, 22);
      MenuOptionsShow.Text = "Podesavanje";
      MenuOptionsShow.Click += Action_Click;
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(992, 511);
      Controls.Add(FindPanel);
      Controls.Add(MainDetails);
      Controls.Add(MainConfig);
      Controls.Add(MainSetup);
      Controls.Add(MainHome);
      Controls.Add(MainPage);
      Controls.Add(MainStrip);
      Controls.Add(MainMenu);
      Icon = (Icon)resources.GetObject("$this.Icon");
      MainMenuStrip = MainMenu;
      Name = "FormMain";
      Text = "NTE ERP";
      MainMenu.ResumeLayout(false);
      MainMenu.PerformLayout();
      MainStrip.ResumeLayout(false);
      MainStrip.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip MainMenu;
    private ToolStripMenuItem MenuFile;
    private ToolStripMenuItem MenuOptions;
    private ToolStrip MainStrip;
    private ToolStripButton MenuStripGoHome;
    private Panel MainHome;
    private Panel MainPage;
    private Panel MainSetup;
    private Panel MainConfig;
    private Panel MainDetails;
    private ToolStripSeparator MenuStripSeparator1;
    private ToolStripMenuItem MenuFileSetup;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem MenuFileClose;
    private ToolStripMenuItem MenuFileHomePage;
    private ToolStripLabel MenuStripWide;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem MenuFileConfig;
    private ToolStripMenuItem MenuFileOwners;
    private ToolStripMenuItem MenuFileInvoiceImport;
    private ToolStripMenuItem MenuFileInvoiceExport;
    private ToolStripMenuItem MenuFileStatement;
    private ToolStripMenuItem MenuFileDocument;
    private ToolStripMenuItem MenuHelp;
    private ToolStripTextBox MenuStripFindText;
    private ToolStripSplitButton MenuStripFind;
    private ToolStripMenuItem MenuPage;
    private ToolStripButton MenuStripConfig;
    private Panel FindPanel;
    private ToolStripMenuItem MenuFileParty;
    private ToolStripMenuItem MenuOptionsShow;
  }
}
