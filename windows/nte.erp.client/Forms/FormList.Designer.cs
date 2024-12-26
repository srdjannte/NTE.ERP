namespace nte.forms.Forms
{
    partial class FormList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
      MainMenu = new MenuStrip();
      MainMenuData = new ToolStripMenuItem();
      MainMenuAdd = new ToolStripMenuItem();
      MainMenuS0 = new ToolStripSeparator();
      MainMenuFilter = new ToolStripMenuItem();
      MainMenuS1 = new ToolStripSeparator();
      MainMenuExcelOpen = new ToolStripMenuItem();
      MainMenuExport = new ToolStripMenuItem();
      MainMenuImport = new ToolStripMenuItem();
      MainMenuS2 = new ToolStripSeparator();
      MainMenuRefresh = new ToolStripMenuItem();
      MainMenuS3 = new ToolStripSeparator();
      MenuClose = new ToolStripMenuItem();
      MainMenuView = new ToolStripMenuItem();
      FindStripMenu = new ToolStripMenuItem();
      MainManuColumnsShow = new ToolStripMenuItem();
      toolStripSeparator6 = new ToolStripSeparator();
      MainMenuPin = new ToolStripMenuItem();
      StatusbarMenu = new ToolStripMenuItem();
      toolStripSeparator9 = new ToolStripSeparator();
      MainMenuEditor = new ToolStripMenuItem();
      MenuHelp = new ToolStripMenuItem();
      StatusBar = new StatusStrip();
      MainStatusLabel = new ToolStripStatusLabel();
      StatusCapsLock = new ToolStripStatusLabel();
      StatusNumLock = new ToolStripStatusLabel();
      MainStatusState = new ToolStripStatusLabel();
      MainStatusStat = new ToolStripSplitButton();
      MainStatusStatCopy = new ToolStripMenuItem();
      toolStripSeparator7 = new ToolStripSeparator();
      MainStatusStatHigh = new ToolStripMenuItem();
      MainStatusStatAvg = new ToolStripMenuItem();
      MainStatusStatLow = new ToolStripMenuItem();
      MainStatusStatSum = new ToolStripMenuItem();
      MainStatusStatCount = new ToolStripMenuItem();
      toolStripStatusLabel1 = new ToolStripStatusLabel();
      MainTool = new ToolStrip();
      MainToolFilterView = new ToolStripButton();
      MainToolView = new ToolStripSplitButton();
      MainToolViewDefault = new ToolStripMenuItem();
      toolStripSeparator4 = new ToolStripSeparator();
      MainToolViewManage = new ToolStripMenuItem();
      MainToolRefresh = new ToolStripButton();
      toolStripSeparator1 = new ToolStripSeparator();
      FindField = new ToolStripDropDownButton();
      FindFieldAllMenu = new ToolStripMenuItem();
      FindFieldSeparator = new ToolStripSeparator();
      FindText = new ToolStripTextBox();
      MainToolFilter = new ToolStripSplitButton();
      MainToolFilterPaste = new ToolStripMenuItem();
      MainToolFilterClear = new ToolStripMenuItem();
      toolStripSeparator5 = new ToolStripSeparator();
      MainToolFilterActive = new ToolStripMenuItem();
      MainToolPageSep = new ToolStripSeparator();
      MainToolPagePrev = new ToolStripButton();
      MainToolPageNmb = new ToolStripDropDownButton();
      MainToolPageGoTo = new ToolStripMenuItem();
      toolStripSeparator10 = new ToolStripSeparator();
      MainToolPageConfig = new ToolStripMenuItem();
      MainToolPageNext = new ToolStripButton();
      toolStripSeparator2 = new ToolStripSeparator();
      MainToolDataAdd = new ToolStripButton();
      MainToolExcel = new ToolStripButton();
      MainToolUsers = new ToolStripButton();
      MainToolPin = new ToolStripButton();
      MainBW = new System.ComponentModel.BackgroundWorker();
      FilterSplitContainer = new SplitContainer();
      FilterPanel = new Panel();
      FilterCmd = new Panel();
      FilterClearButton = new Button();
      FilterRefereshButton = new Button();
      MainMenu.SuspendLayout();
      StatusBar.SuspendLayout();
      MainTool.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)FilterSplitContainer).BeginInit();
      FilterSplitContainer.Panel1.SuspendLayout();
      FilterSplitContainer.SuspendLayout();
      FilterCmd.SuspendLayout();
      SuspendLayout();
      // 
      // MainMenu
      // 
      MainMenu.Items.AddRange(new ToolStripItem[] { MainMenuData, MainMenuView });
      MainMenu.Location = new Point(0, 0);
      MainMenu.Name = "MainMenu";
      MainMenu.Padding = new Padding(7, 2, 0, 2);
      MainMenu.Size = new Size(1125, 28);
      MainMenu.TabIndex = 0;
      MainMenu.Text = "menuStrip1";
      MainMenu.Visible = false;
      // 
      // MainMenuData
      // 
      MainMenuData.DropDownItems.AddRange(new ToolStripItem[] { MainMenuAdd, MainMenuS0, MainMenuFilter, MainMenuS1, MainMenuExcelOpen, MainMenuExport, MainMenuImport, MainMenuS2, MainMenuRefresh, MainMenuS3, MenuClose });
      MainMenuData.Name = "MainMenuData";
      MainMenuData.Size = new Size(37, 24);
      MainMenuData.Text = "List";
      MainMenuData.DropDownOpening += Action_Click;
      // 
      // MainMenuAdd
      // 
      MainMenuAdd.Name = "MainMenuAdd";
      MainMenuAdd.ShortcutKeys = Keys.Control | Keys.N;
      MainMenuAdd.Size = new Size(150, 22);
      MainMenuAdd.Text = "New...";
      MainMenuAdd.Click += Action_Click;
      // 
      // MainMenuS0
      // 
      MainMenuS0.Name = "MainMenuS0";
      MainMenuS0.Size = new Size(147, 6);
      // 
      // MainMenuFilter
      // 
      MainMenuFilter.Name = "MainMenuFilter";
      MainMenuFilter.Size = new Size(150, 22);
      MainMenuFilter.Text = "Filter";
      MainMenuFilter.Click += Action_Click;
      // 
      // MainMenuS1
      // 
      MainMenuS1.Name = "MainMenuS1";
      MainMenuS1.Size = new Size(147, 6);
      // 
      // MainMenuExcelOpen
      // 
      MainMenuExcelOpen.Name = "MainMenuExcelOpen";
      MainMenuExcelOpen.Size = new Size(150, 22);
      MainMenuExcelOpen.Text = "Open in Excel";
      MainMenuExcelOpen.Click += Action_Click;
      // 
      // MainMenuExport
      // 
      MainMenuExport.Name = "MainMenuExport";
      MainMenuExport.Size = new Size(150, 22);
      MainMenuExport.Text = "Export";
      MainMenuExport.Click += Action_Click;
      // 
      // MainMenuImport
      // 
      MainMenuImport.Name = "MainMenuImport";
      MainMenuImport.Size = new Size(150, 22);
      MainMenuImport.Text = "Import";
      MainMenuImport.Click += Action_Click;
      // 
      // MainMenuS2
      // 
      MainMenuS2.Name = "MainMenuS2";
      MainMenuS2.Size = new Size(147, 6);
      // 
      // MainMenuRefresh
      // 
      MainMenuRefresh.Name = "MainMenuRefresh";
      MainMenuRefresh.ShortcutKeys = Keys.F5;
      MainMenuRefresh.Size = new Size(150, 22);
      MainMenuRefresh.Text = "Refresh";
      MainMenuRefresh.Click += Action_Click;
      // 
      // MainMenuS3
      // 
      MainMenuS3.Name = "MainMenuS3";
      MainMenuS3.Size = new Size(147, 6);
      // 
      // MenuClose
      // 
      MenuClose.Name = "MenuClose";
      MenuClose.Size = new Size(150, 22);
      MenuClose.Text = "Close";
      MenuClose.Click += Action_Click;
      // 
      // MainMenuView
      // 
      MainMenuView.DropDownItems.AddRange(new ToolStripItem[] { FindStripMenu, MainManuColumnsShow, toolStripSeparator6, MainMenuPin, StatusbarMenu, toolStripSeparator9, MainMenuEditor, MenuHelp });
      MainMenuView.Name = "MainMenuView";
      MainMenuView.Size = new Size(44, 24);
      MainMenuView.Text = "View";
      MainMenuView.DropDownOpening += Action_Click;
      // 
      // FindStripMenu
      // 
      FindStripMenu.Name = "FindStripMenu";
      FindStripMenu.ShortcutKeys = Keys.Control | Keys.F;
      FindStripMenu.Size = new Size(163, 22);
      FindStripMenu.Text = "Find";
      FindStripMenu.Click += Action_Click;
      // 
      // MainManuColumnsShow
      // 
      MainManuColumnsShow.Name = "MainManuColumnsShow";
      MainManuColumnsShow.ShortcutKeys = Keys.Control | Keys.K;
      MainManuColumnsShow.Size = new Size(163, 22);
      MainManuColumnsShow.Text = "Columns";
      MainManuColumnsShow.Click += Action_Click;
      // 
      // toolStripSeparator6
      // 
      toolStripSeparator6.Name = "toolStripSeparator6";
      toolStripSeparator6.Size = new Size(160, 6);
      // 
      // MainMenuPin
      // 
      MainMenuPin.Name = "MainMenuPin";
      MainMenuPin.Size = new Size(163, 22);
      MainMenuPin.Text = "Always Visible";
      MainMenuPin.Click += Action_Click;
      // 
      // StatusbarMenu
      // 
      StatusbarMenu.Name = "StatusbarMenu";
      StatusbarMenu.Size = new Size(163, 22);
      StatusbarMenu.Text = "Status Bar";
      StatusbarMenu.Click += Action_Click;
      // 
      // toolStripSeparator9
      // 
      toolStripSeparator9.Name = "toolStripSeparator9";
      toolStripSeparator9.Size = new Size(160, 6);
      // 
      // MainMenuEditor
      // 
      MainMenuEditor.Name = "MainMenuEditor";
      MainMenuEditor.Size = new Size(163, 22);
      MainMenuEditor.Text = "Editor";
      MainMenuEditor.Click += Action_Click;
      // 
      // MenuHelp
      // 
      MenuHelp.Name = "MenuHelp";
      MenuHelp.Size = new Size(163, 22);
      MenuHelp.Text = "Help";
      MenuHelp.ToolTipText = "Help...";
      MenuHelp.Click += Action_Click;
      // 
      // StatusBar
      // 
      StatusBar.Items.AddRange(new ToolStripItem[] { MainStatusLabel, StatusCapsLock, StatusNumLock, MainStatusState, MainStatusStat, toolStripStatusLabel1 });
      StatusBar.Location = new Point(0, 506);
      StatusBar.Name = "StatusBar";
      StatusBar.Padding = new Padding(1, 0, 16, 0);
      StatusBar.Size = new Size(1125, 24);
      StatusBar.TabIndex = 1;
      StatusBar.Text = "Infomartions";
      // 
      // MainStatusLabel
      // 
      MainStatusLabel.Name = "MainStatusLabel";
      MainStatusLabel.Size = new Size(872, 19);
      MainStatusLabel.Spring = true;
      MainStatusLabel.Text = "...";
      MainStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // StatusCapsLock
      // 
      StatusCapsLock.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
      StatusCapsLock.BorderStyle = Border3DStyle.SunkenOuter;
      StatusCapsLock.ForeColor = SystemColors.ControlText;
      StatusCapsLock.Name = "StatusCapsLock";
      StatusCapsLock.Size = new Size(40, 19);
      StatusCapsLock.Text = "CAPS";
      // 
      // StatusNumLock
      // 
      StatusNumLock.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
      StatusNumLock.BorderStyle = Border3DStyle.SunkenOuter;
      StatusNumLock.DoubleClickEnabled = true;
      StatusNumLock.Name = "StatusNumLock";
      StatusNumLock.Size = new Size(39, 19);
      StatusNumLock.Text = "NUM";
      // 
      // MainStatusState
      // 
      MainStatusState.AutoSize = false;
      MainStatusState.Name = "MainStatusState";
      MainStatusState.Size = new Size(80, 19);
      // 
      // MainStatusStat
      // 
      MainStatusStat.DisplayStyle = ToolStripItemDisplayStyle.Text;
      MainStatusStat.DropDownItems.AddRange(new ToolStripItem[] { MainStatusStatCopy, toolStripSeparator7, MainStatusStatHigh, MainStatusStatAvg, MainStatusStatLow, MainStatusStatSum, MainStatusStatCount });
      MainStatusStat.Image = (Image)resources.GetObject("MainStatusStat.Image");
      MainStatusStat.ImageTransparentColor = Color.Magenta;
      MainStatusStat.Name = "MainStatusStat";
      MainStatusStat.Size = new Size(47, 22);
      MainStatusStat.Tag = "Count";
      MainStatusStat.Text = "Sum";
      MainStatusStat.ButtonClick += MainStatusStat_ButtonClick;
      // 
      // MainStatusStatCopy
      // 
      MainStatusStatCopy.Name = "MainStatusStatCopy";
      MainStatusStatCopy.Size = new Size(107, 22);
      MainStatusStatCopy.Text = "Copy";
      MainStatusStatCopy.Click += Action_Click;
      // 
      // toolStripSeparator7
      // 
      toolStripSeparator7.Name = "toolStripSeparator7";
      toolStripSeparator7.Size = new Size(104, 6);
      // 
      // MainStatusStatHigh
      // 
      MainStatusStatHigh.Name = "MainStatusStatHigh";
      MainStatusStatHigh.Size = new Size(107, 22);
      MainStatusStatHigh.Tag = "Max";
      MainStatusStatHigh.Text = "Max";
      MainStatusStatHigh.Click += MainStatusStat_Click;
      // 
      // MainStatusStatAvg
      // 
      MainStatusStatAvg.Name = "MainStatusStatAvg";
      MainStatusStatAvg.Size = new Size(107, 22);
      MainStatusStatAvg.Tag = "Avg";
      MainStatusStatAvg.Text = "Avg";
      MainStatusStatAvg.Click += MainStatusStat_Click;
      // 
      // MainStatusStatLow
      // 
      MainStatusStatLow.Name = "MainStatusStatLow";
      MainStatusStatLow.Size = new Size(107, 22);
      MainStatusStatLow.Tag = "Min";
      MainStatusStatLow.Text = "Min";
      MainStatusStatLow.Click += MainStatusStat_Click;
      // 
      // MainStatusStatSum
      // 
      MainStatusStatSum.Name = "MainStatusStatSum";
      MainStatusStatSum.Size = new Size(107, 22);
      MainStatusStatSum.Tag = "Sum";
      MainStatusStatSum.Text = "Sum";
      MainStatusStatSum.Click += MainStatusStat_Click;
      // 
      // MainStatusStatCount
      // 
      MainStatusStatCount.Name = "MainStatusStatCount";
      MainStatusStatCount.Size = new Size(107, 22);
      MainStatusStatCount.Tag = "Count";
      MainStatusStatCount.Text = "Count";
      MainStatusStatCount.Click += MainStatusStat_Click;
      // 
      // toolStripStatusLabel1
      // 
      toolStripStatusLabel1.AutoSize = false;
      toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      toolStripStatusLabel1.Size = new Size(30, 19);
      // 
      // MainTool
      // 
      MainTool.BackColor = SystemColors.Control;
      MainTool.GripStyle = ToolStripGripStyle.Hidden;
      MainTool.Items.AddRange(new ToolStripItem[] { MainToolFilterView, MainToolView, MainToolRefresh, toolStripSeparator1, FindField, FindText, MainToolFilter, MainToolPageSep, MainToolPagePrev, MainToolPageNmb, MainToolPageNext, toolStripSeparator2, MainToolDataAdd, MainToolExcel, MainToolUsers, MainToolPin });
      MainTool.Location = new Point(0, 0);
      MainTool.Name = "MainTool";
      MainTool.Size = new Size(1125, 25);
      MainTool.TabIndex = 2;
      MainTool.Text = "Tool Strip";
      // 
      // MainToolFilterView
      // 
      MainToolFilterView.Checked = true;
      MainToolFilterView.CheckState = CheckState.Checked;
      MainToolFilterView.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolFilterView.ImageTransparentColor = Color.Magenta;
      MainToolFilterView.Name = "MainToolFilterView";
      MainToolFilterView.Size = new Size(23, 22);
      MainToolFilterView.Text = "Show/Hide Filter";
      MainToolFilterView.Click += Action_Click;
      // 
      // MainToolView
      // 
      MainToolView.DropDownItems.AddRange(new ToolStripItem[] { MainToolViewDefault, toolStripSeparator4, MainToolViewManage });
      MainToolView.ImageTransparentColor = Color.Magenta;
      MainToolView.Name = "MainToolView";
      MainToolView.Size = new Size(16, 22);
      MainToolView.ToolTipText = "Filter data";
      MainToolView.Visible = false;
      MainToolView.ButtonClick += Action_Click;
      // 
      // MainToolViewDefault
      // 
      MainToolViewDefault.Name = "MainToolViewDefault";
      MainToolViewDefault.Size = new Size(119, 22);
      MainToolViewDefault.Text = "(default)";
      // 
      // toolStripSeparator4
      // 
      toolStripSeparator4.Name = "toolStripSeparator4";
      toolStripSeparator4.Size = new Size(116, 6);
      // 
      // MainToolViewManage
      // 
      MainToolViewManage.Name = "MainToolViewManage";
      MainToolViewManage.Size = new Size(119, 22);
      MainToolViewManage.Text = "Manage";
      MainToolViewManage.Click += Action_Click;
      // 
      // MainToolRefresh
      // 
      MainToolRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolRefresh.ImageTransparentColor = Color.Magenta;
      MainToolRefresh.Name = "MainToolRefresh";
      MainToolRefresh.Size = new Size(23, 22);
      MainToolRefresh.Text = "Refresh";
      MainToolRefresh.ToolTipText = "Refresh list";
      MainToolRefresh.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(6, 25);
      // 
      // FindField
      // 
      FindField.DisplayStyle = ToolStripItemDisplayStyle.Text;
      FindField.DropDownItems.AddRange(new ToolStripItem[] { FindFieldAllMenu, FindFieldSeparator });
      FindField.Image = (Image)resources.GetObject("FindField.Image");
      FindField.ImageTransparentColor = Color.Magenta;
      FindField.Name = "FindField";
      FindField.ShowDropDownArrow = false;
      FindField.Size = new Size(31, 22);
      FindField.Tag = "";
      FindField.Text = "(all)";
      FindField.ToolTipText = "Filter by field";
      FindField.DropDownOpening += FindField_DropDownOpening;
      // 
      // FindFieldAllMenu
      // 
      FindFieldAllMenu.Name = "FindFieldAllMenu";
      FindFieldAllMenu.Size = new Size(94, 22);
      FindFieldAllMenu.Tag = "";
      FindFieldAllMenu.Text = "(all)";
      FindFieldAllMenu.Click += FindFieldMenu_Click;
      // 
      // FindFieldSeparator
      // 
      FindFieldSeparator.Name = "FindFieldSeparator";
      FindFieldSeparator.Size = new Size(91, 6);
      // 
      // FindText
      // 
      FindText.Name = "FindText";
      FindText.Size = new Size(163, 25);
      FindText.KeyPress += FindText_KeyPress;
      FindText.TextChanged += Action_Click;
      // 
      // MainToolFilter
      // 
      MainToolFilter.DropDownItems.AddRange(new ToolStripItem[] { MainToolFilterPaste, MainToolFilterClear, toolStripSeparator5, MainToolFilterActive });
      MainToolFilter.ImageTransparentColor = Color.Magenta;
      MainToolFilter.Name = "MainToolFilter";
      MainToolFilter.Size = new Size(46, 22);
      MainToolFilter.Text = "Find";
      MainToolFilter.ToolTipText = "Find";
      MainToolFilter.ButtonClick += Action_Click;
      MainToolFilter.DropDownOpening += MainToolFilter_DropDownOpening;
      // 
      // MainToolFilterPaste
      // 
      MainToolFilterPaste.Name = "MainToolFilterPaste";
      MainToolFilterPaste.Size = new Size(141, 22);
      MainToolFilterPaste.Text = "Paste && Find";
      MainToolFilterPaste.Click += Action_Click;
      // 
      // MainToolFilterClear
      // 
      MainToolFilterClear.Name = "MainToolFilterClear";
      MainToolFilterClear.Size = new Size(141, 22);
      MainToolFilterClear.Text = "Clear";
      MainToolFilterClear.Click += Action_Click;
      // 
      // toolStripSeparator5
      // 
      toolStripSeparator5.Name = "toolStripSeparator5";
      toolStripSeparator5.Size = new Size(138, 6);
      // 
      // MainToolFilterActive
      // 
      MainToolFilterActive.Name = "MainToolFilterActive";
      MainToolFilterActive.Size = new Size(141, 22);
      MainToolFilterActive.Text = "Active find";
      MainToolFilterActive.Click += Action_Click;
      // 
      // MainToolPageSep
      // 
      MainToolPageSep.Name = "MainToolPageSep";
      MainToolPageSep.Size = new Size(6, 25);
      // 
      // MainToolPagePrev
      // 
      MainToolPagePrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolPagePrev.Enabled = false;
      MainToolPagePrev.ImageTransparentColor = Color.Magenta;
      MainToolPagePrev.Name = "MainToolPagePrev";
      MainToolPagePrev.Size = new Size(23, 22);
      MainToolPagePrev.Text = "Prev";
      MainToolPagePrev.Click += Action_Click;
      // 
      // MainToolPageNmb
      // 
      MainToolPageNmb.DropDownItems.AddRange(new ToolStripItem[] { MainToolPageGoTo, toolStripSeparator10, MainToolPageConfig });
      MainToolPageNmb.Name = "MainToolPageNmb";
      MainToolPageNmb.ShowDropDownArrow = false;
      MainToolPageNmb.Size = new Size(17, 22);
      MainToolPageNmb.Text = "1";
      MainToolPageNmb.ToolTipText = "Page 1";
      MainToolPageNmb.DropDownOpening += Action_Click;
      // 
      // MainToolPageGoTo
      // 
      MainToolPageGoTo.Name = "MainToolPageGoTo";
      MainToolPageGoTo.Size = new Size(134, 22);
      MainToolPageGoTo.Text = "Go To Page";
      MainToolPageGoTo.Click += Action_Click;
      // 
      // toolStripSeparator10
      // 
      toolStripSeparator10.Name = "toolStripSeparator10";
      toolStripSeparator10.Size = new Size(131, 6);
      // 
      // MainToolPageConfig
      // 
      MainToolPageConfig.Name = "MainToolPageConfig";
      MainToolPageConfig.Size = new Size(134, 22);
      MainToolPageConfig.Text = "Config";
      MainToolPageConfig.Click += Action_Click;
      // 
      // MainToolPageNext
      // 
      MainToolPageNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolPageNext.Enabled = false;
      MainToolPageNext.ImageTransparentColor = Color.Magenta;
      MainToolPageNext.Name = "MainToolPageNext";
      MainToolPageNext.Size = new Size(23, 22);
      MainToolPageNext.Text = "Next";
      MainToolPageNext.Click += Action_Click;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(6, 25);
      // 
      // MainToolDataAdd
      // 
      MainToolDataAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolDataAdd.ImageTransparentColor = Color.Magenta;
      MainToolDataAdd.Name = "MainToolDataAdd";
      MainToolDataAdd.Size = new Size(23, 22);
      MainToolDataAdd.Text = "Add Item";
      MainToolDataAdd.Click += Action_Click;
      // 
      // MainToolExcel
      // 
      MainToolExcel.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolExcel.ImageTransparentColor = Color.Magenta;
      MainToolExcel.Name = "MainToolExcel";
      MainToolExcel.Size = new Size(23, 22);
      MainToolExcel.Text = "Export u Eksel...";
      MainToolExcel.ToolTipText = "Export u Eksel...";
      MainToolExcel.Click += Action_Click;
      // 
      // MainToolUsers
      // 
      MainToolUsers.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolUsers.ImageTransparentColor = Color.Magenta;
      MainToolUsers.Name = "MainToolUsers";
      MainToolUsers.Size = new Size(23, 22);
      MainToolUsers.Text = "Users";
      // 
      // MainToolPin
      // 
      MainToolPin.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MainToolPin.ImageTransparentColor = Color.Magenta;
      MainToolPin.Name = "MainToolPin";
      MainToolPin.Size = new Size(23, 22);
      MainToolPin.Text = "Pin on top";
      MainToolPin.Click += Action_Click;
      // 
      // MainBW
      // 
      MainBW.WorkerReportsProgress = true;
      MainBW.WorkerSupportsCancellation = true;
      MainBW.DoWork += MainBW_DoWork;
      MainBW.ProgressChanged += MainBW_ProgressChanged;
      MainBW.RunWorkerCompleted += MainBW_RunWorkerCompleted;
      // 
      // FilterSplitContainer
      // 
      FilterSplitContainer.Dock = DockStyle.Fill;
      FilterSplitContainer.FixedPanel = FixedPanel.Panel1;
      FilterSplitContainer.Location = new Point(0, 25);
      FilterSplitContainer.Margin = new Padding(4, 3, 4, 3);
      FilterSplitContainer.Name = "FilterSplitContainer";
      // 
      // FilterSplitContainer.Panel1
      // 
      FilterSplitContainer.Panel1.Controls.Add(FilterPanel);
      FilterSplitContainer.Panel1.Controls.Add(FilterCmd);
      FilterSplitContainer.Size = new Size(1125, 481);
      FilterSplitContainer.SplitterDistance = 210;
      FilterSplitContainer.SplitterWidth = 5;
      FilterSplitContainer.TabIndex = 4;
      // 
      // FilterPanel
      // 
      FilterPanel.AutoScroll = true;
      FilterPanel.Dock = DockStyle.Fill;
      FilterPanel.Location = new Point(0, 0);
      FilterPanel.Margin = new Padding(12, 3, 4, 3);
      FilterPanel.Name = "FilterPanel";
      FilterPanel.Size = new Size(210, 446);
      FilterPanel.TabIndex = 0;
      // 
      // FilterCmd
      // 
      FilterCmd.Controls.Add(FilterClearButton);
      FilterCmd.Controls.Add(FilterRefereshButton);
      FilterCmd.Dock = DockStyle.Bottom;
      FilterCmd.Location = new Point(0, 446);
      FilterCmd.Margin = new Padding(4, 3, 4, 3);
      FilterCmd.Name = "FilterCmd";
      FilterCmd.Size = new Size(210, 35);
      FilterCmd.TabIndex = 1;
      // 
      // FilterClearButton
      // 
      FilterClearButton.Location = new Point(4, 3);
      FilterClearButton.Margin = new Padding(4, 3, 4, 3);
      FilterClearButton.Name = "FilterClearButton";
      FilterClearButton.Size = new Size(28, 27);
      FilterClearButton.TabIndex = 1;
      FilterClearButton.Text = "X";
      FilterClearButton.UseVisualStyleBackColor = true;
      FilterClearButton.Click += Action_Click;
      // 
      // FilterRefereshButton
      // 
      FilterRefereshButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      FilterRefereshButton.Location = new Point(38, 3);
      FilterRefereshButton.Margin = new Padding(4, 3, 4, 3);
      FilterRefereshButton.Name = "FilterRefereshButton";
      FilterRefereshButton.Size = new Size(168, 27);
      FilterRefereshButton.TabIndex = 0;
      FilterRefereshButton.Text = "Refresh";
      FilterRefereshButton.UseVisualStyleBackColor = true;
      FilterRefereshButton.Click += Action_Click;
      // 
      // FormList
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1125, 530);
      Controls.Add(FilterSplitContainer);
      Controls.Add(MainTool);
      Controls.Add(StatusBar);
      Controls.Add(MainMenu);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Margin = new Padding(4, 3, 4, 3);
      Name = "FormList";
      StartPosition = FormStartPosition.CenterParent;
      Text = "List";
      FormClosed += FormList_FormClosed;
      Enter += FormList_Enter;
      Leave += FormList_Leave;
      MainMenu.ResumeLayout(false);
      MainMenu.PerformLayout();
      StatusBar.ResumeLayout(false);
      StatusBar.PerformLayout();
      MainTool.ResumeLayout(false);
      MainTool.PerformLayout();
      FilterSplitContainer.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)FilterSplitContainer).EndInit();
      FilterSplitContainer.ResumeLayout(false);
      FilterCmd.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuData;
        private System.Windows.Forms.ToolStripMenuItem MainMenuExport;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStrip MainTool;
        private System.Windows.Forms.ToolStripButton MainToolRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton MainToolView;
        private System.Windows.Forms.ToolStripMenuItem MainToolViewDefault;
        private core.ControlGrid ListGrid;
        private System.ComponentModel.BackgroundWorker MainBW;
        private System.Windows.Forms.ToolStripSeparator MainMenuS3;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ToolStripTextBox FindText;
        private System.Windows.Forms.ToolStripSplitButton MainToolFilter;
        private System.Windows.Forms.ToolStripMenuItem MainToolFilterActive;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private System.Windows.Forms.ToolStripSplitButton MainStatusStat;
        private System.Windows.Forms.ToolStripMenuItem MainMenuView;
        private System.Windows.Forms.ToolStripMenuItem MainStatusStatCount;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MainStatusStatSum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MainToolFilterClear;
        private System.Windows.Forms.ToolStripMenuItem MainToolFilterPaste;
        private System.Windows.Forms.ToolStripMenuItem MainStatusStatHigh;
        private System.Windows.Forms.ToolStripMenuItem MainStatusStatAvg;
        private System.Windows.Forms.ToolStripMenuItem MainStatusStatLow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem FindStripMenu;
		private System.Windows.Forms.ToolStripDropDownButton FindField;
		private System.Windows.Forms.ToolStripMenuItem FindFieldAllMenu;
		private System.Windows.Forms.ToolStripSeparator FindFieldSeparator;
		private System.Windows.Forms.ToolStripMenuItem MainMenuImport;
		private System.Windows.Forms.ToolStripMenuItem MainMenuExcelOpen;
		private System.Windows.Forms.ToolStripSeparator MainMenuS1;
		private System.Windows.Forms.ToolStripMenuItem StatusbarMenu;
		private System.Windows.Forms.ToolStripMenuItem MainStatusStatCopy;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripStatusLabel StatusCapsLock;
		private System.Windows.Forms.ToolStripStatusLabel StatusNumLock;
		private System.Windows.Forms.ToolStripSeparator MainMenuS2;
		private System.Windows.Forms.ToolStripMenuItem MainMenuRefresh;
		private System.Windows.Forms.ToolStripMenuItem MainToolViewManage;
		private System.Windows.Forms.ToolStripMenuItem MainMenuPin;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem MenuHelp;
		private System.Windows.Forms.ToolStripSeparator MainToolPageSep;
		private System.Windows.Forms.ToolStripButton MainToolPagePrev;
		private System.Windows.Forms.ToolStripDropDownButton MainToolPageNmb;
		private System.Windows.Forms.ToolStripButton MainToolPageNext;
		private System.Windows.Forms.ToolStripMenuItem MainToolPageGoTo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripMenuItem MainToolPageConfig;
		private System.Windows.Forms.ToolStripMenuItem MainMenuAdd;
		private System.Windows.Forms.ToolStripMenuItem MainMenuFilter;
		private System.Windows.Forms.ToolStripSeparator MainMenuS0;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton MainToolUsers;
		private System.Windows.Forms.ToolStripMenuItem MainMenuEditor;
    private System.Windows.Forms.ToolStripButton MainToolDataAdd;
    private System.Windows.Forms.SplitContainer FilterSplitContainer;
    private System.Windows.Forms.Panel FilterCmd;
    private System.Windows.Forms.Panel FilterPanel;
    private System.Windows.Forms.ToolStripButton MainToolFilterView;
    private System.Windows.Forms.Button FilterRefereshButton;
    private System.Windows.Forms.ToolStripMenuItem MainManuColumnsShow;
    //private core.ControlFilter FilterList;
    private System.Windows.Forms.ToolStripButton MainToolPin;
    private System.Windows.Forms.Button FilterClearButton;
    private System.Windows.Forms.ToolStripButton MainToolExcel;
  }
}