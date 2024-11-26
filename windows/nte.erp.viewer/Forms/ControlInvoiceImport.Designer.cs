namespace nte.erp.viewer
{
  partial class ControlInvoiceImport
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlInvoiceImport));
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
      ListGrid = new DataGridView();
      Column1 = new DataGridViewTextBoxColumn();
      Column2 = new DataGridViewTextBoxColumn();
      Column3 = new DataGridViewTextBoxColumn();
      Column4 = new DataGridViewTextBoxColumn();
      Column5 = new DataGridViewTextBoxColumn();
      StatusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListGrid).BeginInit();
      SuspendLayout();
      // 
      // StatusBar
      // 
      StatusBar.Items.AddRange(new ToolStripItem[] { MainStatusLabel, StatusCapsLock, StatusNumLock, MainStatusState, MainStatusStat, toolStripStatusLabel1 });
      StatusBar.Location = new Point(0, 455);
      StatusBar.Name = "StatusBar";
      StatusBar.Padding = new Padding(1, 0, 16, 0);
      StatusBar.Size = new Size(1033, 24);
      StatusBar.TabIndex = 2;
      StatusBar.Text = "Infomartions";
      // 
      // MainStatusLabel
      // 
      MainStatusLabel.Name = "MainStatusLabel";
      MainStatusLabel.Size = new Size(780, 19);
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
      // 
      // MainStatusStatCopy
      // 
      MainStatusStatCopy.Name = "MainStatusStatCopy";
      MainStatusStatCopy.Size = new Size(107, 22);
      MainStatusStatCopy.Text = "Copy";
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
      // 
      // MainStatusStatAvg
      // 
      MainStatusStatAvg.Name = "MainStatusStatAvg";
      MainStatusStatAvg.Size = new Size(107, 22);
      MainStatusStatAvg.Tag = "Avg";
      MainStatusStatAvg.Text = "Avg";
      // 
      // MainStatusStatLow
      // 
      MainStatusStatLow.Name = "MainStatusStatLow";
      MainStatusStatLow.Size = new Size(107, 22);
      MainStatusStatLow.Tag = "Min";
      MainStatusStatLow.Text = "Min";
      // 
      // MainStatusStatSum
      // 
      MainStatusStatSum.Name = "MainStatusStatSum";
      MainStatusStatSum.Size = new Size(107, 22);
      MainStatusStatSum.Tag = "Sum";
      MainStatusStatSum.Text = "Sum";
      // 
      // MainStatusStatCount
      // 
      MainStatusStatCount.Name = "MainStatusStatCount";
      MainStatusStatCount.Size = new Size(107, 22);
      MainStatusStatCount.Tag = "Count";
      MainStatusStatCount.Text = "Count";
      // 
      // toolStripStatusLabel1
      // 
      toolStripStatusLabel1.AutoSize = false;
      toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      toolStripStatusLabel1.Size = new Size(30, 19);
      // 
      // ListGrid
      // 
      ListGrid.BorderStyle = BorderStyle.None;
      ListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ListGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
      ListGrid.Dock = DockStyle.Fill;
      ListGrid.Location = new Point(0, 0);
      ListGrid.Margin = new Padding(4, 3, 4, 3);
      ListGrid.Name = "ListGrid";
      ListGrid.Size = new Size(1033, 455);
      ListGrid.TabIndex = 3;
      // 
      // Column1
      // 
      Column1.DataPropertyName = "InvoiceId";
      Column1.HeaderText = "InvoiceId";
      Column1.Name = "Column1";
      // 
      // Column2
      // 
      Column2.HeaderText = "Column2";
      Column2.Name = "Column2";
      // 
      // Column3
      // 
      Column3.HeaderText = "Column3";
      Column3.Name = "Column3";
      // 
      // Column4
      // 
      Column4.HeaderText = "Column4";
      Column4.Name = "Column4";
      // 
      // Column5
      // 
      Column5.HeaderText = "Column5";
      Column5.Name = "Column5";
      // 
      // ControlInvoiceImport
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(ListGrid);
      Controls.Add(StatusBar);
      Name = "ControlInvoiceImport";
      Size = new Size(1033, 479);
      StatusBar.ResumeLayout(false);
      StatusBar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ListGrid).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private StatusStrip StatusBar;
    private ToolStripStatusLabel MainStatusLabel;
    private ToolStripStatusLabel StatusCapsLock;
    private ToolStripStatusLabel StatusNumLock;
    private ToolStripStatusLabel MainStatusState;
    private ToolStripSplitButton MainStatusStat;
    private ToolStripMenuItem MainStatusStatCopy;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem MainStatusStatHigh;
    private ToolStripMenuItem MainStatusStatAvg;
    private ToolStripMenuItem MainStatusStatLow;
    private ToolStripMenuItem MainStatusStatSum;
    private ToolStripMenuItem MainStatusStatCount;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private DataGridView ListGrid;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
  }
}
