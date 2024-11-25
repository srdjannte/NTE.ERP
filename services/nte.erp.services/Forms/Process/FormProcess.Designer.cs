namespace nte.erp.services.invoices
{
  partial class FormProcess
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
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcess));
      ItemTitle = new Label();
      ItemProgress = new ProgressBar();
      doClose = new Button();
      ItemMessage = new Label();
      NTELink = new LinkLabel();
      doItemConfig = new LinkLabel();
      IL16 = new ImageList(components);
      doStop = new LinkLabel();
      doConfig = new Button();
      ConfigMenu = new ContextMenuStrip(components);
      doOpenFile = new ToolStripMenuItem();
      doClearConfig = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      doService = new ToolStripMenuItem();
      doEditor = new ToolStripMenuItem();
      ItemWorker = new System.ComponentModel.BackgroundWorker();
      CloseTimer = new System.Windows.Forms.Timer(components);
      doRepeat = new LinkLabel();
      doManualExec = new Button();
      ManualID = new TextBox();
      OpenXmlDalog = new OpenFileDialog();
      button1 = new Button();
      button2 = new Button();
      ConfigMenu.SuspendLayout();
      SuspendLayout();
      // 
      // ItemTitle
      // 
      ItemTitle.AutoSize = true;
      ItemTitle.Location = new Point(12, 9);
      ItemTitle.Name = "ItemTitle";
      ItemTitle.Size = new Size(107, 15);
      ItemTitle.TabIndex = 0;
      ItemTitle.Text = "Not Configuration!";
      // 
      // ItemProgress
      // 
      ItemProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      ItemProgress.Location = new Point(12, 27);
      ItemProgress.Name = "ItemProgress";
      ItemProgress.Size = new Size(372, 23);
      ItemProgress.TabIndex = 1;
      // 
      // doClose
      // 
      doClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      doClose.Location = new Point(293, 85);
      doClose.Name = "doClose";
      doClose.Size = new Size(91, 23);
      doClose.TabIndex = 2;
      doClose.Text = "Close";
      doClose.UseVisualStyleBackColor = true;
      doClose.Click += Action_Click;
      // 
      // ItemMessage
      // 
      ItemMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      ItemMessage.Location = new Point(12, 55);
      ItemMessage.Name = "ItemMessage";
      ItemMessage.Size = new Size(372, 27);
      ItemMessage.TabIndex = 3;
      ItemMessage.Text = "...";
      // 
      // NTELink
      // 
      NTELink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      NTELink.AutoSize = true;
      NTELink.LinkBehavior = LinkBehavior.HoverUnderline;
      NTELink.LinkColor = Color.Gray;
      NTELink.Location = new Point(12, 93);
      NTELink.Name = "NTELink";
      NTELink.Size = new Size(71, 15);
      NTELink.TabIndex = 4;
      NTELink.TabStop = true;
      NTELink.Text = "NTE eRacun";
      NTELink.Click += Action_Click;
      // 
      // doItemConfig
      // 
      doItemConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doItemConfig.ImageAlign = ContentAlignment.MiddleRight;
      doItemConfig.ImageKey = "gear";
      doItemConfig.LinkBehavior = LinkBehavior.HoverUnderline;
      doItemConfig.Location = new Point(233, 6);
      doItemConfig.Name = "doItemConfig";
      doItemConfig.Size = new Size(122, 15);
      doItemConfig.TabIndex = 5;
      doItemConfig.TabStop = true;
      doItemConfig.Text = "none";
      doItemConfig.TextAlign = ContentAlignment.MiddleRight;
      doItemConfig.Click += Action_Click;
      // 
      // IL16
      // 
      IL16.ColorDepth = ColorDepth.Depth32Bit;
      IL16.ImageStream = (ImageListStreamer)resources.GetObject("IL16.ImageStream");
      IL16.TransparentColor = Color.Transparent;
      IL16.Images.SetKeyName(0, "gear");
      IL16.Images.SetKeyName(1, "gear_information");
      IL16.Images.SetKeyName(2, "gear_ok");
      IL16.Images.SetKeyName(3, "gear_warning");
      IL16.Images.SetKeyName(4, "gear_stop");
      IL16.Images.SetKeyName(5, "gear_run");
      // 
      // doStop
      // 
      doStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      doStop.AutoSize = true;
      doStop.LinkBehavior = LinkBehavior.HoverUnderline;
      doStop.Location = new Point(257, 89);
      doStop.Name = "doStop";
      doStop.Size = new Size(30, 15);
      doStop.TabIndex = 6;
      doStop.TabStop = true;
      doStop.Text = "stop";
      doStop.TextAlign = ContentAlignment.MiddleRight;
      doStop.Visible = false;
      doStop.Click += Action_Click;
      // 
      // doConfig
      // 
      doConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      doConfig.ContextMenuStrip = ConfigMenu;
      doConfig.FlatAppearance.BorderSize = 0;
      doConfig.FlatStyle = FlatStyle.Flat;
      doConfig.ImageKey = "gear";
      doConfig.ImageList = IL16;
      doConfig.Location = new Point(359, 2);
      doConfig.Name = "doConfig";
      doConfig.Size = new Size(23, 23);
      doConfig.TabIndex = 7;
      doConfig.UseVisualStyleBackColor = true;
      doConfig.Click += Action_Click;
      // 
      // ConfigMenu
      // 
      ConfigMenu.Items.AddRange(new ToolStripItem[] { doOpenFile, doClearConfig, toolStripSeparator1, doService, doEditor });
      ConfigMenu.Name = "ConfigMenu";
      ConfigMenu.Size = new Size(179, 98);
      // 
      // doOpenFile
      // 
      doOpenFile.Name = "doOpenFile";
      doOpenFile.Size = new Size(178, 22);
      doOpenFile.Text = "Load Configuration";
      doOpenFile.Click += Action_Click;
      // 
      // doClearConfig
      // 
      doClearConfig.Name = "doClearConfig";
      doClearConfig.Size = new Size(178, 22);
      doClearConfig.Text = "Clear Configuration";
      doClearConfig.Visible = false;
      doClearConfig.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(175, 6);
      // 
      // doService
      // 
      doService.Name = "doService";
      doService.Size = new Size(178, 22);
      doService.Text = "Show Service";
      doService.Click += Action_Click;
      // 
      // doEditor
      // 
      doEditor.Name = "doEditor";
      doEditor.Size = new Size(178, 22);
      doEditor.Text = "Show Editor";
      doEditor.Click += Action_Click;
      // 
      // ItemWorker
      // 
      ItemWorker.WorkerReportsProgress = true;
      ItemWorker.WorkerSupportsCancellation = true;
      ItemWorker.DoWork += ItemWorker_DoWork;
      ItemWorker.ProgressChanged += ItemWorker_ProgressChanged;
      ItemWorker.RunWorkerCompleted += ItemWorker_RunWorkerCompleted;
      // 
      // CloseTimer
      // 
      CloseTimer.Interval = 1000;
      CloseTimer.Tick += CloseTimer_Tick;
      // 
      // doRepeat
      // 
      doRepeat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      doRepeat.AutoSize = true;
      doRepeat.LinkBehavior = LinkBehavior.HoverUnderline;
      doRepeat.Location = new Point(244, 89);
      doRepeat.Name = "doRepeat";
      doRepeat.Size = new Size(43, 15);
      doRepeat.TabIndex = 8;
      doRepeat.TabStop = true;
      doRepeat.Text = "Repeat";
      doRepeat.TextAlign = ContentAlignment.MiddleRight;
      doRepeat.Visible = false;
      doRepeat.Click += Action_Click;
      // 
      // doManualExec
      // 
      doManualExec.FlatAppearance.BorderSize = 0;
      doManualExec.FlatStyle = FlatStyle.Flat;
      doManualExec.Image = (Image)resources.GetObject("doManualExec.Image");
      doManualExec.Location = new Point(73, 28);
      doManualExec.Name = "doManualExec";
      doManualExec.Size = new Size(27, 21);
      doManualExec.TabIndex = 9;
      doManualExec.UseVisualStyleBackColor = true;
      doManualExec.Click += Action_Click;
      // 
      // ManualID
      // 
      ManualID.Location = new Point(12, 27);
      ManualID.Name = "ManualID";
      ManualID.Size = new Size(55, 23);
      ManualID.TabIndex = 10;
      // 
      // OpenXmlDalog
      // 
      OpenXmlDalog.DefaultExt = "xml";
      OpenXmlDalog.Title = "Open Config File";
      // 
      // button1
      // 
      button1.Location = new Point(89, 85);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 11;
      button1.Text = "button1";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Location = new Point(170, 85);
      button2.Name = "button2";
      button2.Size = new Size(75, 23);
      button2.TabIndex = 12;
      button2.Text = "button2";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // FormProcess
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = doClose;
      ClientSize = new Size(396, 118);
      ContextMenuStrip = ConfigMenu;
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(ManualID);
      Controls.Add(doManualExec);
      Controls.Add(doRepeat);
      Controls.Add(doConfig);
      Controls.Add(doStop);
      Controls.Add(NTELink);
      Controls.Add(ItemMessage);
      Controls.Add(doClose);
      Controls.Add(ItemProgress);
      Controls.Add(ItemTitle);
      Controls.Add(doItemConfig);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "FormProcess";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Process";
      ConfigMenu.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label ItemTitle;
    private ProgressBar ItemProgress;
    private Button doClose;
    private Label ItemMessage;
    private LinkLabel NTELink;
    private LinkLabel doItemConfig;
    private LinkLabel doStop;
    private ImageList IL16;
    private Button doConfig;
    private System.ComponentModel.BackgroundWorker ItemWorker;
    private System.Windows.Forms.Timer CloseTimer;
    private LinkLabel doRepeat;
    private ContextMenuStrip ConfigMenu;
    private ToolStripMenuItem doOpenFile;
    private ToolStripMenuItem doClearConfig;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem doEditor;
    private Button doManualExec;
    private TextBox ManualID;
    private OpenFileDialog OpenXmlDalog;
    private ToolStripMenuItem doService;
    private Button button1;
    private Button button2;
  }
}