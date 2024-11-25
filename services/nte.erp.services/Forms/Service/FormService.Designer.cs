namespace nte.erp.services.invoices
{
  partial class FormService
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
      MenuStrip = new MenuStrip();
      MenuFile = new ToolStripMenuItem();
      MenuFileOpen = new ToolStripMenuItem();
      MenuFileSave = new ToolStripMenuItem();
      toolStripSeparator2 = new ToolStripSeparator();
      MenuFileEditor = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      MenuClose = new ToolStripMenuItem();
      MenuOptions = new ToolStripMenuItem();
      MenuOptionsDebug = new ToolStripMenuItem();
      toolStrip1 = new ToolStrip();
      MenuRefreshStrip = new ToolStripButton();
      toolStripSeparator3 = new ToolStripSeparator();
      MenuAddStrip = new ToolStripDropDownButton();
      MenuAddExportStrip = new ToolStripMenuItem();
      MenuAddImportStrip = new ToolStripMenuItem();
      MenuEditorStrip = new ToolStripButton();
      statusStrip1 = new StatusStrip();
      tabControl1 = new TabControl();
      tpExportTasks = new TabPage();
      listView1 = new ListView();
      colID = new ColumnHeader();
      colStatus = new ColumnHeader();
      colMessage = new ColumnHeader();
      tabPage2 = new TabPage();
      openFileDialog = new OpenFileDialog();
      MenuStrip.SuspendLayout();
      toolStrip1.SuspendLayout();
      tabControl1.SuspendLayout();
      tpExportTasks.SuspendLayout();
      SuspendLayout();
      // 
      // MenuStrip
      // 
      MenuStrip.Items.AddRange(new ToolStripItem[] { MenuFile, MenuOptions });
      MenuStrip.Location = new Point(0, 0);
      MenuStrip.Name = "MenuStrip";
      MenuStrip.Size = new Size(800, 24);
      MenuStrip.TabIndex = 3;
      MenuStrip.Text = "menuStrip1";
      // 
      // MenuFile
      // 
      MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuFileOpen, MenuFileSave, toolStripSeparator2, MenuFileEditor, toolStripSeparator1, MenuClose });
      MenuFile.Name = "MenuFile";
      MenuFile.Size = new Size(37, 20);
      MenuFile.Text = "File";
      MenuFile.DropDownOpening += Action_Click;
      // 
      // MenuFileOpen
      // 
      MenuFileOpen.Name = "MenuFileOpen";
      MenuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
      MenuFileOpen.Size = new Size(195, 22);
      MenuFileOpen.Text = "Open...";
      MenuFileOpen.Click += Action_Click;
      // 
      // MenuFileSave
      // 
      MenuFileSave.Enabled = false;
      MenuFileSave.Name = "MenuFileSave";
      MenuFileSave.ShortcutKeys = Keys.Control | Keys.S;
      MenuFileSave.Size = new Size(195, 22);
      MenuFileSave.Text = "Save As Default";
      MenuFileSave.Click += Action_Click;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(192, 6);
      // 
      // MenuFileEditor
      // 
      MenuFileEditor.Name = "MenuFileEditor";
      MenuFileEditor.Size = new Size(195, 22);
      MenuFileEditor.Text = "Editor";
      MenuFileEditor.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(192, 6);
      // 
      // MenuClose
      // 
      MenuClose.Name = "MenuClose";
      MenuClose.ShortcutKeys = Keys.Alt | Keys.F4;
      MenuClose.Size = new Size(195, 22);
      MenuClose.Text = "Close";
      MenuClose.Click += Action_Click;
      // 
      // MenuOptions
      // 
      MenuOptions.DropDownItems.AddRange(new ToolStripItem[] { MenuOptionsDebug });
      MenuOptions.Name = "MenuOptions";
      MenuOptions.Size = new Size(61, 20);
      MenuOptions.Text = "Options";
      // 
      // MenuOptionsDebug
      // 
      MenuOptionsDebug.Name = "MenuOptionsDebug";
      MenuOptionsDebug.Size = new Size(109, 22);
      MenuOptionsDebug.Text = "Debug";
      MenuOptionsDebug.Click += Action_Click;
      // 
      // toolStrip1
      // 
      toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      toolStrip1.Items.AddRange(new ToolStripItem[] { MenuRefreshStrip, toolStripSeparator3, MenuAddStrip, MenuEditorStrip });
      toolStrip1.Location = new Point(0, 24);
      toolStrip1.Name = "toolStrip1";
      toolStrip1.Size = new Size(800, 25);
      toolStrip1.TabIndex = 4;
      toolStrip1.Text = "toolStrip1";
      // 
      // MenuRefreshStrip
      // 
      MenuRefreshStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
      MenuRefreshStrip.Image = (Image)resources.GetObject("MenuRefreshStrip.Image");
      MenuRefreshStrip.ImageTransparentColor = Color.Magenta;
      MenuRefreshStrip.Name = "MenuRefreshStrip";
      MenuRefreshStrip.Size = new Size(23, 22);
      MenuRefreshStrip.Text = "toolStripButton1";
      MenuRefreshStrip.Click += Action_Click;
      // 
      // toolStripSeparator3
      // 
      toolStripSeparator3.Name = "toolStripSeparator3";
      toolStripSeparator3.Size = new Size(6, 25);
      // 
      // MenuAddStrip
      // 
      MenuAddStrip.DropDownItems.AddRange(new ToolStripItem[] { MenuAddExportStrip, MenuAddImportStrip });
      MenuAddStrip.Image = (Image)resources.GetObject("MenuAddStrip.Image");
      MenuAddStrip.ImageTransparentColor = Color.Magenta;
      MenuAddStrip.Name = "MenuAddStrip";
      MenuAddStrip.Size = new Size(72, 22);
      MenuAddStrip.Text = "Add ID";
      // 
      // MenuAddExportStrip
      // 
      MenuAddExportStrip.Name = "MenuAddExportStrip";
      MenuAddExportStrip.Size = new Size(107, 22);
      MenuAddExportStrip.Text = "Export";
      MenuAddExportStrip.Click += Action_Click;
      // 
      // MenuAddImportStrip
      // 
      MenuAddImportStrip.Name = "MenuAddImportStrip";
      MenuAddImportStrip.Size = new Size(107, 22);
      MenuAddImportStrip.Text = "Inport";
      MenuAddImportStrip.Click += Action_Click;
      // 
      // MenuEditorStrip
      // 
      MenuEditorStrip.DisplayStyle = ToolStripItemDisplayStyle.Text;
      MenuEditorStrip.Image = (Image)resources.GetObject("MenuEditorStrip.Image");
      MenuEditorStrip.ImageTransparentColor = Color.Magenta;
      MenuEditorStrip.Name = "MenuEditorStrip";
      MenuEditorStrip.Size = new Size(42, 22);
      MenuEditorStrip.Text = "Editor";
      MenuEditorStrip.Click += Action_Click;
      // 
      // statusStrip1
      // 
      statusStrip1.Location = new Point(0, 428);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(800, 22);
      statusStrip1.TabIndex = 5;
      statusStrip1.Text = "statusStrip1";
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tpExportTasks);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 49);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(800, 379);
      tabControl1.TabIndex = 6;
      // 
      // tpExportTasks
      // 
      tpExportTasks.Controls.Add(listView1);
      tpExportTasks.Location = new Point(4, 24);
      tpExportTasks.Name = "tpExportTasks";
      tpExportTasks.Padding = new Padding(3);
      tpExportTasks.Size = new Size(792, 351);
      tpExportTasks.TabIndex = 0;
      tpExportTasks.Text = "Export Tasks";
      tpExportTasks.UseVisualStyleBackColor = true;
      // 
      // listView1
      // 
      listView1.BorderStyle = BorderStyle.None;
      listView1.Columns.AddRange(new ColumnHeader[] { colID, colStatus, colMessage });
      listView1.Dock = DockStyle.Fill;
      listView1.FullRowSelect = true;
      listView1.GridLines = true;
      listView1.Location = new Point(3, 3);
      listView1.Name = "listView1";
      listView1.Size = new Size(786, 345);
      listView1.TabIndex = 0;
      listView1.UseCompatibleStateImageBehavior = false;
      listView1.View = View.Details;
      // 
      // colID
      // 
      colID.Text = "ID";
      colID.Width = 40;
      // 
      // colStatus
      // 
      colStatus.Text = "Status";
      // 
      // colMessage
      // 
      colMessage.Text = "Message";
      colMessage.Width = 250;
      // 
      // tabPage2
      // 
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(792, 351);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "Log";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // openFileDialog
      // 
      openFileDialog.DefaultExt = "xml";
      openFileDialog.Filter = "Xml file|*.xml|All files(s)|*.*";
      openFileDialog.Title = "Open File...";
      // 
      // FormService
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(tabControl1);
      Controls.Add(statusStrip1);
      Controls.Add(toolStrip1);
      Controls.Add(MenuStrip);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "FormService";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Service";
      MenuStrip.ResumeLayout(false);
      MenuStrip.PerformLayout();
      toolStrip1.ResumeLayout(false);
      toolStrip1.PerformLayout();
      tabControl1.ResumeLayout(false);
      tpExportTasks.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip MenuStrip;
    private ToolStripMenuItem MenuFile;
    private ToolStripMenuItem MenuFileOpen;
    private ToolStripMenuItem MenuFileSave;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem MenuFileEditor;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem MenuClose;
    private ToolStrip toolStrip1;
    private StatusStrip statusStrip1;
    private TabControl tabControl1;
    private TabPage tpExportTasks;
    private TabPage tabPage2;
    private ToolStripButton MenuRefreshStrip;
    private ToolStripMenuItem MenuOptions;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripButton MenuEditorStrip;
    private ListView listView1;
    private ColumnHeader colID;
    private ColumnHeader colStatus;
    private ColumnHeader colMessage;
    private ToolStripDropDownButton MenuAddStrip;
    private ToolStripMenuItem MenuAddExportStrip;
    private ToolStripMenuItem MenuAddImportStrip;
    private ToolStripMenuItem MenuOptionsDebug;
    private OpenFileDialog openFileDialog;
  }
}