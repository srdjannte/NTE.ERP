namespace nte.erp.viewer
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
      MenuFileSetup = new ToolStripMenuItem();
      toolStripSeparator2 = new ToolStripSeparator();
      MenuFileClose = new ToolStripMenuItem();
      toolStripMenuItem2 = new ToolStripMenuItem();
      MainTool = new ToolStrip();
      MenuGoHome = new ToolStripButton();
      toolStripSeparator1 = new ToolStripSeparator();
      MainHome = new Panel();
      MainPage = new Panel();
      MainSetup = new Panel();
      MainConfig = new Panel();
      MainDetails = new Panel();
      MenuFilePage = new ToolStripMenuItem();
      MainMenu.SuspendLayout();
      MainTool.SuspendLayout();
      SuspendLayout();
      // 
      // MainMenu
      // 
      MainMenu.Items.AddRange(new ToolStripItem[] { MenuFile, toolStripMenuItem2 });
      MainMenu.Location = new Point(0, 0);
      MainMenu.Name = "MainMenu";
      MainMenu.Size = new Size(992, 24);
      MainMenu.TabIndex = 0;
      MainMenu.Text = "menuStrip1";
      // 
      // MenuFile
      // 
      MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuFileSetup, MenuFilePage, toolStripSeparator2, MenuFileClose });
      MenuFile.Name = "MenuFile";
      MenuFile.Size = new Size(37, 20);
      MenuFile.Text = "File";
      // 
      // MenuFileSetup
      // 
      MenuFileSetup.Name = "MenuFileSetup";
      MenuFileSetup.Size = new Size(180, 22);
      MenuFileSetup.Text = "Setup";
      MenuFileSetup.Click += Action_Click;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(177, 6);
      // 
      // MenuFileClose
      // 
      MenuFileClose.Name = "MenuFileClose";
      MenuFileClose.Size = new Size(180, 22);
      MenuFileClose.Text = "Close";
      MenuFileClose.Click += Action_Click;
      // 
      // toolStripMenuItem2
      // 
      toolStripMenuItem2.Name = "toolStripMenuItem2";
      toolStripMenuItem2.Size = new Size(125, 20);
      toolStripMenuItem2.Text = "toolStripMenuItem2";
      // 
      // MainTool
      // 
      MainTool.GripStyle = ToolStripGripStyle.Hidden;
      MainTool.Items.AddRange(new ToolStripItem[] { MenuGoHome, toolStripSeparator1 });
      MainTool.Location = new Point(0, 24);
      MainTool.Name = "MainTool";
      MainTool.Size = new Size(992, 25);
      MainTool.TabIndex = 1;
      MainTool.Text = "Main Actions";
      // 
      // MenuGoHome
      // 
      MenuGoHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MenuGoHome.Image = (Image)resources.GetObject("MenuGoHome.Image");
      MenuGoHome.ImageTransparentColor = Color.Magenta;
      MenuGoHome.Name = "MenuGoHome";
      MenuGoHome.Size = new Size(23, 22);
      MenuGoHome.Text = "Home";
      MenuGoHome.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(6, 25);
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
      // MenuFilePage
      // 
      MenuFilePage.Name = "MenuFilePage";
      MenuFilePage.Size = new Size(180, 22);
      MenuFilePage.Text = "Page";
      MenuFilePage.Click += Action_Click;
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(992, 511);
      Controls.Add(MainDetails);
      Controls.Add(MainConfig);
      Controls.Add(MainSetup);
      Controls.Add(MainHome);
      Controls.Add(MainPage);
      Controls.Add(MainTool);
      Controls.Add(MainMenu);
      MainMenuStrip = MainMenu;
      Name = "FormMain";
      Text = "NTE ERP";
      MainMenu.ResumeLayout(false);
      MainMenu.PerformLayout();
      MainTool.ResumeLayout(false);
      MainTool.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip MainMenu;
    private ToolStripMenuItem MenuFile;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStrip MainTool;
    private ToolStripButton MenuGoHome;
    private Panel MainHome;
    private Panel MainPage;
    private Panel MainSetup;
    private Panel MainConfig;
    private Panel MainDetails;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem MenuFileSetup;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem MenuFileClose;
    private ToolStripMenuItem MenuFilePage;
  }
}
