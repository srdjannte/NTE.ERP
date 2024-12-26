namespace nte.erp.services.invoices
{
  partial class FormEditor
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
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
      MenuStrip = new MenuStrip();
      MenuFile = new ToolStripMenuItem();
      MenuFileNew = new ToolStripMenuItem();
      MenuFileNewExport = new ToolStripMenuItem();
      MenuFileNewInport = new ToolStripMenuItem();
      MenuFileOpen = new ToolStripMenuItem();
      MenuFileSave = new ToolStripMenuItem();
      MenuFileSaveAs = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      MenuClose = new ToolStripMenuItem();
      StatusBar = new StatusStrip();
      Tabs = new TabControl();
      tpHome = new TabPage();
      HomeFileNewInport = new LinkLabel();
      HomeFileRecent4 = new LinkLabel();
      HomeFileRecent3 = new LinkLabel();
      HomeFileRecent2 = new LinkLabel();
      HomeFileRecent1 = new LinkLabel();
      HomeFileRecent0 = new LinkLabel();
      HomeLabel = new Label();
      HomeRecentLabel = new Label();
      HomeFileOpen = new LinkLabel();
      HomeFileNewExport = new LinkLabel();
      tpExportGeneral = new TabPage();
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
      tpExportSource = new TabPage();
      ExportSourceMapsPanel = new Panel();
      ExportSourceMaps = new ListView();
      ColSourceMapName = new ColumnHeader();
      ColSourceMapFilter = new ColumnHeader();
      ColSourceMapQuery = new ColumnHeader();
      ExportSourceMapsMenuStrip = new ContextMenuStrip(components);
      ExportSourceMapsAddStrip = new ToolStripMenuItem();
      ExportSourceMapsOpenStrip = new ToolStripMenuItem();
      ExportSourceMapsChangeStrip = new ToolStripMenuItem();
      ExportSourceMapsRemoveStrip = new ToolStripMenuItem();
      SourceKindMsSql = new Panel();
      ExportSourceMainQueryTest = new LinkLabel();
      label3 = new Label();
      ExportSourceListQuery = new TextBox();
      ExportSourceConnectionStrTest = new LinkLabel();
      ExportSourceConnectionBtn = new Button();
      label10 = new Label();
      ExportSourceMainQuery = new TextBox();
      ExportSourceConnectionLabel = new Label();
      ExportSourceConnectionStr = new TextBox();
      SourceKindTest = new Panel();
      ExportSourceTestFileNameOpen = new Button();
      label2 = new Label();
      ExportSourceTestFileName = new TextBox();
      SourceMainPanel = new Panel();
      ExportSourceManage = new LinkLabel();
      ExportSourceKindLabel = new Label();
      ExportSourceKind = new ComboBox();
      ExportSourceNameLabel = new Label();
      ExportSourceName = new TextBox();
      tpExportShema = new TabPage();
      tpExportShemaSplit = new SplitContainer();
      ExportShemaFields = new DataGridView();
      FieldName = new DataGridViewTextBoxColumn();
      FieldSourceName = new DataGridViewTextBoxColumn();
      FieldConvertTo = new DataGridViewComboBoxColumn();
      FieldConvertError = new DataGridViewComboBoxColumn();
      FieldIfEmpty = new DataGridViewComboBoxColumn();
      FieldDefaultValue = new DataGridViewTextBoxColumn();
      ExportShemaFieldsMenu = new ContextMenuStrip(components);
      ExportShemaMainTemplate = new RichTextBox();
      ExportShemaMainTemplateMenuStrip = new ContextMenuStrip(components);
      ExportShemaTemplatesMainCopyAll = new ToolStripMenuItem();
      ExportShemaTemplatesMainPasteAll = new ToolStripMenuItem();
      toolStripSeparator5 = new ToolStripSeparator();
      ExportShemaTemplatesMainTest = new ToolStripMenuItem();
      ExportShemaTemplatesMainViewXML = new ToolStripMenuItem();
      toolStripSeparator4 = new ToolStripSeparator();
      ExportShemaTemplatesList = new ToolStripMenuItem();
      ExportShemaTemplatesMainDefault = new ToolStripMenuItem();
      ExportShemaTemplatesItemsDefault = new ToolStripMenuItem();
      ExportShemaTemplatesTaxesDefault = new ToolStripMenuItem();
      ExportShemaTemplatesMainLoad = new ToolStripMenuItem();
      panel1 = new Panel();
      ExportShemaStrip = new ToolStrip();
      ExportShemaTable = new ToolStripDropDownButton();
      ExportShemaMasterTable = new ToolStripMenuItem();
      toolStripSeparator8 = new ToolStripSeparator();
      toolStripSeparator2 = new ToolStripSeparator();
      ExportShemaProccessor = new ToolStripDropDownButton();
      ExportShemaProccessorDynamicFields = new ToolStripMenuItem();
      toolStripSeparator3 = new ToolStripSeparator();
      ExportShemaProccessorDynamic = new ToolStripMenuItem();
      ExportShemaProccessorFields = new ToolStripMenuItem();
      ExportShemaRefresh = new ToolStripButton();
      ExportShemaFieldAdd = new ToolStripButton();
      ExportShemaFieldDelete = new ToolStripSplitButton();
      ExportShemaFieldDeleteAll = new ToolStripMenuItem();
      toolStripSeparator6 = new ToolStripSeparator();
      ExportShemaTest = new ToolStripSplitButton();
      ExportShemaTestRefreshData = new ToolStripMenuItem();
      tpExportSend = new TabPage();
      SendToSEFPanel = new Panel();
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
      tpImportGeneral = new TabPage();
      tpImportSource = new TabPage();
      tpImportTarget = new TabPage();
      tpImportResult = new TabPage();
      openFileDialog = new OpenFileDialog();
      saveFileDialog = new SaveFileDialog();
      openTemplateDialog = new OpenFileDialog();
      SendMRTestWorker = new System.ComponentModel.BackgroundWorker();
      MenuStrip.SuspendLayout();
      Tabs.SuspendLayout();
      tpHome.SuspendLayout();
      tpExportGeneral.SuspendLayout();
      tpExportSource.SuspendLayout();
      ExportSourceMapsPanel.SuspendLayout();
      ExportSourceMapsMenuStrip.SuspendLayout();
      SourceKindMsSql.SuspendLayout();
      SourceKindTest.SuspendLayout();
      SourceMainPanel.SuspendLayout();
      tpExportShema.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)tpExportShemaSplit).BeginInit();
      tpExportShemaSplit.Panel1.SuspendLayout();
      tpExportShemaSplit.Panel2.SuspendLayout();
      tpExportShemaSplit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ExportShemaFields).BeginInit();
      ExportShemaMainTemplateMenuStrip.SuspendLayout();
      ExportShemaStrip.SuspendLayout();
      tpExportSend.SuspendLayout();
      SendToSEFPanel.SuspendLayout();
      SendToMRPanel.SuspendLayout();
      SendToFilePanel.SuspendLayout();
      SendMainPanel.SuspendLayout();
      tpImportGeneral.SuspendLayout();
      SuspendLayout();
      // 
      // MenuStrip
      // 
      MenuStrip.Items.AddRange(new ToolStripItem[] { MenuFile });
      MenuStrip.Location = new Point(0, 0);
      MenuStrip.Name = "MenuStrip";
      MenuStrip.Size = new Size(912, 24);
      MenuStrip.TabIndex = 2;
      MenuStrip.Text = "menuStrip1";
      // 
      // MenuFile
      // 
      MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuFileNew, MenuFileOpen, MenuFileSave, MenuFileSaveAs, toolStripSeparator1, MenuClose });
      MenuFile.Name = "MenuFile";
      MenuFile.Size = new Size(37, 20);
      MenuFile.Text = "File";
      MenuFile.DropDownOpening += Action_Click;
      // 
      // MenuFileNew
      // 
      MenuFileNew.DropDownItems.AddRange(new ToolStripItem[] { MenuFileNewExport, MenuFileNewInport });
      MenuFileNew.Name = "MenuFileNew";
      MenuFileNew.Size = new Size(155, 22);
      MenuFileNew.Text = "New";
      // 
      // MenuFileNewExport
      // 
      MenuFileNewExport.Name = "MenuFileNewExport";
      MenuFileNewExport.Size = new Size(107, 22);
      MenuFileNewExport.Text = "Export";
      MenuFileNewExport.Click += Action_Click;
      // 
      // MenuFileNewInport
      // 
      MenuFileNewInport.Name = "MenuFileNewInport";
      MenuFileNewInport.Size = new Size(107, 22);
      MenuFileNewInport.Text = "Inport";
      MenuFileNewInport.Click += Action_Click;
      // 
      // MenuFileOpen
      // 
      MenuFileOpen.Name = "MenuFileOpen";
      MenuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
      MenuFileOpen.Size = new Size(155, 22);
      MenuFileOpen.Text = "Open...";
      MenuFileOpen.Click += Action_Click;
      // 
      // MenuFileSave
      // 
      MenuFileSave.Name = "MenuFileSave";
      MenuFileSave.ShortcutKeys = Keys.Control | Keys.S;
      MenuFileSave.Size = new Size(155, 22);
      MenuFileSave.Text = "Save";
      MenuFileSave.Click += Action_Click;
      // 
      // MenuFileSaveAs
      // 
      MenuFileSaveAs.Name = "MenuFileSaveAs";
      MenuFileSaveAs.Size = new Size(155, 22);
      MenuFileSaveAs.Text = "Save As...";
      MenuFileSaveAs.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(152, 6);
      // 
      // MenuClose
      // 
      MenuClose.Name = "MenuClose";
      MenuClose.ShortcutKeys = Keys.Alt | Keys.F4;
      MenuClose.Size = new Size(155, 22);
      MenuClose.Text = "Close";
      MenuClose.Click += Action_Click;
      // 
      // StatusBar
      // 
      StatusBar.Location = new Point(0, 674);
      StatusBar.Name = "StatusBar";
      StatusBar.Size = new Size(912, 22);
      StatusBar.TabIndex = 3;
      StatusBar.Text = "statusStrip1";
      // 
      // Tabs
      // 
      Tabs.Controls.Add(tpHome);
      Tabs.Controls.Add(tpExportGeneral);
      Tabs.Controls.Add(tpExportSource);
      Tabs.Controls.Add(tpExportShema);
      Tabs.Controls.Add(tpExportSend);
      Tabs.Controls.Add(tpImportGeneral);
      Tabs.Controls.Add(tpImportSource);
      Tabs.Controls.Add(tpImportTarget);
      Tabs.Controls.Add(tpImportResult);
      Tabs.Dock = DockStyle.Fill;
      Tabs.Location = new Point(0, 24);
      Tabs.Name = "Tabs";
      Tabs.SelectedIndex = 0;
      Tabs.Size = new Size(912, 650);
      Tabs.TabIndex = 4;
      Tabs.Selecting += Tabs_Selecting;
      // 
      // tpHome
      // 
      tpHome.AutoScroll = true;
      tpHome.Controls.Add(HomeFileNewInport);
      tpHome.Controls.Add(HomeFileRecent4);
      tpHome.Controls.Add(HomeFileRecent3);
      tpHome.Controls.Add(HomeFileRecent2);
      tpHome.Controls.Add(HomeFileRecent1);
      tpHome.Controls.Add(HomeFileRecent0);
      tpHome.Controls.Add(HomeLabel);
      tpHome.Controls.Add(HomeRecentLabel);
      tpHome.Controls.Add(HomeFileOpen);
      tpHome.Controls.Add(HomeFileNewExport);
      tpHome.Location = new Point(4, 24);
      tpHome.Name = "tpHome";
      tpHome.Padding = new Padding(3);
      tpHome.Size = new Size(904, 622);
      tpHome.TabIndex = 0;
      tpHome.Text = "Home";
      tpHome.UseVisualStyleBackColor = true;
      // 
      // HomeFileNewInport
      // 
      HomeFileNewInport.AutoSize = true;
      HomeFileNewInport.Font = new Font("Segoe UI", 9F);
      HomeFileNewInport.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileNewInport.Location = new Point(21, 91);
      HomeFileNewInport.Name = "HomeFileNewInport";
      HomeFileNewInport.Size = new Size(70, 15);
      HomeFileNewInport.TabIndex = 9;
      HomeFileNewInport.TabStop = true;
      HomeFileNewInport.Text = "New Import";
      HomeFileNewInport.Click += Action_Click;
      // 
      // HomeFileRecent4
      // 
      HomeFileRecent4.AutoSize = true;
      HomeFileRecent4.Font = new Font("Segoe UI", 9F);
      HomeFileRecent4.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileRecent4.Location = new Point(21, 266);
      HomeFileRecent4.Name = "HomeFileRecent4";
      HomeFileRecent4.Size = new Size(0, 15);
      HomeFileRecent4.TabIndex = 8;
      HomeFileRecent4.Click += Action_ClickRecent;
      // 
      // HomeFileRecent3
      // 
      HomeFileRecent3.AutoSize = true;
      HomeFileRecent3.Font = new Font("Segoe UI", 9F);
      HomeFileRecent3.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileRecent3.Location = new Point(21, 244);
      HomeFileRecent3.Name = "HomeFileRecent3";
      HomeFileRecent3.Size = new Size(0, 15);
      HomeFileRecent3.TabIndex = 7;
      HomeFileRecent3.Click += Action_ClickRecent;
      // 
      // HomeFileRecent2
      // 
      HomeFileRecent2.AutoSize = true;
      HomeFileRecent2.Font = new Font("Segoe UI", 9F);
      HomeFileRecent2.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileRecent2.Location = new Point(21, 222);
      HomeFileRecent2.Name = "HomeFileRecent2";
      HomeFileRecent2.Size = new Size(0, 15);
      HomeFileRecent2.TabIndex = 6;
      HomeFileRecent2.Click += Action_ClickRecent;
      // 
      // HomeFileRecent1
      // 
      HomeFileRecent1.AutoSize = true;
      HomeFileRecent1.Font = new Font("Segoe UI", 9F);
      HomeFileRecent1.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileRecent1.Location = new Point(21, 200);
      HomeFileRecent1.Name = "HomeFileRecent1";
      HomeFileRecent1.Size = new Size(0, 15);
      HomeFileRecent1.TabIndex = 5;
      HomeFileRecent1.Click += Action_ClickRecent;
      // 
      // HomeFileRecent0
      // 
      HomeFileRecent0.AutoSize = true;
      HomeFileRecent0.Font = new Font("Segoe UI", 9F);
      HomeFileRecent0.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileRecent0.Location = new Point(21, 178);
      HomeFileRecent0.Name = "HomeFileRecent0";
      HomeFileRecent0.Size = new Size(0, 15);
      HomeFileRecent0.TabIndex = 4;
      HomeFileRecent0.Click += Action_ClickRecent;
      // 
      // HomeLabel
      // 
      HomeLabel.AutoSize = true;
      HomeLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
      HomeLabel.Location = new Point(17, 18);
      HomeLabel.Name = "HomeLabel";
      HomeLabel.Size = new Size(185, 30);
      HomeLabel.TabIndex = 3;
      HomeLabel.Text = "NTE Računi Editor";
      // 
      // HomeRecentLabel
      // 
      HomeRecentLabel.AutoSize = true;
      HomeRecentLabel.Location = new Point(21, 154);
      HomeRecentLabel.Name = "HomeRecentLabel";
      HomeRecentLabel.Size = new Size(43, 15);
      HomeRecentLabel.TabIndex = 2;
      HomeRecentLabel.Text = "Recent";
      // 
      // HomeFileOpen
      // 
      HomeFileOpen.AutoSize = true;
      HomeFileOpen.Font = new Font("Segoe UI", 9F);
      HomeFileOpen.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileOpen.Location = new Point(21, 116);
      HomeFileOpen.Name = "HomeFileOpen";
      HomeFileOpen.Size = new Size(45, 15);
      HomeFileOpen.TabIndex = 1;
      HomeFileOpen.TabStop = true;
      HomeFileOpen.Text = "Open...";
      HomeFileOpen.Click += Action_Click;
      // 
      // HomeFileNewExport
      // 
      HomeFileNewExport.AutoSize = true;
      HomeFileNewExport.Font = new Font("Segoe UI", 9F);
      HomeFileNewExport.LinkBehavior = LinkBehavior.HoverUnderline;
      HomeFileNewExport.Location = new Point(21, 66);
      HomeFileNewExport.Name = "HomeFileNewExport";
      HomeFileNewExport.Size = new Size(67, 15);
      HomeFileNewExport.TabIndex = 0;
      HomeFileNewExport.TabStop = true;
      HomeFileNewExport.Text = "New Export";
      HomeFileNewExport.Click += Action_Click;
      // 
      // tpExportGeneral
      // 
      tpExportGeneral.AutoScroll = true;
      tpExportGeneral.Controls.Add(ExportLogDebug);
      tpExportGeneral.Controls.Add(ExportFileNameLabel);
      tpExportGeneral.Controls.Add(ExportFileName);
      tpExportGeneral.Controls.Add(ExportLogTo);
      tpExportGeneral.Controls.Add(ExportKindLabel);
      tpExportGeneral.Controls.Add(ExportKind);
      tpExportGeneral.Controls.Add(ExportChangeTextLabel);
      tpExportGeneral.Controls.Add(ExportChangeText);
      tpExportGeneral.Controls.Add(ExportCreatedTextLabel);
      tpExportGeneral.Controls.Add(ExportCreatedText);
      tpExportGeneral.Controls.Add(ExportDescriptionLabel);
      tpExportGeneral.Controls.Add(ExportDescription);
      tpExportGeneral.Controls.Add(ExportNameLabel);
      tpExportGeneral.Controls.Add(ExportName);
      tpExportGeneral.Location = new Point(4, 24);
      tpExportGeneral.Name = "tpExportGeneral";
      tpExportGeneral.Padding = new Padding(3);
      tpExportGeneral.Size = new Size(904, 622);
      tpExportGeneral.TabIndex = 1;
      tpExportGeneral.Text = "General";
      tpExportGeneral.UseVisualStyleBackColor = true;
      // 
      // ExportLogDebug
      // 
      ExportLogDebug.AutoSize = true;
      ExportLogDebug.Location = new Point(60, 168);
      ExportLogDebug.Name = "ExportLogDebug";
      ExportLogDebug.Size = new Size(61, 19);
      ExportLogDebug.TabIndex = 13;
      ExportLogDebug.Text = "Debug";
      ExportLogDebug.UseVisualStyleBackColor = true;
      ExportLogDebug.Click += Action_Click;
      // 
      // ExportFileNameLabel
      // 
      ExportFileNameLabel.AutoSize = true;
      ExportFileNameLabel.Location = new Point(8, 248);
      ExportFileNameLabel.Name = "ExportFileNameLabel";
      ExportFileNameLabel.Size = new Size(60, 15);
      ExportFileNameLabel.TabIndex = 12;
      ExportFileNameLabel.Text = "File Name";
      // 
      // ExportFileName
      // 
      ExportFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportFileName.Font = new Font("Segoe UI", 9F);
      ExportFileName.Location = new Point(8, 267);
      ExportFileName.Name = "ExportFileName";
      ExportFileName.ReadOnly = true;
      ExportFileName.Size = new Size(888, 23);
      ExportFileName.TabIndex = 11;
      // 
      // ExportLogTo
      // 
      ExportLogTo.AutoSize = true;
      ExportLogTo.Location = new Point(8, 168);
      ExportLogTo.Name = "ExportLogTo";
      ExportLogTo.Size = new Size(46, 19);
      ExportLogTo.TabIndex = 10;
      ExportLogTo.Text = "Log";
      ExportLogTo.UseVisualStyleBackColor = true;
      ExportLogTo.Click += Action_Click;
      // 
      // ExportKindLabel
      // 
      ExportKindLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportKindLabel.AutoSize = true;
      ExportKindLabel.Location = new Point(753, 21);
      ExportKindLabel.Name = "ExportKindLabel";
      ExportKindLabel.Size = new Size(31, 15);
      ExportKindLabel.TabIndex = 9;
      ExportKindLabel.Text = "Kind";
      // 
      // ExportKind
      // 
      ExportKind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportKind.DropDownStyle = ComboBoxStyle.DropDownList;
      ExportKind.Enabled = false;
      ExportKind.FormattingEnabled = true;
      ExportKind.Items.AddRange(new object[] { "Export", "Import" });
      ExportKind.Location = new Point(753, 40);
      ExportKind.Name = "ExportKind";
      ExportKind.Size = new Size(143, 23);
      ExportKind.TabIndex = 8;
      ExportKind.TabStop = false;
      ExportKind.TextChanged += ExportData_Changed;
      // 
      // ExportChangeTextLabel
      // 
      ExportChangeTextLabel.AutoSize = true;
      ExportChangeTextLabel.Location = new Point(8, 196);
      ExportChangeTextLabel.Name = "ExportChangeTextLabel";
      ExportChangeTextLabel.Size = new Size(55, 15);
      ExportChangeTextLabel.TabIndex = 7;
      ExportChangeTextLabel.Text = "Changed";
      // 
      // ExportChangeText
      // 
      ExportChangeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportChangeText.Location = new Point(8, 215);
      ExportChangeText.Name = "ExportChangeText";
      ExportChangeText.ReadOnly = true;
      ExportChangeText.Size = new Size(664, 23);
      ExportChangeText.TabIndex = 6;
      ExportChangeText.TabStop = false;
      // 
      // ExportCreatedTextLabel
      // 
      ExportCreatedTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportCreatedTextLabel.AutoSize = true;
      ExportCreatedTextLabel.Location = new Point(680, 196);
      ExportCreatedTextLabel.Name = "ExportCreatedTextLabel";
      ExportCreatedTextLabel.Size = new Size(48, 15);
      ExportCreatedTextLabel.TabIndex = 5;
      ExportCreatedTextLabel.Text = "Created";
      // 
      // ExportCreatedText
      // 
      ExportCreatedText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportCreatedText.Location = new Point(678, 215);
      ExportCreatedText.Name = "ExportCreatedText";
      ExportCreatedText.ReadOnly = true;
      ExportCreatedText.Size = new Size(218, 23);
      ExportCreatedText.TabIndex = 4;
      ExportCreatedText.TabStop = false;
      // 
      // ExportDescriptionLabel
      // 
      ExportDescriptionLabel.AutoSize = true;
      ExportDescriptionLabel.Location = new Point(8, 77);
      ExportDescriptionLabel.Name = "ExportDescriptionLabel";
      ExportDescriptionLabel.Size = new Size(67, 15);
      ExportDescriptionLabel.TabIndex = 3;
      ExportDescriptionLabel.Text = "Description";
      // 
      // ExportDescription
      // 
      ExportDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportDescription.Location = new Point(8, 95);
      ExportDescription.Multiline = true;
      ExportDescription.Name = "ExportDescription";
      ExportDescription.Size = new Size(888, 67);
      ExportDescription.TabIndex = 1;
      ExportDescription.TextChanged += ExportData_Changed;
      // 
      // ExportNameLabel
      // 
      ExportNameLabel.AutoSize = true;
      ExportNameLabel.Location = new Point(8, 21);
      ExportNameLabel.Name = "ExportNameLabel";
      ExportNameLabel.Size = new Size(39, 15);
      ExportNameLabel.TabIndex = 1;
      ExportNameLabel.Text = "Name";
      // 
      // ExportName
      // 
      ExportName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      ExportName.Location = new Point(8, 40);
      ExportName.Name = "ExportName";
      ExportName.Size = new Size(739, 23);
      ExportName.TabIndex = 0;
      ExportName.TextChanged += ExportData_Changed;
      // 
      // tpExportSource
      // 
      tpExportSource.AutoScroll = true;
      tpExportSource.Controls.Add(ExportSourceMapsPanel);
      tpExportSource.Controls.Add(SourceKindMsSql);
      tpExportSource.Controls.Add(SourceKindTest);
      tpExportSource.Controls.Add(SourceMainPanel);
      tpExportSource.Location = new Point(4, 24);
      tpExportSource.Name = "tpExportSource";
      tpExportSource.Size = new Size(904, 622);
      tpExportSource.TabIndex = 2;
      tpExportSource.Text = "Source";
      tpExportSource.UseVisualStyleBackColor = true;
      // 
      // ExportSourceMapsPanel
      // 
      ExportSourceMapsPanel.Controls.Add(ExportSourceMaps);
      ExportSourceMapsPanel.Dock = DockStyle.Top;
      ExportSourceMapsPanel.Location = new Point(0, 388);
      ExportSourceMapsPanel.Name = "ExportSourceMapsPanel";
      ExportSourceMapsPanel.Size = new Size(904, 168);
      ExportSourceMapsPanel.TabIndex = 312;
      // 
      // ExportSourceMaps
      // 
      ExportSourceMaps.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSourceMaps.BorderStyle = BorderStyle.None;
      ExportSourceMaps.Columns.AddRange(new ColumnHeader[] { ColSourceMapName, ColSourceMapFilter, ColSourceMapQuery });
      ExportSourceMaps.ContextMenuStrip = ExportSourceMapsMenuStrip;
      ExportSourceMaps.FullRowSelect = true;
      ExportSourceMaps.Location = new Point(8, 7);
      ExportSourceMaps.Name = "ExportSourceMaps";
      ExportSourceMaps.Size = new Size(888, 127);
      ExportSourceMaps.TabIndex = 323;
      ExportSourceMaps.UseCompatibleStateImageBehavior = false;
      ExportSourceMaps.View = View.Details;
      ExportSourceMaps.DoubleClick += Action_DoubleClick;
      // 
      // ColSourceMapName
      // 
      ColSourceMapName.Text = "Transform Name";
      ColSourceMapName.Width = 160;
      // 
      // ColSourceMapFilter
      // 
      ColSourceMapFilter.Text = "Filter";
      ColSourceMapFilter.Width = 150;
      // 
      // ColSourceMapQuery
      // 
      ColSourceMapQuery.Text = "Source";
      ColSourceMapQuery.Width = 260;
      // 
      // ExportSourceMapsMenuStrip
      // 
      ExportSourceMapsMenuStrip.Items.AddRange(new ToolStripItem[] { ExportSourceMapsAddStrip, ExportSourceMapsOpenStrip, ExportSourceMapsChangeStrip, ExportSourceMapsRemoveStrip });
      ExportSourceMapsMenuStrip.Name = "ExportSourceMapsMenuStrip";
      ExportSourceMapsMenuStrip.Size = new Size(169, 92);
      ExportSourceMapsMenuStrip.Opening += ExportSourceMapsMenuStrip_Opening;
      // 
      // ExportSourceMapsAddStrip
      // 
      ExportSourceMapsAddStrip.Name = "ExportSourceMapsAddStrip";
      ExportSourceMapsAddStrip.ShortcutKeys = Keys.Insert;
      ExportSourceMapsAddStrip.Size = new Size(168, 22);
      ExportSourceMapsAddStrip.Text = "Add Map...";
      ExportSourceMapsAddStrip.Click += Action_Click;
      // 
      // ExportSourceMapsOpenStrip
      // 
      ExportSourceMapsOpenStrip.Name = "ExportSourceMapsOpenStrip";
      ExportSourceMapsOpenStrip.Size = new Size(168, 22);
      ExportSourceMapsOpenStrip.Text = "Open";
      ExportSourceMapsOpenStrip.Click += Action_Click;
      // 
      // ExportSourceMapsChangeStrip
      // 
      ExportSourceMapsChangeStrip.Name = "ExportSourceMapsChangeStrip";
      ExportSourceMapsChangeStrip.ShortcutKeys = Keys.F2;
      ExportSourceMapsChangeStrip.Size = new Size(168, 22);
      ExportSourceMapsChangeStrip.Text = "Change";
      ExportSourceMapsChangeStrip.Click += Action_Click;
      // 
      // ExportSourceMapsRemoveStrip
      // 
      ExportSourceMapsRemoveStrip.Name = "ExportSourceMapsRemoveStrip";
      ExportSourceMapsRemoveStrip.ShortcutKeys = Keys.Delete;
      ExportSourceMapsRemoveStrip.Size = new Size(168, 22);
      ExportSourceMapsRemoveStrip.Text = "Remove";
      ExportSourceMapsRemoveStrip.Click += Action_Click;
      // 
      // SourceKindMsSql
      // 
      SourceKindMsSql.Controls.Add(ExportSourceMainQueryTest);
      SourceKindMsSql.Controls.Add(label3);
      SourceKindMsSql.Controls.Add(ExportSourceListQuery);
      SourceKindMsSql.Controls.Add(ExportSourceConnectionStrTest);
      SourceKindMsSql.Controls.Add(ExportSourceConnectionBtn);
      SourceKindMsSql.Controls.Add(label10);
      SourceKindMsSql.Controls.Add(ExportSourceMainQuery);
      SourceKindMsSql.Controls.Add(ExportSourceConnectionLabel);
      SourceKindMsSql.Controls.Add(ExportSourceConnectionStr);
      SourceKindMsSql.Dock = DockStyle.Top;
      SourceKindMsSql.Location = new Point(0, 137);
      SourceKindMsSql.Name = "SourceKindMsSql";
      SourceKindMsSql.Size = new Size(904, 251);
      SourceKindMsSql.TabIndex = 310;
      // 
      // ExportSourceMainQueryTest
      // 
      ExportSourceMainQueryTest.AutoSize = true;
      ExportSourceMainQueryTest.LinkBehavior = LinkBehavior.HoverUnderline;
      ExportSourceMainQueryTest.Location = new Point(8, 223);
      ExportSourceMainQueryTest.Name = "ExportSourceMainQueryTest";
      ExportSourceMainQueryTest.Size = new Size(129, 15);
      ExportSourceMainQueryTest.TabIndex = 319;
      ExportSourceMainQueryTest.TabStop = true;
      ExportSourceMainQueryTest.Text = "Test Query && Load Test";
      ExportSourceMainQueryTest.Click += Action_Click;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(8, 77);
      label3.Name = "label3";
      label3.Size = new Size(79, 15);
      label3.TabIndex = 314;
      label3.Text = "Service Query";
      // 
      // ExportSourceListQuery
      // 
      ExportSourceListQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSourceListQuery.Location = new Point(8, 96);
      ExportSourceListQuery.Multiline = true;
      ExportSourceListQuery.Name = "ExportSourceListQuery";
      ExportSourceListQuery.Size = new Size(888, 42);
      ExportSourceListQuery.TabIndex = 317;
      ExportSourceListQuery.WordWrap = false;
      ExportSourceListQuery.TextChanged += ExportData_Changed;
      // 
      // ExportSourceConnectionStrTest
      // 
      ExportSourceConnectionStrTest.AutoSize = true;
      ExportSourceConnectionStrTest.LinkBehavior = LinkBehavior.HoverUnderline;
      ExportSourceConnectionStrTest.Location = new Point(8, 55);
      ExportSourceConnectionStrTest.Name = "ExportSourceConnectionStrTest";
      ExportSourceConnectionStrTest.Size = new Size(90, 15);
      ExportSourceConnectionStrTest.TabIndex = 313;
      ExportSourceConnectionStrTest.TabStop = true;
      ExportSourceConnectionStrTest.Text = "Test Connecton";
      ExportSourceConnectionStrTest.Click += Action_Click;
      // 
      // ExportSourceConnectionBtn
      // 
      ExportSourceConnectionBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSourceConnectionBtn.Location = new Point(863, 28);
      ExportSourceConnectionBtn.Name = "ExportSourceConnectionBtn";
      ExportSourceConnectionBtn.Size = new Size(33, 25);
      ExportSourceConnectionBtn.TabIndex = 316;
      ExportSourceConnectionBtn.Text = "...";
      ExportSourceConnectionBtn.UseVisualStyleBackColor = true;
      ExportSourceConnectionBtn.Click += Action_Click;
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.Location = new Point(8, 145);
      label10.Name = "label10";
      label10.Size = new Size(78, 15);
      label10.TabIndex = 310;
      label10.Text = "Master Query";
      // 
      // ExportSourceMainQuery
      // 
      ExportSourceMainQuery.AcceptsReturn = true;
      ExportSourceMainQuery.AcceptsTab = true;
      ExportSourceMainQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSourceMainQuery.Location = new Point(8, 164);
      ExportSourceMainQuery.Multiline = true;
      ExportSourceMainQuery.Name = "ExportSourceMainQuery";
      ExportSourceMainQuery.Size = new Size(888, 56);
      ExportSourceMainQuery.TabIndex = 318;
      ExportSourceMainQuery.WordWrap = false;
      ExportSourceMainQuery.TextChanged += ExportData_Changed;
      // 
      // ExportSourceConnectionLabel
      // 
      ExportSourceConnectionLabel.AutoSize = true;
      ExportSourceConnectionLabel.Location = new Point(8, 10);
      ExportSourceConnectionLabel.Name = "ExportSourceConnectionLabel";
      ExportSourceConnectionLabel.Size = new Size(103, 15);
      ExportSourceConnectionLabel.TabIndex = 309;
      ExportSourceConnectionLabel.Text = "Connection String";
      // 
      // ExportSourceConnectionStr
      // 
      ExportSourceConnectionStr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSourceConnectionStr.Location = new Point(8, 29);
      ExportSourceConnectionStr.Name = "ExportSourceConnectionStr";
      ExportSourceConnectionStr.Size = new Size(849, 23);
      ExportSourceConnectionStr.TabIndex = 315;
      ExportSourceConnectionStr.TextChanged += ExportData_Changed;
      // 
      // SourceKindTest
      // 
      SourceKindTest.Controls.Add(ExportSourceTestFileNameOpen);
      SourceKindTest.Controls.Add(label2);
      SourceKindTest.Controls.Add(ExportSourceTestFileName);
      SourceKindTest.Dock = DockStyle.Top;
      SourceKindTest.Location = new Point(0, 72);
      SourceKindTest.Name = "SourceKindTest";
      SourceKindTest.Size = new Size(904, 65);
      SourceKindTest.TabIndex = 311;
      // 
      // ExportSourceTestFileNameOpen
      // 
      ExportSourceTestFileNameOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSourceTestFileNameOpen.Location = new Point(863, 23);
      ExportSourceTestFileNameOpen.Name = "ExportSourceTestFileNameOpen";
      ExportSourceTestFileNameOpen.Size = new Size(33, 25);
      ExportSourceTestFileNameOpen.TabIndex = 317;
      ExportSourceTestFileNameOpen.Text = "...";
      ExportSourceTestFileNameOpen.UseVisualStyleBackColor = true;
      ExportSourceTestFileNameOpen.Click += Action_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(8, 6);
      label2.Name = "label2";
      label2.Size = new Size(98, 15);
      label2.TabIndex = 26;
      label2.Text = "Test File Location";
      // 
      // ExportSourceTestFileName
      // 
      ExportSourceTestFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSourceTestFileName.Font = new Font("Segoe UI", 9F);
      ExportSourceTestFileName.Location = new Point(8, 24);
      ExportSourceTestFileName.Name = "ExportSourceTestFileName";
      ExportSourceTestFileName.Size = new Size(849, 23);
      ExportSourceTestFileName.TabIndex = 25;
      ExportSourceTestFileName.TextChanged += ExportData_Changed;
      // 
      // SourceMainPanel
      // 
      SourceMainPanel.Controls.Add(ExportSourceManage);
      SourceMainPanel.Controls.Add(ExportSourceKindLabel);
      SourceMainPanel.Controls.Add(ExportSourceKind);
      SourceMainPanel.Controls.Add(ExportSourceNameLabel);
      SourceMainPanel.Controls.Add(ExportSourceName);
      SourceMainPanel.Dock = DockStyle.Top;
      SourceMainPanel.Location = new Point(0, 0);
      SourceMainPanel.Name = "SourceMainPanel";
      SourceMainPanel.Size = new Size(904, 72);
      SourceMainPanel.TabIndex = 313;
      // 
      // ExportSourceManage
      // 
      ExportSourceManage.AutoSize = true;
      ExportSourceManage.LinkBehavior = LinkBehavior.HoverUnderline;
      ExportSourceManage.Location = new Point(53, 21);
      ExportSourceManage.Name = "ExportSourceManage";
      ExportSourceManage.Size = new Size(58, 15);
      ExportSourceManage.TabIndex = 314;
      ExportSourceManage.TabStop = true;
      ExportSourceManage.Text = "(manage)";
      ExportSourceManage.Click += Action_Click;
      // 
      // ExportSourceKindLabel
      // 
      ExportSourceKindLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSourceKindLabel.AutoSize = true;
      ExportSourceKindLabel.Location = new Point(753, 21);
      ExportSourceKindLabel.Name = "ExportSourceKindLabel";
      ExportSourceKindLabel.Size = new Size(31, 15);
      ExportSourceKindLabel.TabIndex = 311;
      ExportSourceKindLabel.Text = "Kind";
      // 
      // ExportSourceKind
      // 
      ExportSourceKind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSourceKind.DropDownStyle = ComboBoxStyle.DropDownList;
      ExportSourceKind.FormattingEnabled = true;
      ExportSourceKind.Items.AddRange(new object[] { "Test", "MsSql", "MySql", "ODBC", "File", "WebService", "Assembly" });
      ExportSourceKind.Location = new Point(753, 40);
      ExportSourceKind.Name = "ExportSourceKind";
      ExportSourceKind.Size = new Size(143, 23);
      ExportSourceKind.TabIndex = 313;
      ExportSourceKind.SelectedIndexChanged += ExportSourceKind_SelectedIndexChanged;
      ExportSourceKind.TextChanged += ExportData_Changed;
      // 
      // ExportSourceNameLabel
      // 
      ExportSourceNameLabel.AutoSize = true;
      ExportSourceNameLabel.Location = new Point(8, 21);
      ExportSourceNameLabel.Name = "ExportSourceNameLabel";
      ExportSourceNameLabel.Size = new Size(39, 15);
      ExportSourceNameLabel.TabIndex = 310;
      ExportSourceNameLabel.Text = "Name";
      // 
      // ExportSourceName
      // 
      ExportSourceName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ExportSourceName.Location = new Point(8, 40);
      ExportSourceName.Name = "ExportSourceName";
      ExportSourceName.Size = new Size(739, 23);
      ExportSourceName.TabIndex = 312;
      ExportSourceName.TextChanged += ExportData_Changed;
      // 
      // tpExportShema
      // 
      tpExportShema.Controls.Add(tpExportShemaSplit);
      tpExportShema.Controls.Add(ExportShemaStrip);
      tpExportShema.Location = new Point(4, 24);
      tpExportShema.Name = "tpExportShema";
      tpExportShema.Size = new Size(904, 622);
      tpExportShema.TabIndex = 3;
      tpExportShema.Text = "Transform";
      tpExportShema.UseVisualStyleBackColor = true;
      // 
      // tpExportShemaSplit
      // 
      tpExportShemaSplit.Dock = DockStyle.Fill;
      tpExportShemaSplit.FixedPanel = FixedPanel.Panel1;
      tpExportShemaSplit.Location = new Point(0, 25);
      tpExportShemaSplit.Name = "tpExportShemaSplit";
      // 
      // tpExportShemaSplit.Panel1
      // 
      tpExportShemaSplit.Panel1.Controls.Add(ExportShemaFields);
      // 
      // tpExportShemaSplit.Panel2
      // 
      tpExportShemaSplit.Panel2.Controls.Add(ExportShemaMainTemplate);
      tpExportShemaSplit.Panel2.Controls.Add(panel1);
      tpExportShemaSplit.Size = new Size(904, 597);
      tpExportShemaSplit.SplitterDistance = 410;
      tpExportShemaSplit.TabIndex = 0;
      // 
      // ExportShemaFields
      // 
      ExportShemaFields.AllowUserToAddRows = false;
      ExportShemaFields.AllowUserToDeleteRows = false;
      ExportShemaFields.AllowUserToResizeRows = false;
      ExportShemaFields.BorderStyle = BorderStyle.None;
      ExportShemaFields.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      ExportShemaFields.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      ExportShemaFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ExportShemaFields.Columns.AddRange(new DataGridViewColumn[] { FieldName, FieldSourceName, FieldConvertTo, FieldConvertError, FieldIfEmpty, FieldDefaultValue });
      ExportShemaFields.ContextMenuStrip = ExportShemaFieldsMenu;
      ExportShemaFields.Dock = DockStyle.Fill;
      ExportShemaFields.Location = new Point(0, 0);
      ExportShemaFields.Name = "ExportShemaFields";
      ExportShemaFields.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      ExportShemaFields.RowHeadersVisible = false;
      ExportShemaFields.Size = new Size(410, 597);
      ExportShemaFields.StandardTab = true;
      ExportShemaFields.TabIndex = 1;
      // 
      // FieldName
      // 
      FieldName.DataPropertyName = "Name";
      FieldName.Frozen = true;
      FieldName.HeaderText = "Name";
      FieldName.Name = "FieldName";
      FieldName.ToolTipText = "Node Name";
      // 
      // FieldSourceName
      // 
      FieldSourceName.DataPropertyName = "SourceName";
      FieldSourceName.HeaderText = "Source";
      FieldSourceName.Name = "FieldSourceName";
      FieldSourceName.ToolTipText = "Source Column Name";
      FieldSourceName.Width = 70;
      // 
      // FieldConvertTo
      // 
      FieldConvertTo.DataPropertyName = "ConvertTo";
      FieldConvertTo.FlatStyle = FlatStyle.Flat;
      FieldConvertTo.HeaderText = "Convert To";
      FieldConvertTo.Items.AddRange(new object[] { "Implicit", "String", "Integer", "Percent", "Money", "Date", "Time", "DateTime", "FilePath" });
      FieldConvertTo.Name = "FieldConvertTo";
      FieldConvertTo.Width = 75;
      // 
      // FieldConvertError
      // 
      FieldConvertError.DataPropertyName = "ConvertError";
      FieldConvertError.FlatStyle = FlatStyle.Flat;
      FieldConvertError.HeaderText = "On Error";
      FieldConvertError.Items.AddRange(new object[] { "Stop", "Skip" });
      FieldConvertError.Name = "FieldConvertError";
      FieldConvertError.Resizable = DataGridViewTriState.True;
      FieldConvertError.Width = 60;
      // 
      // FieldIfEmpty
      // 
      FieldIfEmpty.DataPropertyName = "IfEmpty";
      FieldIfEmpty.FlatStyle = FlatStyle.Flat;
      FieldIfEmpty.HeaderText = "If Empty";
      FieldIfEmpty.Items.AddRange(new object[] { "Ignore", "Remove", "Stop", "Default" });
      FieldIfEmpty.Name = "FieldIfEmpty";
      FieldIfEmpty.Resizable = DataGridViewTriState.True;
      FieldIfEmpty.Width = 75;
      // 
      // FieldDefaultValue
      // 
      FieldDefaultValue.DataPropertyName = "DefaultValue";
      FieldDefaultValue.HeaderText = "Default";
      FieldDefaultValue.Name = "FieldDefaultValue";
      FieldDefaultValue.Visible = false;
      // 
      // ExportShemaFieldsMenu
      // 
      ExportShemaFieldsMenu.Name = "ExportShemaFieldsMenu";
      ExportShemaFieldsMenu.Size = new Size(61, 4);
      // 
      // ExportShemaMainTemplate
      // 
      ExportShemaMainTemplate.BorderStyle = BorderStyle.None;
      ExportShemaMainTemplate.ContextMenuStrip = ExportShemaMainTemplateMenuStrip;
      ExportShemaMainTemplate.Dock = DockStyle.Fill;
      ExportShemaMainTemplate.Location = new Point(0, 21);
      ExportShemaMainTemplate.Name = "ExportShemaMainTemplate";
      ExportShemaMainTemplate.Size = new Size(490, 576);
      ExportShemaMainTemplate.TabIndex = 0;
      ExportShemaMainTemplate.Text = "";
      ExportShemaMainTemplate.WordWrap = false;
      ExportShemaMainTemplate.TextChanged += ExportData_Changed;
      // 
      // ExportShemaMainTemplateMenuStrip
      // 
      ExportShemaMainTemplateMenuStrip.Items.AddRange(new ToolStripItem[] { ExportShemaTemplatesMainCopyAll, ExportShemaTemplatesMainPasteAll, toolStripSeparator5, ExportShemaTemplatesMainTest, ExportShemaTemplatesMainViewXML, toolStripSeparator4, ExportShemaTemplatesList, ExportShemaTemplatesMainLoad });
      ExportShemaMainTemplateMenuStrip.Name = "ExportShemaMainTemplateMenuStrip";
      ExportShemaMainTemplateMenuStrip.Size = new Size(162, 148);
      // 
      // ExportShemaTemplatesMainCopyAll
      // 
      ExportShemaTemplatesMainCopyAll.Name = "ExportShemaTemplatesMainCopyAll";
      ExportShemaTemplatesMainCopyAll.Size = new Size(161, 22);
      ExportShemaTemplatesMainCopyAll.Text = "Copy All";
      ExportShemaTemplatesMainCopyAll.Click += Action_Click;
      // 
      // ExportShemaTemplatesMainPasteAll
      // 
      ExportShemaTemplatesMainPasteAll.Name = "ExportShemaTemplatesMainPasteAll";
      ExportShemaTemplatesMainPasteAll.Size = new Size(161, 22);
      ExportShemaTemplatesMainPasteAll.Text = "Paste All";
      ExportShemaTemplatesMainPasteAll.Click += Action_Click;
      // 
      // toolStripSeparator5
      // 
      toolStripSeparator5.Name = "toolStripSeparator5";
      toolStripSeparator5.Size = new Size(158, 6);
      // 
      // ExportShemaTemplatesMainTest
      // 
      ExportShemaTemplatesMainTest.Name = "ExportShemaTemplatesMainTest";
      ExportShemaTemplatesMainTest.Size = new Size(161, 22);
      ExportShemaTemplatesMainTest.Text = "Run Test";
      ExportShemaTemplatesMainTest.Click += Action_Click;
      // 
      // ExportShemaTemplatesMainViewXML
      // 
      ExportShemaTemplatesMainViewXML.Name = "ExportShemaTemplatesMainViewXML";
      ExportShemaTemplatesMainViewXML.ShortcutKeys = Keys.F3;
      ExportShemaTemplatesMainViewXML.Size = new Size(161, 22);
      ExportShemaTemplatesMainViewXML.Text = "View As XML";
      ExportShemaTemplatesMainViewXML.Click += Action_Click;
      // 
      // toolStripSeparator4
      // 
      toolStripSeparator4.Name = "toolStripSeparator4";
      toolStripSeparator4.Size = new Size(158, 6);
      // 
      // ExportShemaTemplatesList
      // 
      ExportShemaTemplatesList.DropDownItems.AddRange(new ToolStripItem[] { ExportShemaTemplatesMainDefault, ExportShemaTemplatesItemsDefault, ExportShemaTemplatesTaxesDefault });
      ExportShemaTemplatesList.Name = "ExportShemaTemplatesList";
      ExportShemaTemplatesList.Size = new Size(161, 22);
      ExportShemaTemplatesList.Text = "Templates";
      // 
      // ExportShemaTemplatesMainDefault
      // 
      ExportShemaTemplatesMainDefault.Name = "ExportShemaTemplatesMainDefault";
      ExportShemaTemplatesMainDefault.Size = new Size(103, 22);
      ExportShemaTemplatesMainDefault.Text = "Main";
      ExportShemaTemplatesMainDefault.Click += Action_Click;
      // 
      // ExportShemaTemplatesItemsDefault
      // 
      ExportShemaTemplatesItemsDefault.Name = "ExportShemaTemplatesItemsDefault";
      ExportShemaTemplatesItemsDefault.Size = new Size(103, 22);
      ExportShemaTemplatesItemsDefault.Text = "Items";
      ExportShemaTemplatesItemsDefault.Click += Action_Click;
      // 
      // ExportShemaTemplatesTaxesDefault
      // 
      ExportShemaTemplatesTaxesDefault.Name = "ExportShemaTemplatesTaxesDefault";
      ExportShemaTemplatesTaxesDefault.Size = new Size(103, 22);
      ExportShemaTemplatesTaxesDefault.Text = "Taxes";
      ExportShemaTemplatesTaxesDefault.Click += Action_Click;
      // 
      // ExportShemaTemplatesMainLoad
      // 
      ExportShemaTemplatesMainLoad.Name = "ExportShemaTemplatesMainLoad";
      ExportShemaTemplatesMainLoad.ShortcutKeys = Keys.Control | Keys.O;
      ExportShemaTemplatesMainLoad.Size = new Size(161, 22);
      ExportShemaTemplatesMainLoad.Text = "Load...";
      ExportShemaTemplatesMainLoad.Click += Action_Click;
      // 
      // panel1
      // 
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(490, 21);
      panel1.TabIndex = 1;
      // 
      // ExportShemaStrip
      // 
      ExportShemaStrip.GripStyle = ToolStripGripStyle.Hidden;
      ExportShemaStrip.Items.AddRange(new ToolStripItem[] { ExportShemaTable, toolStripSeparator2, ExportShemaProccessor, ExportShemaRefresh, ExportShemaFieldAdd, ExportShemaFieldDelete, toolStripSeparator6, ExportShemaTest });
      ExportShemaStrip.Location = new Point(0, 0);
      ExportShemaStrip.Name = "ExportShemaStrip";
      ExportShemaStrip.Size = new Size(904, 25);
      ExportShemaStrip.TabIndex = 0;
      ExportShemaStrip.Text = "toolStrip1";
      // 
      // ExportShemaTable
      // 
      ExportShemaTable.DisplayStyle = ToolStripItemDisplayStyle.Text;
      ExportShemaTable.DropDownItems.AddRange(new ToolStripItem[] { ExportShemaMasterTable, toolStripSeparator8 });
      ExportShemaTable.Image = (Image)resources.GetObject("ExportShemaTable.Image");
      ExportShemaTable.ImageTransparentColor = Color.Magenta;
      ExportShemaTable.Name = "ExportShemaTable";
      ExportShemaTable.Size = new Size(56, 22);
      ExportShemaTable.Text = "Master";
      ExportShemaTable.DropDownOpening += Action_Click;
      // 
      // ExportShemaMasterTable
      // 
      ExportShemaMasterTable.Name = "ExportShemaMasterTable";
      ExportShemaMasterTable.Size = new Size(121, 22);
      ExportShemaMasterTable.Text = "(change)";
      ExportShemaMasterTable.Click += ExportShemaTable_Click;
      // 
      // toolStripSeparator8
      // 
      toolStripSeparator8.Name = "toolStripSeparator8";
      toolStripSeparator8.Size = new Size(118, 6);
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(6, 25);
      // 
      // ExportShemaProccessor
      // 
      ExportShemaProccessor.DisplayStyle = ToolStripItemDisplayStyle.Text;
      ExportShemaProccessor.DropDownItems.AddRange(new ToolStripItem[] { ExportShemaProccessorDynamicFields, toolStripSeparator3, ExportShemaProccessorDynamic, ExportShemaProccessorFields });
      ExportShemaProccessor.Image = (Image)resources.GetObject("ExportShemaProccessor.Image");
      ExportShemaProccessor.ImageTransparentColor = Color.Magenta;
      ExportShemaProccessor.Name = "ExportShemaProccessor";
      ExportShemaProccessor.Size = new Size(34, 22);
      ExportShemaProccessor.Text = "All";
      // 
      // ExportShemaProccessorDynamicFields
      // 
      ExportShemaProccessorDynamicFields.Name = "ExportShemaProccessorDynamicFields";
      ExportShemaProccessorDynamicFields.Size = new Size(121, 22);
      ExportShemaProccessorDynamicFields.Text = "All";
      ExportShemaProccessorDynamicFields.Click += Action_Click;
      // 
      // toolStripSeparator3
      // 
      toolStripSeparator3.Name = "toolStripSeparator3";
      toolStripSeparator3.Size = new Size(118, 6);
      // 
      // ExportShemaProccessorDynamic
      // 
      ExportShemaProccessorDynamic.Name = "ExportShemaProccessorDynamic";
      ExportShemaProccessorDynamic.Size = new Size(121, 22);
      ExportShemaProccessorDynamic.Text = "Dynamic";
      ExportShemaProccessorDynamic.Click += Action_Click;
      // 
      // ExportShemaProccessorFields
      // 
      ExportShemaProccessorFields.Name = "ExportShemaProccessorFields";
      ExportShemaProccessorFields.Size = new Size(121, 22);
      ExportShemaProccessorFields.Text = "Fields";
      ExportShemaProccessorFields.Click += Action_Click;
      // 
      // ExportShemaRefresh
      // 
      ExportShemaRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      ExportShemaRefresh.Image = (Image)resources.GetObject("ExportShemaRefresh.Image");
      ExportShemaRefresh.ImageTransparentColor = Color.Magenta;
      ExportShemaRefresh.Name = "ExportShemaRefresh";
      ExportShemaRefresh.Size = new Size(23, 22);
      ExportShemaRefresh.Text = "Refresh";
      ExportShemaRefresh.Click += Action_Click;
      // 
      // ExportShemaFieldAdd
      // 
      ExportShemaFieldAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
      ExportShemaFieldAdd.Image = (Image)resources.GetObject("ExportShemaFieldAdd.Image");
      ExportShemaFieldAdd.ImageTransparentColor = Color.Magenta;
      ExportShemaFieldAdd.Name = "ExportShemaFieldAdd";
      ExportShemaFieldAdd.Size = new Size(23, 22);
      ExportShemaFieldAdd.Text = "Add Field...";
      ExportShemaFieldAdd.Click += Action_Click;
      // 
      // ExportShemaFieldDelete
      // 
      ExportShemaFieldDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
      ExportShemaFieldDelete.DropDownItems.AddRange(new ToolStripItem[] { ExportShemaFieldDeleteAll });
      ExportShemaFieldDelete.Image = (Image)resources.GetObject("ExportShemaFieldDelete.Image");
      ExportShemaFieldDelete.ImageTransparentColor = Color.Magenta;
      ExportShemaFieldDelete.Name = "ExportShemaFieldDelete";
      ExportShemaFieldDelete.Size = new Size(32, 22);
      ExportShemaFieldDelete.Text = "Delete Field";
      ExportShemaFieldDelete.ButtonClick += Action_Click;
      // 
      // ExportShemaFieldDeleteAll
      // 
      ExportShemaFieldDeleteAll.Image = (Image)resources.GetObject("ExportShemaFieldDeleteAll.Image");
      ExportShemaFieldDeleteAll.Name = "ExportShemaFieldDeleteAll";
      ExportShemaFieldDeleteAll.Size = new Size(124, 22);
      ExportShemaFieldDeleteAll.Text = "Delete All";
      ExportShemaFieldDeleteAll.Click += Action_Click;
      // 
      // toolStripSeparator6
      // 
      toolStripSeparator6.Name = "toolStripSeparator6";
      toolStripSeparator6.Size = new Size(6, 25);
      // 
      // ExportShemaTest
      // 
      ExportShemaTest.DisplayStyle = ToolStripItemDisplayStyle.Text;
      ExportShemaTest.DropDownItems.AddRange(new ToolStripItem[] { ExportShemaTestRefreshData });
      ExportShemaTest.Image = (Image)resources.GetObject("ExportShemaTest.Image");
      ExportShemaTest.ImageTransparentColor = Color.Magenta;
      ExportShemaTest.Name = "ExportShemaTest";
      ExportShemaTest.Size = new Size(44, 22);
      ExportShemaTest.Text = "Test";
      ExportShemaTest.ButtonClick += Action_Click;
      // 
      // ExportShemaTestRefreshData
      // 
      ExportShemaTestRefreshData.Name = "ExportShemaTestRefreshData";
      ExportShemaTestRefreshData.Size = new Size(140, 22);
      ExportShemaTestRefreshData.Text = "Refresh Data";
      ExportShemaTestRefreshData.Click += Action_Click;
      // 
      // tpExportSend
      // 
      tpExportSend.AutoScroll = true;
      tpExportSend.Controls.Add(SendToSEFPanel);
      tpExportSend.Controls.Add(SendToMRPanel);
      tpExportSend.Controls.Add(SendToFilePanel);
      tpExportSend.Controls.Add(SendMainPanel);
      tpExportSend.Location = new Point(4, 24);
      tpExportSend.Name = "tpExportSend";
      tpExportSend.Size = new Size(904, 622);
      tpExportSend.TabIndex = 4;
      tpExportSend.Text = "Send To";
      tpExportSend.UseVisualStyleBackColor = true;
      // 
      // SendToSEFPanel
      // 
      SendToSEFPanel.Controls.Add(label12);
      SendToSEFPanel.Controls.Add(ExportSendSEFApiKey);
      SendToSEFPanel.Controls.Add(label11);
      SendToSEFPanel.Controls.Add(ExportSendSEFURI);
      SendToSEFPanel.Dock = DockStyle.Top;
      SendToSEFPanel.Location = new Point(0, 457);
      SendToSEFPanel.Name = "SendToSEFPanel";
      SendToSEFPanel.Size = new Size(904, 90);
      SendToSEFPanel.TabIndex = 313;
      // 
      // label12
      // 
      label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label12.AutoSize = true;
      label12.Location = new Point(749, 10);
      label12.Name = "label12";
      label12.Size = new Size(47, 15);
      label12.TabIndex = 28;
      label12.Text = "Api Key";
      // 
      // ExportSendSEFApiKey
      // 
      ExportSendSEFApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendSEFApiKey.Font = new Font("Segoe UI", 9F);
      ExportSendSEFApiKey.Location = new Point(749, 28);
      ExportSendSEFApiKey.Name = "ExportSendSEFApiKey";
      ExportSendSEFApiKey.Size = new Size(147, 23);
      ExportSendSEFApiKey.TabIndex = 27;
      ExportSendSEFApiKey.TextChanged += ExportData_Changed;
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
      ExportSendSEFURI.Size = new Size(735, 23);
      ExportSendSEFURI.TabIndex = 25;
      ExportSendSEFURI.TextChanged += ExportData_Changed;
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
      SendToMRPanel.Size = new Size(904, 332);
      SendToMRPanel.TabIndex = 304;
      // 
      // SendMRTestDebug
      // 
      SendMRTestDebug.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      SendMRTestDebug.AutoSize = true;
      SendMRTestDebug.CheckAlign = ContentAlignment.MiddleRight;
      SendMRTestDebug.ForeColor = Color.Blue;
      SendMRTestDebug.Location = new Point(835, 162);
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
      SendMRTestID.Click += Action_Click;
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
      SendMRTestFile.Click += Action_Click;
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
      SendMRLog.Size = new Size(888, 138);
      SendMRLog.TabIndex = 33;
      SendMRLog.WordWrap = false;
      // 
      // label9
      // 
      label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label9.AutoSize = true;
      label9.Location = new Point(749, 112);
      label9.Name = "label9";
      label9.Size = new Size(67, 15);
      label9.TabIndex = 32;
      label9.Text = "Software ID";
      // 
      // ExportSendMRSoftwareID
      // 
      ExportSendMRSoftwareID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendMRSoftwareID.Font = new Font("Segoe UI", 9F);
      ExportSendMRSoftwareID.Location = new Point(749, 130);
      ExportSendMRSoftwareID.Name = "ExportSendMRSoftwareID";
      ExportSendMRSoftwareID.Size = new Size(147, 23);
      ExportSendMRSoftwareID.TabIndex = 31;
      ExportSendMRSoftwareID.TextChanged += ExportData_Changed;
      // 
      // label8
      // 
      label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label8.AutoSize = true;
      label8.Location = new Point(749, 60);
      label8.Name = "label8";
      label8.Size = new Size(73, 15);
      label8.TabIndex = 30;
      label8.Text = "Company ID";
      // 
      // ExportSendMRCompanyID
      // 
      ExportSendMRCompanyID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      ExportSendMRCompanyID.Font = new Font("Segoe UI", 9F);
      ExportSendMRCompanyID.Location = new Point(749, 78);
      ExportSendMRCompanyID.Name = "ExportSendMRCompanyID";
      ExportSendMRCompanyID.Size = new Size(147, 23);
      ExportSendMRCompanyID.TabIndex = 29;
      ExportSendMRCompanyID.TextChanged += ExportData_Changed;
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
      ExportSendMRPassword.Size = new Size(735, 23);
      ExportSendMRPassword.TabIndex = 27;
      ExportSendMRPassword.TextChanged += ExportData_Changed;
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
      ExportSendMRUsername.Size = new Size(735, 23);
      ExportSendMRUsername.TabIndex = 25;
      ExportSendMRUsername.TextChanged += ExportData_Changed;
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
      ExportSendMRURI.Size = new Size(888, 23);
      ExportSendMRURI.TabIndex = 23;
      ExportSendMRURI.TextChanged += ExportData_Changed;
      // 
      // SendToFilePanel
      // 
      SendToFilePanel.Controls.Add(label16);
      SendToFilePanel.Controls.Add(ExportSendFileLocation);
      SendToFilePanel.Dock = DockStyle.Top;
      SendToFilePanel.Location = new Point(0, 68);
      SendToFilePanel.Name = "SendToFilePanel";
      SendToFilePanel.Size = new Size(904, 57);
      SendToFilePanel.TabIndex = 311;
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
      ExportSendFileLocation.Size = new Size(888, 23);
      ExportSendFileLocation.TabIndex = 23;
      ExportSendFileLocation.TextChanged += ExportData_Changed;
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
      SendMainPanel.Size = new Size(904, 68);
      SendMainPanel.TabIndex = 312;
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
      ExportSendManage.Click += Action_Click;
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
      ExportSendName.Size = new Size(735, 23);
      ExportSendName.TabIndex = 314;
      ExportSendName.TextChanged += ExportData_Changed;
      // 
      // label4
      // 
      label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label4.AutoSize = true;
      label4.Location = new Point(749, 21);
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
      ExportSendProvider.Items.AddRange(new object[] { "Skip", "File", "SEF", "MojeRacun" });
      ExportSendProvider.Location = new Point(749, 40);
      ExportSendProvider.Name = "ExportSendProvider";
      ExportSendProvider.Size = new Size(147, 23);
      ExportSendProvider.TabIndex = 311;
      ExportSendProvider.SelectedIndexChanged += ExportSendProvider_SelectedIndexChanged;
      ExportSendProvider.TextChanged += ExportData_Changed;
      // 
      // tpImportSource
      // 
      tpImportSource.Location = new Point(4, 24);
      tpImportSource.Name = "tpImportSource";
      tpImportSource.Padding = new Padding(3);
      tpImportSource.Size = new Size(904, 622);
      tpImportSource.TabIndex = 6;
      tpImportSource.Text = "Source";
      tpImportSource.UseVisualStyleBackColor = true;
      // 
      // tpImportTarget
      // 
      tpImportTarget.Location = new Point(4, 24);
      tpImportTarget.Name = "tpImportTarget";
      tpImportTarget.Padding = new Padding(3);
      tpImportTarget.Size = new Size(904, 622);
      tpImportTarget.TabIndex = 7;
      tpImportTarget.Text = "Target";
      tpImportTarget.UseVisualStyleBackColor = true;
      // 
      // tpImportResult
      // 
      tpImportResult.Location = new Point(4, 24);
      tpImportResult.Name = "tpImportResult";
      tpImportResult.Padding = new Padding(3);
      tpImportResult.Size = new Size(904, 622);
      tpImportResult.TabIndex = 8;
      tpImportResult.Text = "Result";
      tpImportResult.UseVisualStyleBackColor = true;
      // 
      // openFileDialog
      // 
      openFileDialog.DefaultExt = "xml";
      openFileDialog.Filter = "Xml file|*.xml|All files(s)|*.*";
      openFileDialog.Title = "Open File...";
      // 
      // saveFileDialog
      // 
      saveFileDialog.DefaultExt = "xml";
      saveFileDialog.Filter = "Xml file|*.xml|All files(s)|*.*";
      saveFileDialog.Title = "Save As...";
      // 
      // openTemplateDialog
      // 
      openTemplateDialog.DefaultExt = "txt";
      openTemplateDialog.Filter = "Text File|*.txt|Xml file|*.xml|All files(s)|*.*";
      openTemplateDialog.Title = "Open Template...";
      // 
      // SendMRTestWorker
      // 
      SendMRTestWorker.WorkerReportsProgress = true;
      SendMRTestWorker.WorkerSupportsCancellation = true;
      SendMRTestWorker.DoWork += SendMRTestWorker_DoWork;
      SendMRTestWorker.ProgressChanged += SendMRTestWorker_ProgressChanged;
      SendMRTestWorker.RunWorkerCompleted += SendMRTestWorker_RunWorkerCompleted;
      // 
      // FormEditor
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(912, 696);
      Controls.Add(Tabs);
      Controls.Add(StatusBar);
      Controls.Add(MenuStrip);
      Icon = (Icon)resources.GetObject("$this.Icon");
      MainMenuStrip = MenuStrip;
      Name = "FormEditor";
      Text = "Editor";
      FormClosing += FormEditor_FormClosing;
      MenuStrip.ResumeLayout(false);
      MenuStrip.PerformLayout();
      Tabs.ResumeLayout(false);
      tpHome.ResumeLayout(false);
      tpHome.PerformLayout();
      tpExportGeneral.ResumeLayout(false);
      tpExportGeneral.PerformLayout();
      tpExportSource.ResumeLayout(false);
      ExportSourceMapsPanel.ResumeLayout(false);
      ExportSourceMapsMenuStrip.ResumeLayout(false);
      SourceKindMsSql.ResumeLayout(false);
      SourceKindMsSql.PerformLayout();
      SourceKindTest.ResumeLayout(false);
      SourceKindTest.PerformLayout();
      SourceMainPanel.ResumeLayout(false);
      SourceMainPanel.PerformLayout();
      tpExportShema.ResumeLayout(false);
      tpExportShema.PerformLayout();
      tpExportShemaSplit.Panel1.ResumeLayout(false);
      tpExportShemaSplit.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)tpExportShemaSplit).EndInit();
      tpExportShemaSplit.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)ExportShemaFields).EndInit();
      ExportShemaMainTemplateMenuStrip.ResumeLayout(false);
      ExportShemaStrip.ResumeLayout(false);
      ExportShemaStrip.PerformLayout();
      tpExportSend.ResumeLayout(false);
      SendToSEFPanel.ResumeLayout(false);
      SendToSEFPanel.PerformLayout();
      SendToMRPanel.ResumeLayout(false);
      SendToMRPanel.PerformLayout();
      SendToFilePanel.ResumeLayout(false);
      SendToFilePanel.PerformLayout();
      SendMainPanel.ResumeLayout(false);
      SendMainPanel.PerformLayout();
      tpImportGeneral.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private MenuStrip MenuStrip;
    private ToolStripMenuItem MenuFile;
    private ToolStripMenuItem MenuFileOpen;
    private ToolStripSeparator toolStripSeparator1;
    private StatusStrip StatusBar;
    private TabControl Tabs;
    private TabPage tpHome;
    private TabPage tpExportGeneral;
    private ToolStripMenuItem MenuFileNew;
    private ToolStripMenuItem MenuClose;
    private TabPage tpExportSource;
    private TabPage tpExportShema;
    private TabPage tpExportSend;
    private ToolStripMenuItem MenuFileSaveAs;
    private Label HomeRecentLabel;
    private LinkLabel HomeFileOpen;
    private LinkLabel HomeFileNewExport;
    private Label HomeLabel;
    private TextBox ExportName;
    private Label ExportChangeTextLabel;
    private TextBox ExportChangeText;
    private Label ExportCreatedTextLabel;
    private TextBox ExportCreatedText;
    private Label ExportDescriptionLabel;
    private TextBox ExportDescription;
    private Label ExportNameLabel;
    private ComboBox ExportKind;
    private Label ExportKindLabel;
    private OpenFileDialog openFileDialog;
    private SaveFileDialog saveFileDialog;
    private ToolStripMenuItem MenuFileSave;
    private SplitContainer tpExportShemaSplit;
    private DataGridView ExportShemaFields;
    private ToolStrip ExportShemaStrip;
    private ToolStripButton ExportShemaRefresh;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripDropDownButton ExportShemaProccessor;
    private ToolStripMenuItem ExportShemaProccessorDynamicFields;
    private ToolStripMenuItem ExportShemaProccessorDynamic;
    private ToolStripMenuItem ExportShemaProccessorFields;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripButton ExportShemaFieldAdd;
    private RichTextBox ExportShemaMainTemplate;
    private LinkLabel HomeFileRecent4;
    private LinkLabel HomeFileRecent3;
    private LinkLabel HomeFileRecent2;
    private LinkLabel HomeFileRecent1;
    private LinkLabel HomeFileRecent0;
    private OpenFileDialog openTemplateDialog;
    private LinkLabel HomeFileNewInport;
    private ToolStripSplitButton ExportShemaFieldDelete;
    private ToolStripMenuItem ExportShemaFieldDeleteAll;
    private ContextMenuStrip ExportShemaFieldsMenu;
    private CheckBox ExportLogTo;
    private Panel SendToMRPanel;
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
    private ToolStripDropDownButton ExportShemaTable;
    private ToolStripMenuItem ExportShemaMasterTable;
    private ToolStripSeparator toolStripSeparator8;
    private Panel SourceKindMsSql;
    private Label label3;
    private TextBox ExportSourceListQuery;
    private LinkLabel ExportSourceConnectionStrTest;
    private Button ExportSourceConnectionBtn;
    private Label label10;
    private TextBox ExportSourceMainQuery;
    private Label ExportSourceConnectionLabel;
    private TextBox ExportSourceConnectionStr;
    private Panel SourceKindTest;
    private Label label2;
    private TextBox ExportSourceTestFileName;
    private Panel SourceMainPanel;
    private Panel ExportSourceMapsPanel;
    private ListView ExportSourceMaps;
    private ColumnHeader ColSourceMapName;
    private ColumnHeader ColSourceMapQuery;
    private LinkLabel ExportSourceManage;
    private Label ExportSourceKindLabel;
    private ComboBox ExportSourceKind;
    private Label ExportSourceNameLabel;
    private TextBox ExportSourceName;
    private ColumnHeader ColSourceMapFilter;
    private Button ExportSourceTestFileNameOpen;
    private ContextMenuStrip ExportSourceMapsMenuStrip;
    private ToolStripMenuItem ExportSourceMapsAddStrip;
    private ToolStripMenuItem ExportSourceMapsRemoveStrip;
    private ToolStripMenuItem MenuFileNewExport;
    private ToolStripMenuItem MenuFileNewInport;
    private ToolStripMenuItem ExportSourceMapsOpenStrip;
    private ToolStripMenuItem ExportSourceMapsChangeStrip;
    private ContextMenuStrip ExportShemaMainTemplateMenuStrip;
    private ToolStripMenuItem ExportShemaTemplatesMainLoad;
    private ToolStripMenuItem ExportShemaTemplatesList;
    private ToolStripMenuItem ExportShemaTemplatesMainDefault;
    private ToolStripMenuItem ExportShemaTemplatesItemsDefault;
    private ToolStripMenuItem ExportShemaTemplatesTaxesDefault;
    private ToolStripMenuItem ExportShemaTemplatesMainViewXML;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem ExportShemaTemplatesMainTest;
    private Label ExportFileNameLabel;
    private TextBox ExportFileName;
    private Panel SendMainPanel;
    private LinkLabel ExportSendManage;
    private Label label1;
    private TextBox ExportSendName;
    private Label label4;
    private ComboBox ExportSendProvider;
    private Panel SendToSEFPanel;
    private Label label11;
    private TextBox ExportSendSEFURI;
    private Label label12;
    private TextBox ExportSendSEFApiKey;
    private LinkLabel ExportSourceMainQueryTest;
    private LinkLabel SendMRTestFile;
    private TextBox SendMRLog;
    private LinkLabel SendMRTestID;
    private System.ComponentModel.BackgroundWorker SendMRTestWorker;
    private ToolStripMenuItem ExportShemaTemplatesMainCopyAll;
    private ToolStripMenuItem ExportShemaTemplatesMainPasteAll;
    private ToolStripSeparator toolStripSeparator5;
    private DataGridViewTextBoxColumn FieldName;
    private DataGridViewTextBoxColumn FieldSourceName;
    private DataGridViewComboBoxColumn FieldConvertTo;
    private DataGridViewComboBoxColumn FieldConvertError;
    private DataGridViewComboBoxColumn FieldIfEmpty;
    private DataGridViewTextBoxColumn FieldDefaultValue;
    private ToolStripSplitButton ExportShemaTest;
    private ToolStripMenuItem ExportShemaTestRefreshData;
    private ToolStripSeparator toolStripSeparator6;
    private CheckBox SendMRTestDebug;
    private Panel panel1;
    private TabPage tpImportGeneral;
    private TabPage tpImportSource;
    private TabPage tpImportTarget;
    private TabPage tpImportResult;
    private CheckBox ExportLogDebug;
  }
}
