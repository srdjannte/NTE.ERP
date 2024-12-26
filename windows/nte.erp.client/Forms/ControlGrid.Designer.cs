namespace nte.core
{
    partial class ControlGrid
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
      this.components = new System.ComponentModel.Container();
      this.ListGrid = new System.Windows.Forms.DataGridView();
      this.MenuCell = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MenuCellOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuCellCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuCellAction = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuCellChange = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuCellDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuCellFilter = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuCellIn = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuCellOut = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuHeader = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MenuHeaderVisible = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuHeaderDesign = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuHeaderColumns = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuHeaderColumnsAll = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuHeaderSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.StatsBW = new System.ComponentModel.BackgroundWorker();
      ((System.ComponentModel.ISupportInitialize)(this.ListGrid)).BeginInit();
      this.MenuCell.SuspendLayout();
      this.MenuHeader.SuspendLayout();
      this.SuspendLayout();
      // 
      // ListGrid
      // 
      this.ListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.ListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListGrid.Location = new System.Drawing.Point(0, 0);
      this.ListGrid.Name = "ListGrid";
      this.ListGrid.Size = new System.Drawing.Size(580, 318);
      this.ListGrid.TabIndex = 0;
      this.ListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListGrid_CellContentClick);
      this.ListGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ListGrid_CellFormatting);
      this.ListGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListGrid_CellMouseDoubleClick);
      this.ListGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListGrid_CellMouseDown);
      this.ListGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ListGrid_CellPainting);
      this.ListGrid.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListGrid_ColumnHeaderMouseDoubleClick);
      this.ListGrid.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.ListGrid_ColumnWidthChanged);
      this.ListGrid.SelectionChanged += new System.EventHandler(this.ListGrid_SelectionChanged);
      this.ListGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListGrid_MouseDown);
      // 
      // MenuCell
      // 
      this.MenuCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCellOpen,
            this.MenuCellCopy,
            this.MenuCellAction,
            this.toolStripSeparator1,
            this.MenuCellFilter,
            this.MenuCellIn,
            this.MenuCellOut});
      this.MenuCell.Name = "MenuCell";
      this.MenuCell.Size = new System.Drawing.Size(154, 142);
      this.MenuCell.Opening += new System.ComponentModel.CancelEventHandler(this.MenuCell_Opening);
      // 
      // MenuCellOpen
      // 
      this.MenuCellOpen.Name = "MenuCellOpen";
      this.MenuCellOpen.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.MenuCellOpen.Size = new System.Drawing.Size(153, 22);
      this.MenuCellOpen.Text = "Otvori";
      this.MenuCellOpen.Click += new System.EventHandler(this.MenuCell_Click);
      // 
      // MenuCellCopy
      // 
      //this.MenuCellCopy.Image = global::nte.core.Properties.Resources.copy;
      this.MenuCellCopy.Name = "MenuCellCopy";
      this.MenuCellCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.MenuCellCopy.Size = new System.Drawing.Size(153, 22);
      this.MenuCellCopy.Text = "Kopiraj";
      this.MenuCellCopy.Click += new System.EventHandler(this.MenuCell_Click);
      // 
      // MenuCellAction
      // 
      this.MenuCellAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCellChange,
            this.MenuCellDelete});
      this.MenuCellAction.Name = "MenuCellAction";
      this.MenuCellAction.Size = new System.Drawing.Size(153, 22);
      this.MenuCellAction.Text = "Action";
      // 
      // MenuCellChange
      // 
      this.MenuCellChange.Name = "MenuCellChange";
      this.MenuCellChange.Size = new System.Drawing.Size(115, 22);
      this.MenuCellChange.Text = "Change";
      this.MenuCellChange.Click += new System.EventHandler(this.MenuCell_Click);
      // 
      // MenuCellDelete
      // 
      this.MenuCellDelete.Name = "MenuCellDelete";
      this.MenuCellDelete.Size = new System.Drawing.Size(115, 22);
      this.MenuCellDelete.Text = "Delete";
      this.MenuCellDelete.Click += new System.EventHandler(this.MenuCell_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
      // 
      // MenuCellFilter
      // 
      this.MenuCellFilter.BackColor = System.Drawing.SystemColors.ControlLight;
      this.MenuCellFilter.Enabled = false;
      this.MenuCellFilter.Name = "MenuCellFilter";
      this.MenuCellFilter.Size = new System.Drawing.Size(153, 22);
      this.MenuCellFilter.Text = "Filter";
      // 
      // MenuCellIn
      // 
      this.MenuCellIn.Name = "MenuCellIn";
      this.MenuCellIn.Size = new System.Drawing.Size(153, 22);
      this.MenuCellIn.Text = "Uključi";
      this.MenuCellIn.Click += new System.EventHandler(this.MenuCell_Click);
      // 
      // MenuCellOut
      // 
      this.MenuCellOut.Name = "MenuCellOut";
      this.MenuCellOut.Size = new System.Drawing.Size(153, 22);
      this.MenuCellOut.Text = "Isključi";
      this.MenuCellOut.Click += new System.EventHandler(this.MenuCell_Click);
      // 
      // MenuHeader
      // 
      this.MenuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeaderVisible,
            this.MenuHeaderDesign,
            this.toolStripSeparator4,
            this.MenuHeaderColumns});
      this.MenuHeader.Name = "MenuHeader";
      this.MenuHeader.Size = new System.Drawing.Size(114, 76);
      // 
      // MenuHeaderVisible
      // 
      this.MenuHeaderVisible.Name = "MenuHeaderVisible";
      this.MenuHeaderVisible.Size = new System.Drawing.Size(113, 22);
      this.MenuHeaderVisible.Text = "Vidljivo";
      this.MenuHeaderVisible.Click += new System.EventHandler(this.MenuHeader_Click);
      // 
      // MenuHeaderDesign
      // 
      this.MenuHeaderDesign.Name = "MenuHeaderDesign";
      this.MenuHeaderDesign.Size = new System.Drawing.Size(113, 22);
      this.MenuHeaderDesign.Text = "Style";
      this.MenuHeaderDesign.Visible = false;
      this.MenuHeaderDesign.Click += new System.EventHandler(this.MenuHeader_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(110, 6);
      // 
      // MenuHeaderColumns
      // 
      this.MenuHeaderColumns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHeaderColumnsAll,
            this.MenuHeaderSeparator});
      this.MenuHeaderColumns.Name = "MenuHeaderColumns";
      this.MenuHeaderColumns.Size = new System.Drawing.Size(113, 22);
      this.MenuHeaderColumns.Text = "Kolone";
      // 
      // MenuHeaderColumnsAll
      // 
      this.MenuHeaderColumnsAll.Name = "MenuHeaderColumnsAll";
      this.MenuHeaderColumnsAll.Size = new System.Drawing.Size(115, 22);
      this.MenuHeaderColumnsAll.Text = "Vidi Sve";
      this.MenuHeaderColumnsAll.Click += new System.EventHandler(this.MenuHeader_Click);
      // 
      // MenuHeaderSeparator
      // 
      this.MenuHeaderSeparator.Name = "MenuHeaderSeparator";
      this.MenuHeaderSeparator.Size = new System.Drawing.Size(112, 6);
      // 
      // StatsBW
      // 
      this.StatsBW.WorkerReportsProgress = true;
      this.StatsBW.WorkerSupportsCancellation = true;
      this.StatsBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StatsBW_DoWork);
      this.StatsBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.StatsBW_ProgressChanged);
      this.StatsBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.StatsBW_RunWorkerCompleted);
      // 
      // ControlGrid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ListGrid);
      this.Name = "ControlGrid";
      this.Size = new System.Drawing.Size(580, 318);
      ((System.ComponentModel.ISupportInitialize)(this.ListGrid)).EndInit();
      this.MenuCell.ResumeLayout(false);
      this.MenuHeader.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListGrid;
        private System.Windows.Forms.ContextMenuStrip MenuCell;
        private System.Windows.Forms.ToolStripMenuItem MenuCellCopy;
        private System.Windows.Forms.ContextMenuStrip MenuHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuCellOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuHeaderColumns;
        private System.Windows.Forms.ToolStripMenuItem MenuHeaderColumnsAll;
        private System.Windows.Forms.ToolStripSeparator MenuHeaderSeparator;
        private System.Windows.Forms.ToolStripMenuItem MenuHeaderVisible;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuHeaderDesign;
		private System.Windows.Forms.ToolStripMenuItem MenuCellFilter;
		private System.ComponentModel.BackgroundWorker StatsBW;
		private System.Windows.Forms.ToolStripMenuItem MenuCellAction;
		private System.Windows.Forms.ToolStripMenuItem MenuCellChange;
		private System.Windows.Forms.ToolStripMenuItem MenuCellDelete;
    private System.Windows.Forms.ToolStripMenuItem MenuCellIn;
    private System.Windows.Forms.ToolStripMenuItem MenuCellOut;
  }
}
