namespace nte.erp.services.invoices
{
  partial class ControlExportValidation
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
      ListGrid = new DataGridView();
      ColKind = new DataGridViewTextBoxColumn();
      ColFields = new DataGridViewTextBoxColumn();
      ColIsEmpty = new DataGridViewTextBoxColumn();
      ColValidation = new DataGridViewTextBoxColumn();
      ColMessage = new DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)ListGrid).BeginInit();
      SuspendLayout();
      // 
      // ListGrid
      // 
      ListGrid.AllowUserToAddRows = false;
      ListGrid.AllowUserToDeleteRows = false;
      ListGrid.AllowUserToResizeRows = false;
      ListGrid.BackgroundColor = SystemColors.Window;
      ListGrid.BorderStyle = BorderStyle.None;
      ListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ListGrid.Columns.AddRange(new DataGridViewColumn[] { ColKind, ColFields, ColIsEmpty, ColValidation, ColMessage });
      ListGrid.Dock = DockStyle.Fill;
      ListGrid.Location = new Point(0, 0);
      ListGrid.Name = "ListGrid";
      ListGrid.RowHeadersVisible = false;
      ListGrid.Size = new Size(781, 234);
      ListGrid.TabIndex = 0;
      // 
      // ColKind
      // 
      ColKind.Frozen = true;
      ColKind.HeaderText = "Kind";
      ColKind.Name = "ColKind";
      // 
      // ColFields
      // 
      ColFields.Frozen = true;
      ColFields.HeaderText = "Fields";
      ColFields.Name = "ColFields";
      // 
      // ColIsEmpty
      // 
      ColIsEmpty.Frozen = true;
      ColIsEmpty.HeaderText = "Is Empty";
      ColIsEmpty.Name = "ColIsEmpty";
      // 
      // ColValidation
      // 
      ColValidation.Frozen = true;
      ColValidation.HeaderText = "Validation";
      ColValidation.Name = "ColValidation";
      // 
      // ColMessage
      // 
      ColMessage.Frozen = true;
      ColMessage.HeaderText = "Message";
      ColMessage.Name = "ColMessage";
      // 
      // ControlExportValidation
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(ListGrid);
      Name = "ControlExportValidation";
      Size = new Size(781, 234);
      ((System.ComponentModel.ISupportInitialize)ListGrid).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private DataGridView ListGrid;
    private DataGridViewTextBoxColumn ColKind;
    private DataGridViewTextBoxColumn ColFields;
    private DataGridViewTextBoxColumn ColIsEmpty;
    private DataGridViewTextBoxColumn ColValidation;
    private DataGridViewTextBoxColumn ColMessage;
  }
}
