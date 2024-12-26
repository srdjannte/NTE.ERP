namespace nte.erp.client.Common
{
	partial class FormLanguage
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
      toolStrip1 = new ToolStrip();
      doSave = new ToolStripButton();
      toolStripSeparator1 = new ToolStripSeparator();
      FormNameSelected = new ToolStripComboBox();
      doRefresh = new ToolStripButton();
      LangGrid = new DataGridView();
      toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)LangGrid).BeginInit();
      SuspendLayout();
      // 
      // toolStrip1
      // 
      toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      toolStrip1.Items.AddRange(new ToolStripItem[] { doSave, toolStripSeparator1, FormNameSelected, doRefresh });
      toolStrip1.Location = new Point(0, 0);
      toolStrip1.Name = "toolStrip1";
      toolStrip1.Size = new Size(1227, 25);
      toolStrip1.TabIndex = 0;
      toolStrip1.Text = "toolStrip1";
      // 
      // doSave
      // 
      doSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
      doSave.ImageTransparentColor = Color.Magenta;
      doSave.Name = "doSave";
      doSave.Size = new Size(23, 22);
      doSave.Text = "Save";
      doSave.ToolTipText = "Save Changes";
      doSave.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(6, 25);
      // 
      // FormNameSelected
      // 
      FormNameSelected.Name = "FormNameSelected";
      FormNameSelected.Size = new Size(140, 25);
      // 
      // doRefresh
      // 
      doRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
      doRefresh.ImageTransparentColor = Color.Magenta;
      doRefresh.Name = "doRefresh";
      doRefresh.Size = new Size(23, 22);
      doRefresh.Text = "Refresh";
      // 
      // LangGrid
      // 
      LangGrid.AllowUserToAddRows = false;
      LangGrid.AllowUserToDeleteRows = false;
      LangGrid.AllowUserToResizeRows = false;
      LangGrid.BorderStyle = BorderStyle.None;
      LangGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      LangGrid.Dock = DockStyle.Fill;
      LangGrid.Location = new Point(0, 25);
      LangGrid.Margin = new Padding(4, 3, 4, 3);
      LangGrid.Name = "LangGrid";
      LangGrid.Size = new Size(1227, 503);
      LangGrid.StandardTab = true;
      LangGrid.TabIndex = 1;
      // 
      // FormLanguage
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1227, 528);
      Controls.Add(LangGrid);
      Controls.Add(toolStrip1);
      FormBorderStyle = FormBorderStyle.SizableToolWindow;
      Margin = new Padding(4, 3, 4, 3);
      Name = "FormLanguage";
      Text = "Language";
      toolStrip1.ResumeLayout(false);
      toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)LangGrid).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton doRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton doSave;
		private System.Windows.Forms.DataGridView LangGrid;
		private System.Windows.Forms.ToolStripComboBox FormNameSelected;
	}
}