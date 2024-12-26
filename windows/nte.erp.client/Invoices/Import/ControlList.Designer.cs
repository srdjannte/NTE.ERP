namespace nte.erp.client.Invoices.Import
{
  partial class ControlList
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
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlList));
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
      ColId = new DataGridViewTextBoxColumn();
      ColUid = new DataGridViewTextBoxColumn();
      ColDocumentId = new DataGridViewTextBoxColumn();
      ColCustomizationId = new DataGridViewTextBoxColumn();
      ColIssueDate = new DataGridViewTextBoxColumn();
      ColDueDate = new DataGridViewTextBoxColumn();
      ColInvoiceTypeCode = new DataGridViewTextBoxColumn();
      ColDocumentCurrencyCode = new DataGridViewTextBoxColumn();
      ColInvoicePeriodCode = new DataGridViewTextBoxColumn();
      ColAccountingSupplierPartyId = new DataGridViewTextBoxColumn();
      ColAccountingCustomerPartyId = new DataGridViewTextBoxColumn();
      ColActualDeliveryDate = new DataGridViewTextBoxColumn();
      ColPaymentMeansId = new DataGridViewTextBoxColumn();
      ColPaymentMeansCode = new DataGridViewTextBoxColumn();
      ColPaymentId = new DataGridViewTextBoxColumn();
      ColPayerFinancialAccountId = new DataGridViewTextBoxColumn();
      ColPayeeFinancialAccountId = new DataGridViewTextBoxColumn();
      ColTotalAmount = new DataGridViewTextBoxColumn();
      ColNote = new DataGridViewTextBoxColumn();
      ColDocumentReferenceId = new DataGridViewTextBoxColumn();
      ColContractDocumentReferenceId = new DataGridViewTextBoxColumn();
      ColOriginatorDocumentReferenceId = new DataGridViewTextBoxColumn();
      ColOrderReferenceId = new DataGridViewTextBoxColumn();
      ColLines = new DataGridViewTextBoxColumn();
      ColTaxes = new DataGridViewTextBoxColumn();
      ListMenu = new ContextMenuStrip(components);
      ItemOpen = new ToolStripMenuItem();
      ItemNew = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      ItemAdd = new ToolStripMenuItem();
      ItemDelete = new ToolStripMenuItem();
      toolStripSeparator2 = new ToolStripSeparator();
      ItemDown = new ToolStripMenuItem();
      StatusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListGrid).BeginInit();
      ListMenu.SuspendLayout();
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
      ListGrid.AllowUserToAddRows = false;
      ListGrid.AllowUserToDeleteRows = false;
      ListGrid.AllowUserToOrderColumns = true;
      ListGrid.BorderStyle = BorderStyle.None;
      ListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      ListGrid.Columns.AddRange(new DataGridViewColumn[] { ColId, ColUid, ColDocumentId, ColCustomizationId, ColIssueDate, ColDueDate, ColInvoiceTypeCode, ColDocumentCurrencyCode, ColInvoicePeriodCode, ColAccountingSupplierPartyId, ColAccountingCustomerPartyId, ColActualDeliveryDate, ColPaymentMeansId, ColPaymentMeansCode, ColPaymentId, ColPayerFinancialAccountId, ColPayeeFinancialAccountId, ColTotalAmount, ColNote, ColDocumentReferenceId, ColContractDocumentReferenceId, ColOriginatorDocumentReferenceId, ColOrderReferenceId, ColLines, ColTaxes });
      ListGrid.ContextMenuStrip = ListMenu;
      ListGrid.Dock = DockStyle.Fill;
      ListGrid.Location = new Point(0, 0);
      ListGrid.Margin = new Padding(4, 3, 4, 3);
      ListGrid.Name = "ListGrid";
      ListGrid.RowHeadersVisible = false;
      ListGrid.Size = new Size(1033, 455);
      ListGrid.TabIndex = 3;
      // 
      // ColId
      // 
      ColId.DataPropertyName = "Id";
      ColId.HeaderText = "Id";
      ColId.Name = "ColId";
      ColId.ReadOnly = true;
      ColId.Visible = false;
      // 
      // ColUid
      // 
      ColUid.DataPropertyName = "Uid";
      ColUid.HeaderText = "UId";
      ColUid.Name = "ColUid";
      ColUid.Visible = false;
      // 
      // ColDocumentId
      // 
      ColDocumentId.DataPropertyName = "DocumentId";
      ColDocumentId.HeaderText = "DocumentId";
      ColDocumentId.Name = "ColDocumentId";
      ColDocumentId.Visible = false;
      // 
      // ColCustomizationId
      // 
      ColCustomizationId.DataPropertyName = "CustomizationId";
      ColCustomizationId.HeaderText = "CustomizationId";
      ColCustomizationId.Name = "ColCustomizationId";
      // 
      // ColIssueDate
      // 
      ColIssueDate.DataPropertyName = "IssueDate";
      ColIssueDate.HeaderText = "Datum Izdavanja";
      ColIssueDate.Name = "ColIssueDate";
      // 
      // ColDueDate
      // 
      ColDueDate.DataPropertyName = "DueDate";
      ColDueDate.HeaderText = "Datum Dospeca";
      ColDueDate.Name = "ColDueDate";
      // 
      // ColInvoiceTypeCode
      // 
      ColInvoiceTypeCode.DataPropertyName = "InvoiceTypeCode";
      ColInvoiceTypeCode.HeaderText = "Tip Fakture";
      ColInvoiceTypeCode.Name = "ColInvoiceTypeCode";
      // 
      // ColDocumentCurrencyCode
      // 
      ColDocumentCurrencyCode.DataPropertyName = "DocumentCurrencyCode";
      ColDocumentCurrencyCode.HeaderText = "Valuta";
      ColDocumentCurrencyCode.Name = "ColDocumentCurrencyCode";
      // 
      // ColInvoicePeriodCode
      // 
      ColInvoicePeriodCode.DataPropertyName = "InvoicePeriodCode";
      ColInvoicePeriodCode.HeaderText = "InvoicePeriodCode";
      ColInvoicePeriodCode.Name = "ColInvoicePeriodCode";
      ColInvoicePeriodCode.Visible = false;
      // 
      // ColAccountingSupplierPartyId
      // 
      ColAccountingSupplierPartyId.DataPropertyName = "AccountingSupplierPartyId";
      ColAccountingSupplierPartyId.HeaderText = "AccountingSupplierPartyId";
      ColAccountingSupplierPartyId.Name = "ColAccountingSupplierPartyId";
      ColAccountingSupplierPartyId.Visible = false;
      // 
      // ColAccountingCustomerPartyId
      // 
      ColAccountingCustomerPartyId.DataPropertyName = "AccountingCustomerPartyId";
      ColAccountingCustomerPartyId.HeaderText = "AccountingCustomerPartyId";
      ColAccountingCustomerPartyId.Name = "ColAccountingCustomerPartyId";
      ColAccountingCustomerPartyId.Visible = false;
      // 
      // ColActualDeliveryDate
      // 
      ColActualDeliveryDate.DataPropertyName = "ActualDeliveryDate";
      ColActualDeliveryDate.HeaderText = "ActualDeliveryDate";
      ColActualDeliveryDate.Name = "ColActualDeliveryDate";
      // 
      // ColPaymentMeansId
      // 
      ColPaymentMeansId.DataPropertyName = "PaymentMeansId";
      ColPaymentMeansId.HeaderText = "PaymentMeansId";
      ColPaymentMeansId.Name = "ColPaymentMeansId";
      // 
      // ColPaymentMeansCode
      // 
      ColPaymentMeansCode.DataPropertyName = "PaymentMeansCode";
      ColPaymentMeansCode.HeaderText = "PaymentMeansCode";
      ColPaymentMeansCode.Name = "ColPaymentMeansCode";
      // 
      // ColPaymentId
      // 
      ColPaymentId.DataPropertyName = "PaymentId";
      ColPaymentId.HeaderText = "PaymentId";
      ColPaymentId.Name = "ColPaymentId";
      // 
      // ColPayerFinancialAccountId
      // 
      ColPayerFinancialAccountId.HeaderText = "PayerFinancialAccountId";
      ColPayerFinancialAccountId.Name = "ColPayerFinancialAccountId";
      // 
      // ColPayeeFinancialAccountId
      // 
      ColPayeeFinancialAccountId.HeaderText = "PayeeFinancialAccountId";
      ColPayeeFinancialAccountId.Name = "ColPayeeFinancialAccountId";
      // 
      // ColTotalAmount
      // 
      ColTotalAmount.HeaderText = "TotalAmount";
      ColTotalAmount.Name = "ColTotalAmount";
      // 
      // ColNote
      // 
      ColNote.HeaderText = "Note";
      ColNote.Name = "ColNote";
      // 
      // ColDocumentReferenceId
      // 
      ColDocumentReferenceId.HeaderText = "DocumentReferenceId";
      ColDocumentReferenceId.Name = "ColDocumentReferenceId";
      // 
      // ColContractDocumentReferenceId
      // 
      ColContractDocumentReferenceId.HeaderText = "ContractDocumentReferenceId";
      ColContractDocumentReferenceId.Name = "ColContractDocumentReferenceId";
      // 
      // ColOriginatorDocumentReferenceId
      // 
      ColOriginatorDocumentReferenceId.HeaderText = "OriginatorDocumentReferenceId";
      ColOriginatorDocumentReferenceId.Name = "ColOriginatorDocumentReferenceId";
      // 
      // ColOrderReferenceId
      // 
      ColOrderReferenceId.HeaderText = "OrderReferenceId";
      ColOrderReferenceId.Name = "ColOrderReferenceId";
      // 
      // ColLines
      // 
      ColLines.HeaderText = "Lines";
      ColLines.Name = "ColLines";
      // 
      // ColTaxes
      // 
      ColTaxes.HeaderText = "Taxes";
      ColTaxes.Name = "ColTaxes";
      // 
      // ListMenu
      // 
      ListMenu.Items.AddRange(new ToolStripItem[] { ItemOpen, ItemNew, toolStripSeparator1, ItemAdd, ItemDelete, toolStripSeparator2, ItemDown });
      ListMenu.Name = "ListMenu";
      ListMenu.Size = new Size(202, 126);
      // 
      // ItemOpen
      // 
      ItemOpen.Name = "ItemOpen";
      ItemOpen.Size = new Size(201, 22);
      ItemOpen.Text = "Otvori";
      ItemOpen.Click += Action_Click;
      // 
      // ItemNew
      // 
      ItemNew.Name = "ItemNew";
      ItemNew.ShortcutKeys = Keys.Control | Keys.N;
      ItemNew.Size = new Size(201, 22);
      ItemNew.Text = "Nova Faktura";
      ItemNew.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(198, 6);
      // 
      // ItemAdd
      // 
      ItemAdd.Name = "ItemAdd";
      ItemAdd.ShortcutKeys = Keys.Insert;
      ItemAdd.Size = new Size(201, 22);
      ItemAdd.Text = "Add";
      ItemAdd.Click += Action_Click;
      // 
      // ItemDelete
      // 
      ItemDelete.Name = "ItemDelete";
      ItemDelete.ShortcutKeys = Keys.Delete;
      ItemDelete.Size = new Size(201, 22);
      ItemDelete.Text = "Izbrisi";
      ItemDelete.Click += Action_Click;
      // 
      // toolStripSeparator2
      // 
      toolStripSeparator2.Name = "toolStripSeparator2";
      toolStripSeparator2.Size = new Size(198, 6);
      // 
      // ItemDown
      // 
      ItemDown.Name = "ItemDown";
      ItemDown.ShortcutKeys = Keys.Control | Keys.D;
      ItemDown.Size = new Size(201, 22);
      ItemDown.Text = "Preuzmi Fakture";
      ItemDown.Click += Action_Click;
      // 
      // ControlList
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(ListGrid);
      Controls.Add(StatusBar);
      Name = "ControlList";
      Size = new Size(1033, 479);
      StatusBar.ResumeLayout(false);
      StatusBar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)ListGrid).EndInit();
      ListMenu.ResumeLayout(false);
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
    private DataGridViewTextBoxColumn ColId;
    private DataGridViewTextBoxColumn ColUid;
    private DataGridViewTextBoxColumn ColDocumentId;
    private DataGridViewTextBoxColumn ColCustomizationId;
    private DataGridViewTextBoxColumn ColIssueDate;
    private DataGridViewTextBoxColumn ColDueDate;
    private DataGridViewTextBoxColumn ColInvoiceTypeCode;
    private DataGridViewTextBoxColumn ColDocumentCurrencyCode;
    private DataGridViewTextBoxColumn ColInvoicePeriodCode;
    private DataGridViewTextBoxColumn ColAccountingSupplierPartyId;
    private DataGridViewTextBoxColumn ColAccountingCustomerPartyId;
    private DataGridViewTextBoxColumn ColActualDeliveryDate;
    private DataGridViewTextBoxColumn ColPaymentMeansId;
    private DataGridViewTextBoxColumn ColPaymentMeansCode;
    private DataGridViewTextBoxColumn ColPaymentId;
    private DataGridViewTextBoxColumn ColPayerFinancialAccountId;
    private DataGridViewTextBoxColumn ColPayeeFinancialAccountId;
    private DataGridViewTextBoxColumn ColTotalAmount;
    private DataGridViewTextBoxColumn ColNote;
    private DataGridViewTextBoxColumn ColDocumentReferenceId;
    private DataGridViewTextBoxColumn ColContractDocumentReferenceId;
    private DataGridViewTextBoxColumn ColOriginatorDocumentReferenceId;
    private DataGridViewTextBoxColumn ColOrderReferenceId;
    private DataGridViewTextBoxColumn ColLines;
    private DataGridViewTextBoxColumn ColTaxes;
    private ContextMenuStrip ListMenu;
    private ToolStripMenuItem ItemAdd;
    private ToolStripMenuItem ItemNew;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem ItemDown;
    private ToolStripMenuItem ItemDelete;
    private ToolStripMenuItem ItemOpen;
  }
}
