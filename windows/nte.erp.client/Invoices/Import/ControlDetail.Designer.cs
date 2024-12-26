namespace nte.erp.client.Invoices.Import
{
  partial class ControlDetail
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
      MainTabControl = new TabControl();
      tpLines = new TabPage();
      LinesGrid = new DataGridView();
      ColLineID = new DataGridViewTextBoxColumn();
      ColLineItemName = new DataGridViewTextBoxColumn();
      ColLineInvoicedQuantity = new DataGridViewTextBoxColumn();
      ColLineLineExtensionAmount = new DataGridViewTextBoxColumn();
      ColLineItemClassifiedTaxCategory = new DataGridViewTextBoxColumn();
      ColLineItemBaseQuantity = new DataGridViewTextBoxColumn();
      ColLineItemClassifiedTaxCategoryPercent = new DataGridViewTextBoxColumn();
      ColLineItemClassifiedTaxCategoryID = new DataGridViewTextBoxColumn();
      ColLineItemClassifiedTaxCategoryTaxSchemeID = new DataGridViewTextBoxColumn();
      ColLineItemPriceAmount = new DataGridViewTextBoxColumn();
      tpTaxes = new TabPage();
      tpDokumenta = new TabPage();
      tpHistory = new TabPage();
      CustomerPanel = new Panel();
      DatePanel = new Panel();
      TaxDatePanel = new Panel();
      TaxDateLabel = new Label();
      TaxDate = new LinkLabel();
      DueDatePanel = new Panel();
      DueDateLabel = new Label();
      DueDate = new LinkLabel();
      IssueDatePanel = new Panel();
      IssueDateLabel = new Label();
      IssueDate = new LinkLabel();
      CustomerPartyFinPanel = new Panel();
      CustomerPartyPIBLabel = new Label();
      CustomerPartyPIB = new LinkLabel();
      CustomerPartyMBLabel = new Label();
      CustomerPartyMB = new LinkLabel();
      CustomerPartyName = new LinkLabel();
      CustomerPartyLabel = new Label();
      InvoiceID = new Label();
      SupplierPanel = new Panel();
      SupplierPartyPaymentPanel = new Panel();
      SupplierPartyPaymentBank = new LinkLabel();
      SupplierPartyPaymentBankLabel = new Label();
      SupplierPartyPaymentType = new LinkLabel();
      SupplierPartyPaymentTypeLabel = new Label();
      SupplierPartyContact = new Label();
      SupplierPartyAddress = new Label();
      SupplierPartyFinPanel = new Panel();
      SupplierPartyMB = new LinkLabel();
      SupplierPartyMBLabel = new Label();
      SupplierPartyPIB = new LinkLabel();
      SupplierPartyPIBLabel = new Label();
      SupplierPartyName = new LinkLabel();
      SupplierPartyLabel = new Label();
      InvoiceIDLeft = new Label();
      LegalMonetaryTotalPanel = new Panel();
      LineExtensionAmountPanel = new Panel();
      LineExtensionAmountLabel = new Label();
      LineExtensionAmount = new Label();
      LineExtensionAmountCurrency = new Label();
      TaxInclusiveAmountPanel = new Panel();
      TaxInclusiveAmountLabel = new Label();
      TaxAmount = new Label();
      TaxInclusiveAmountCurrency = new Label();
      PayableAmountPanel = new Panel();
      PayableAmountLabel = new Label();
      PayableAmount = new Label();
      PayableAmountCurrency = new Label();
      MainTabControl.SuspendLayout();
      tpLines.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)LinesGrid).BeginInit();
      CustomerPanel.SuspendLayout();
      DatePanel.SuspendLayout();
      TaxDatePanel.SuspendLayout();
      DueDatePanel.SuspendLayout();
      IssueDatePanel.SuspendLayout();
      CustomerPartyFinPanel.SuspendLayout();
      SupplierPanel.SuspendLayout();
      SupplierPartyPaymentPanel.SuspendLayout();
      SupplierPartyFinPanel.SuspendLayout();
      LegalMonetaryTotalPanel.SuspendLayout();
      LineExtensionAmountPanel.SuspendLayout();
      TaxInclusiveAmountPanel.SuspendLayout();
      PayableAmountPanel.SuspendLayout();
      SuspendLayout();
      // 
      // MainTabControl
      // 
      MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      MainTabControl.Appearance = TabAppearance.FlatButtons;
      MainTabControl.Controls.Add(tpLines);
      MainTabControl.Controls.Add(tpTaxes);
      MainTabControl.Controls.Add(tpDokumenta);
      MainTabControl.Controls.Add(tpHistory);
      MainTabControl.Location = new Point(3, 194);
      MainTabControl.Name = "MainTabControl";
      MainTabControl.SelectedIndex = 0;
      MainTabControl.Size = new Size(945, 294);
      MainTabControl.TabIndex = 20;
      // 
      // tpLines
      // 
      tpLines.Controls.Add(LinesGrid);
      tpLines.Location = new Point(4, 27);
      tpLines.Name = "tpLines";
      tpLines.Padding = new Padding(3);
      tpLines.Size = new Size(937, 263);
      tpLines.TabIndex = 0;
      tpLines.Text = "Stavke";
      tpLines.UseVisualStyleBackColor = true;
      // 
      // LinesGrid
      // 
      LinesGrid.AllowUserToAddRows = false;
      LinesGrid.AllowUserToDeleteRows = false;
      LinesGrid.AllowUserToOrderColumns = true;
      LinesGrid.AllowUserToResizeRows = false;
      LinesGrid.BackgroundColor = SystemColors.Control;
      LinesGrid.BorderStyle = BorderStyle.None;
      LinesGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
      LinesGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
      LinesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      LinesGrid.Columns.AddRange(new DataGridViewColumn[] { ColLineID, ColLineItemName, ColLineInvoicedQuantity, ColLineLineExtensionAmount, ColLineItemClassifiedTaxCategory, ColLineItemBaseQuantity, ColLineItemClassifiedTaxCategoryPercent, ColLineItemClassifiedTaxCategoryID, ColLineItemClassifiedTaxCategoryTaxSchemeID, ColLineItemPriceAmount });
      LinesGrid.Dock = DockStyle.Fill;
      LinesGrid.Location = new Point(3, 3);
      LinesGrid.Name = "LinesGrid";
      LinesGrid.RowHeadersVisible = false;
      LinesGrid.Size = new Size(931, 257);
      LinesGrid.TabIndex = 11;
      // 
      // ColLineID
      // 
      ColLineID.DataPropertyName = "ID";
      ColLineID.Frozen = true;
      ColLineID.HeaderText = "#";
      ColLineID.Name = "ColLineID";
      ColLineID.Width = 40;
      // 
      // ColLineItemName
      // 
      ColLineItemName.HeaderText = "Naziv";
      ColLineItemName.MinimumWidth = 40;
      ColLineItemName.Name = "ColLineItemName";
      ColLineItemName.Width = 200;
      // 
      // ColLineInvoicedQuantity
      // 
      ColLineInvoicedQuantity.DataPropertyName = "InvoicedQuantity";
      ColLineInvoicedQuantity.HeaderText = "Kol";
      ColLineInvoicedQuantity.Name = "ColLineInvoicedQuantity";
      // 
      // ColLineLineExtensionAmount
      // 
      ColLineLineExtensionAmount.DataPropertyName = "LineExtensionAmount";
      ColLineLineExtensionAmount.HeaderText = "LineExtensionAmount";
      ColLineLineExtensionAmount.Name = "ColLineLineExtensionAmount";
      ColLineLineExtensionAmount.Visible = false;
      // 
      // ColLineItemClassifiedTaxCategory
      // 
      ColLineItemClassifiedTaxCategory.DataPropertyName = "ClassifiedTaxCategory";
      ColLineItemClassifiedTaxCategory.HeaderText = "ClassifiedTaxCategory";
      ColLineItemClassifiedTaxCategory.Name = "ColLineItemClassifiedTaxCategory";
      ColLineItemClassifiedTaxCategory.Visible = false;
      // 
      // ColLineItemBaseQuantity
      // 
      ColLineItemBaseQuantity.HeaderText = "ColLineItemBaseQuantity";
      ColLineItemBaseQuantity.Name = "ColLineItemBaseQuantity";
      ColLineItemBaseQuantity.Visible = false;
      // 
      // ColLineItemClassifiedTaxCategoryPercent
      // 
      ColLineItemClassifiedTaxCategoryPercent.HeaderText = "ColLineItemClassifiedTaxCategoryPercent";
      ColLineItemClassifiedTaxCategoryPercent.Name = "ColLineItemClassifiedTaxCategoryPercent";
      ColLineItemClassifiedTaxCategoryPercent.Visible = false;
      // 
      // ColLineItemClassifiedTaxCategoryID
      // 
      ColLineItemClassifiedTaxCategoryID.HeaderText = "Cat";
      ColLineItemClassifiedTaxCategoryID.Name = "ColLineItemClassifiedTaxCategoryID";
      ColLineItemClassifiedTaxCategoryID.Visible = false;
      // 
      // ColLineItemClassifiedTaxCategoryTaxSchemeID
      // 
      ColLineItemClassifiedTaxCategoryTaxSchemeID.HeaderText = "PDV";
      ColLineItemClassifiedTaxCategoryTaxSchemeID.Name = "ColLineItemClassifiedTaxCategoryTaxSchemeID";
      // 
      // ColLineItemPriceAmount
      // 
      ColLineItemPriceAmount.HeaderText = "Iznos";
      ColLineItemPriceAmount.Name = "ColLineItemPriceAmount";
      // 
      // tpTaxes
      // 
      tpTaxes.Location = new Point(4, 27);
      tpTaxes.Name = "tpTaxes";
      tpTaxes.Padding = new Padding(3);
      tpTaxes.Size = new Size(937, 263);
      tpTaxes.TabIndex = 1;
      tpTaxes.Text = "Porez";
      tpTaxes.UseVisualStyleBackColor = true;
      // 
      // tpDokumenta
      // 
      tpDokumenta.Location = new Point(4, 27);
      tpDokumenta.Name = "tpDokumenta";
      tpDokumenta.Padding = new Padding(3);
      tpDokumenta.Size = new Size(937, 263);
      tpDokumenta.TabIndex = 2;
      tpDokumenta.Text = "Dokumenta";
      tpDokumenta.UseVisualStyleBackColor = true;
      // 
      // tpHistory
      // 
      tpHistory.Location = new Point(4, 27);
      tpHistory.Name = "tpHistory";
      tpHistory.Padding = new Padding(3);
      tpHistory.Size = new Size(937, 263);
      tpHistory.TabIndex = 3;
      tpHistory.Text = "Istorija";
      tpHistory.UseVisualStyleBackColor = true;
      // 
      // CustomerPanel
      // 
      CustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      CustomerPanel.Controls.Add(DatePanel);
      CustomerPanel.Controls.Add(CustomerPartyFinPanel);
      CustomerPanel.Controls.Add(CustomerPartyName);
      CustomerPanel.Controls.Add(CustomerPartyLabel);
      CustomerPanel.Controls.Add(InvoiceID);
      CustomerPanel.Location = new Point(604, 3);
      CustomerPanel.Name = "CustomerPanel";
      CustomerPanel.Size = new Size(340, 185);
      CustomerPanel.TabIndex = 30;
      // 
      // DatePanel
      // 
      DatePanel.Controls.Add(TaxDatePanel);
      DatePanel.Controls.Add(DueDatePanel);
      DatePanel.Controls.Add(IssueDatePanel);
      DatePanel.Dock = DockStyle.Top;
      DatePanel.Location = new Point(0, 100);
      DatePanel.Name = "DatePanel";
      DatePanel.Size = new Size(340, 73);
      DatePanel.TabIndex = 34;
      // 
      // TaxDatePanel
      // 
      TaxDatePanel.Controls.Add(TaxDateLabel);
      TaxDatePanel.Controls.Add(TaxDate);
      TaxDatePanel.Dock = DockStyle.Top;
      TaxDatePanel.Location = new Point(0, 44);
      TaxDatePanel.Name = "TaxDatePanel";
      TaxDatePanel.Size = new Size(340, 22);
      TaxDatePanel.TabIndex = 25;
      // 
      // TaxDateLabel
      // 
      TaxDateLabel.AutoSize = true;
      TaxDateLabel.Dock = DockStyle.Right;
      TaxDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      TaxDateLabel.Location = new Point(197, 0);
      TaxDateLabel.MinimumSize = new Size(0, 20);
      TaxDateLabel.Name = "TaxDateLabel";
      TaxDateLabel.Size = new Size(74, 20);
      TaxDateLabel.TabIndex = 14;
      TaxDateLabel.Text = "Datum PDV";
      TaxDateLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // TaxDate
      // 
      TaxDate.AutoSize = true;
      TaxDate.Dock = DockStyle.Right;
      TaxDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      TaxDate.LinkBehavior = LinkBehavior.HoverUnderline;
      TaxDate.LinkColor = SystemColors.WindowText;
      TaxDate.Location = new Point(271, 0);
      TaxDate.MinimumSize = new Size(0, 20);
      TaxDate.Name = "TaxDate";
      TaxDate.Size = new Size(69, 20);
      TaxDate.TabIndex = 15;
      TaxDate.TabStop = true;
      TaxDate.Text = "10.10.2024";
      TaxDate.TextAlign = ContentAlignment.MiddleRight;
      // 
      // DueDatePanel
      // 
      DueDatePanel.Controls.Add(DueDateLabel);
      DueDatePanel.Controls.Add(DueDate);
      DueDatePanel.Dock = DockStyle.Top;
      DueDatePanel.Location = new Point(0, 22);
      DueDatePanel.Name = "DueDatePanel";
      DueDatePanel.Size = new Size(340, 22);
      DueDatePanel.TabIndex = 24;
      // 
      // DueDateLabel
      // 
      DueDateLabel.AutoSize = true;
      DueDateLabel.Dock = DockStyle.Right;
      DueDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      DueDateLabel.Location = new Point(171, 0);
      DueDateLabel.MinimumSize = new Size(0, 20);
      DueDateLabel.Name = "DueDateLabel";
      DueDateLabel.Size = new Size(100, 20);
      DueDateLabel.TabIndex = 14;
      DueDateLabel.Text = "Datum dospeća";
      DueDateLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // DueDate
      // 
      DueDate.AutoSize = true;
      DueDate.Dock = DockStyle.Right;
      DueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      DueDate.LinkBehavior = LinkBehavior.HoverUnderline;
      DueDate.LinkColor = SystemColors.WindowText;
      DueDate.Location = new Point(271, 0);
      DueDate.MinimumSize = new Size(0, 20);
      DueDate.Name = "DueDate";
      DueDate.Size = new Size(69, 20);
      DueDate.TabIndex = 15;
      DueDate.TabStop = true;
      DueDate.Text = "10.10.2024";
      DueDate.TextAlign = ContentAlignment.MiddleRight;
      // 
      // IssueDatePanel
      // 
      IssueDatePanel.Controls.Add(IssueDateLabel);
      IssueDatePanel.Controls.Add(IssueDate);
      IssueDatePanel.Dock = DockStyle.Top;
      IssueDatePanel.Location = new Point(0, 0);
      IssueDatePanel.Name = "IssueDatePanel";
      IssueDatePanel.Size = new Size(340, 22);
      IssueDatePanel.TabIndex = 23;
      // 
      // IssueDateLabel
      // 
      IssueDateLabel.AutoSize = true;
      IssueDateLabel.Dock = DockStyle.Right;
      IssueDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      IssueDateLabel.Location = new Point(171, 0);
      IssueDateLabel.MinimumSize = new Size(0, 20);
      IssueDateLabel.Name = "IssueDateLabel";
      IssueDateLabel.Size = new Size(100, 20);
      IssueDateLabel.TabIndex = 14;
      IssueDateLabel.Text = "Datum prometa";
      IssueDateLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // IssueDate
      // 
      IssueDate.AutoSize = true;
      IssueDate.Dock = DockStyle.Right;
      IssueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      IssueDate.LinkBehavior = LinkBehavior.HoverUnderline;
      IssueDate.LinkColor = SystemColors.WindowText;
      IssueDate.Location = new Point(271, 0);
      IssueDate.MinimumSize = new Size(0, 20);
      IssueDate.Name = "IssueDate";
      IssueDate.Size = new Size(69, 20);
      IssueDate.TabIndex = 15;
      IssueDate.TabStop = true;
      IssueDate.Text = "10.10.2024";
      IssueDate.TextAlign = ContentAlignment.MiddleRight;
      // 
      // CustomerPartyFinPanel
      // 
      CustomerPartyFinPanel.Controls.Add(CustomerPartyPIBLabel);
      CustomerPartyFinPanel.Controls.Add(CustomerPartyPIB);
      CustomerPartyFinPanel.Controls.Add(CustomerPartyMBLabel);
      CustomerPartyFinPanel.Controls.Add(CustomerPartyMB);
      CustomerPartyFinPanel.Dock = DockStyle.Top;
      CustomerPartyFinPanel.Location = new Point(0, 70);
      CustomerPartyFinPanel.Name = "CustomerPartyFinPanel";
      CustomerPartyFinPanel.Size = new Size(340, 30);
      CustomerPartyFinPanel.TabIndex = 33;
      // 
      // CustomerPartyPIBLabel
      // 
      CustomerPartyPIBLabel.AutoSize = true;
      CustomerPartyPIBLabel.Dock = DockStyle.Right;
      CustomerPartyPIBLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
      CustomerPartyPIBLabel.Location = new Point(160, 0);
      CustomerPartyPIBLabel.MinimumSize = new Size(0, 25);
      CustomerPartyPIBLabel.Name = "CustomerPartyPIBLabel";
      CustomerPartyPIBLabel.Size = new Size(24, 25);
      CustomerPartyPIBLabel.TabIndex = 16;
      CustomerPartyPIBLabel.Text = "PIB";
      CustomerPartyPIBLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // CustomerPartyPIB
      // 
      CustomerPartyPIB.AutoSize = true;
      CustomerPartyPIB.Dock = DockStyle.Right;
      CustomerPartyPIB.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      CustomerPartyPIB.LinkBehavior = LinkBehavior.HoverUnderline;
      CustomerPartyPIB.LinkColor = SystemColors.MenuHighlight;
      CustomerPartyPIB.Location = new Point(184, 0);
      CustomerPartyPIB.MinimumSize = new Size(0, 25);
      CustomerPartyPIB.Name = "CustomerPartyPIB";
      CustomerPartyPIB.Size = new Size(70, 25);
      CustomerPartyPIB.TabIndex = 17;
      CustomerPartyPIB.TabStop = true;
      CustomerPartyPIB.Text = "101684773";
      CustomerPartyPIB.TextAlign = ContentAlignment.MiddleRight;
      // 
      // CustomerPartyMBLabel
      // 
      CustomerPartyMBLabel.AutoSize = true;
      CustomerPartyMBLabel.Dock = DockStyle.Right;
      CustomerPartyMBLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
      CustomerPartyMBLabel.Location = new Point(254, 0);
      CustomerPartyMBLabel.MinimumSize = new Size(0, 25);
      CustomerPartyMBLabel.Name = "CustomerPartyMBLabel";
      CustomerPartyMBLabel.Size = new Size(23, 25);
      CustomerPartyMBLabel.TabIndex = 14;
      CustomerPartyMBLabel.Text = "MB";
      CustomerPartyMBLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // CustomerPartyMB
      // 
      CustomerPartyMB.AutoSize = true;
      CustomerPartyMB.Dock = DockStyle.Right;
      CustomerPartyMB.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      CustomerPartyMB.LinkBehavior = LinkBehavior.HoverUnderline;
      CustomerPartyMB.LinkColor = SystemColors.WindowText;
      CustomerPartyMB.Location = new Point(277, 0);
      CustomerPartyMB.MinimumSize = new Size(0, 25);
      CustomerPartyMB.Name = "CustomerPartyMB";
      CustomerPartyMB.Size = new Size(63, 25);
      CustomerPartyMB.TabIndex = 15;
      CustomerPartyMB.TabStop = true;
      CustomerPartyMB.Text = "17331213";
      CustomerPartyMB.TextAlign = ContentAlignment.MiddleRight;
      // 
      // CustomerPartyName
      // 
      CustomerPartyName.Dock = DockStyle.Top;
      CustomerPartyName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      CustomerPartyName.LinkBehavior = LinkBehavior.HoverUnderline;
      CustomerPartyName.LinkColor = SystemColors.MenuHighlight;
      CustomerPartyName.Location = new Point(0, 49);
      CustomerPartyName.Name = "CustomerPartyName";
      CustomerPartyName.Size = new Size(340, 21);
      CustomerPartyName.TabIndex = 31;
      CustomerPartyName.TabStop = true;
      CustomerPartyName.Text = "NTE Engenering";
      CustomerPartyName.TextAlign = ContentAlignment.MiddleRight;
      // 
      // CustomerPartyLabel
      // 
      CustomerPartyLabel.Dock = DockStyle.Top;
      CustomerPartyLabel.Font = new Font("Segoe UI", 8.25F);
      CustomerPartyLabel.Location = new Point(0, 36);
      CustomerPartyLabel.Name = "CustomerPartyLabel";
      CustomerPartyLabel.Size = new Size(340, 13);
      CustomerPartyLabel.TabIndex = 30;
      CustomerPartyLabel.Text = "KOME";
      CustomerPartyLabel.TextAlign = ContentAlignment.BottomRight;
      // 
      // InvoiceID
      // 
      InvoiceID.Dock = DockStyle.Top;
      InvoiceID.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
      InvoiceID.Location = new Point(0, 0);
      InvoiceID.Name = "InvoiceID";
      InvoiceID.Size = new Size(340, 36);
      InvoiceID.TabIndex = 32;
      InvoiceID.Text = "FU-19";
      InvoiceID.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPanel
      // 
      SupplierPanel.Controls.Add(SupplierPartyPaymentPanel);
      SupplierPanel.Controls.Add(SupplierPartyContact);
      SupplierPanel.Controls.Add(SupplierPartyAddress);
      SupplierPanel.Controls.Add(SupplierPartyFinPanel);
      SupplierPanel.Controls.Add(SupplierPartyName);
      SupplierPanel.Controls.Add(SupplierPartyLabel);
      SupplierPanel.Controls.Add(InvoiceIDLeft);
      SupplierPanel.Location = new Point(3, 3);
      SupplierPanel.Name = "SupplierPanel";
      SupplierPanel.Size = new Size(447, 185);
      SupplierPanel.TabIndex = 31;
      // 
      // SupplierPartyPaymentPanel
      // 
      SupplierPartyPaymentPanel.Controls.Add(SupplierPartyPaymentBank);
      SupplierPartyPaymentPanel.Controls.Add(SupplierPartyPaymentBankLabel);
      SupplierPartyPaymentPanel.Controls.Add(SupplierPartyPaymentType);
      SupplierPartyPaymentPanel.Controls.Add(SupplierPartyPaymentTypeLabel);
      SupplierPartyPaymentPanel.Dock = DockStyle.Top;
      SupplierPartyPaymentPanel.Location = new Point(0, 142);
      SupplierPartyPaymentPanel.Name = "SupplierPartyPaymentPanel";
      SupplierPartyPaymentPanel.Size = new Size(447, 24);
      SupplierPartyPaymentPanel.TabIndex = 39;
      // 
      // SupplierPartyPaymentBank
      // 
      SupplierPartyPaymentBank.AutoSize = true;
      SupplierPartyPaymentBank.Dock = DockStyle.Left;
      SupplierPartyPaymentBank.Font = new Font("Microsoft Sans Serif", 8.25F);
      SupplierPartyPaymentBank.LinkBehavior = LinkBehavior.HoverUnderline;
      SupplierPartyPaymentBank.LinkColor = SystemColors.MenuHighlight;
      SupplierPartyPaymentBank.Location = new Point(89, 0);
      SupplierPartyPaymentBank.MinimumSize = new Size(0, 25);
      SupplierPartyPaymentBank.Name = "SupplierPartyPaymentBank";
      SupplierPartyPaymentBank.Size = new Size(115, 25);
      SupplierPartyPaymentBank.TabIndex = 17;
      SupplierPartyPaymentBank.TabStop = true;
      SupplierPartyPaymentBank.Text = "325950070020945793";
      SupplierPartyPaymentBank.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyPaymentBankLabel
      // 
      SupplierPartyPaymentBankLabel.AutoSize = true;
      SupplierPartyPaymentBankLabel.Dock = DockStyle.Left;
      SupplierPartyPaymentBankLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
      SupplierPartyPaymentBankLabel.Location = new Point(67, 0);
      SupplierPartyPaymentBankLabel.MinimumSize = new Size(0, 25);
      SupplierPartyPaymentBankLabel.Name = "SupplierPartyPaymentBankLabel";
      SupplierPartyPaymentBankLabel.Size = new Size(22, 25);
      SupplierPartyPaymentBankLabel.TabIndex = 16;
      SupplierPartyPaymentBankLabel.Text = "Aik";
      SupplierPartyPaymentBankLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyPaymentType
      // 
      SupplierPartyPaymentType.AutoSize = true;
      SupplierPartyPaymentType.Dock = DockStyle.Left;
      SupplierPartyPaymentType.Font = new Font("Microsoft Sans Serif", 8.25F);
      SupplierPartyPaymentType.LinkBehavior = LinkBehavior.HoverUnderline;
      SupplierPartyPaymentType.LinkColor = SystemColors.MenuHighlight;
      SupplierPartyPaymentType.Location = new Point(48, 0);
      SupplierPartyPaymentType.MinimumSize = new Size(0, 25);
      SupplierPartyPaymentType.Name = "SupplierPartyPaymentType";
      SupplierPartyPaymentType.Size = new Size(19, 25);
      SupplierPartyPaymentType.TabIndex = 15;
      SupplierPartyPaymentType.TabStop = true;
      SupplierPartyPaymentType.Text = "30";
      SupplierPartyPaymentType.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyPaymentTypeLabel
      // 
      SupplierPartyPaymentTypeLabel.AutoSize = true;
      SupplierPartyPaymentTypeLabel.Dock = DockStyle.Left;
      SupplierPartyPaymentTypeLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
      SupplierPartyPaymentTypeLabel.Location = new Point(0, 0);
      SupplierPartyPaymentTypeLabel.MinimumSize = new Size(0, 25);
      SupplierPartyPaymentTypeLabel.Name = "SupplierPartyPaymentTypeLabel";
      SupplierPartyPaymentTypeLabel.Size = new Size(48, 25);
      SupplierPartyPaymentTypeLabel.TabIndex = 14;
      SupplierPartyPaymentTypeLabel.Text = "Placanje";
      SupplierPartyPaymentTypeLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyContact
      // 
      SupplierPartyContact.Dock = DockStyle.Top;
      SupplierPartyContact.Location = new Point(0, 115);
      SupplierPartyContact.Name = "SupplierPartyContact";
      SupplierPartyContact.Size = new Size(447, 27);
      SupplierPartyContact.TabIndex = 36;
      SupplierPartyContact.Text = "premer.geo@gmail.com";
      // 
      // SupplierPartyAddress
      // 
      SupplierPartyAddress.Dock = DockStyle.Top;
      SupplierPartyAddress.Location = new Point(0, 100);
      SupplierPartyAddress.Name = "SupplierPartyAddress";
      SupplierPartyAddress.Size = new Size(447, 15);
      SupplierPartyAddress.TabIndex = 35;
      SupplierPartyAddress.Text = "PARISKE KOMUNE 27/6, Beograd (Novi Beograd)";
      // 
      // SupplierPartyFinPanel
      // 
      SupplierPartyFinPanel.Controls.Add(SupplierPartyMB);
      SupplierPartyFinPanel.Controls.Add(SupplierPartyMBLabel);
      SupplierPartyFinPanel.Controls.Add(SupplierPartyPIB);
      SupplierPartyFinPanel.Controls.Add(SupplierPartyPIBLabel);
      SupplierPartyFinPanel.Dock = DockStyle.Top;
      SupplierPartyFinPanel.Location = new Point(0, 70);
      SupplierPartyFinPanel.Name = "SupplierPartyFinPanel";
      SupplierPartyFinPanel.Size = new Size(447, 30);
      SupplierPartyFinPanel.TabIndex = 38;
      // 
      // SupplierPartyMB
      // 
      SupplierPartyMB.AutoSize = true;
      SupplierPartyMB.Dock = DockStyle.Left;
      SupplierPartyMB.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      SupplierPartyMB.LinkBehavior = LinkBehavior.HoverUnderline;
      SupplierPartyMB.LinkColor = SystemColors.WindowText;
      SupplierPartyMB.Location = new Point(117, 0);
      SupplierPartyMB.MinimumSize = new Size(0, 25);
      SupplierPartyMB.Name = "SupplierPartyMB";
      SupplierPartyMB.Size = new Size(63, 25);
      SupplierPartyMB.TabIndex = 15;
      SupplierPartyMB.TabStop = true;
      SupplierPartyMB.Text = "17331213";
      SupplierPartyMB.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyMBLabel
      // 
      SupplierPartyMBLabel.AutoSize = true;
      SupplierPartyMBLabel.Dock = DockStyle.Left;
      SupplierPartyMBLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
      SupplierPartyMBLabel.Location = new Point(94, 0);
      SupplierPartyMBLabel.MinimumSize = new Size(0, 25);
      SupplierPartyMBLabel.Name = "SupplierPartyMBLabel";
      SupplierPartyMBLabel.Size = new Size(23, 25);
      SupplierPartyMBLabel.TabIndex = 14;
      SupplierPartyMBLabel.Text = "MB";
      SupplierPartyMBLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyPIB
      // 
      SupplierPartyPIB.AutoSize = true;
      SupplierPartyPIB.Dock = DockStyle.Left;
      SupplierPartyPIB.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
      SupplierPartyPIB.LinkBehavior = LinkBehavior.HoverUnderline;
      SupplierPartyPIB.LinkColor = SystemColors.MenuHighlight;
      SupplierPartyPIB.Location = new Point(24, 0);
      SupplierPartyPIB.MinimumSize = new Size(0, 25);
      SupplierPartyPIB.Name = "SupplierPartyPIB";
      SupplierPartyPIB.Size = new Size(70, 25);
      SupplierPartyPIB.TabIndex = 17;
      SupplierPartyPIB.TabStop = true;
      SupplierPartyPIB.Text = "101684773";
      SupplierPartyPIB.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyPIBLabel
      // 
      SupplierPartyPIBLabel.AutoSize = true;
      SupplierPartyPIBLabel.Dock = DockStyle.Left;
      SupplierPartyPIBLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
      SupplierPartyPIBLabel.Location = new Point(0, 0);
      SupplierPartyPIBLabel.MinimumSize = new Size(0, 25);
      SupplierPartyPIBLabel.Name = "SupplierPartyPIBLabel";
      SupplierPartyPIBLabel.Size = new Size(24, 25);
      SupplierPartyPIBLabel.TabIndex = 16;
      SupplierPartyPIBLabel.Text = "PIB";
      SupplierPartyPIBLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // SupplierPartyName
      // 
      SupplierPartyName.Dock = DockStyle.Top;
      SupplierPartyName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      SupplierPartyName.LinkBehavior = LinkBehavior.HoverUnderline;
      SupplierPartyName.LinkColor = SystemColors.MenuHighlight;
      SupplierPartyName.Location = new Point(0, 49);
      SupplierPartyName.Name = "SupplierPartyName";
      SupplierPartyName.Size = new Size(447, 21);
      SupplierPartyName.TabIndex = 34;
      SupplierPartyName.TabStop = true;
      SupplierPartyName.Text = "ГЕОКОП ВУКОВИЋ ДОО АРАНЂЕЛОВАЦ";
      // 
      // SupplierPartyLabel
      // 
      SupplierPartyLabel.Dock = DockStyle.Top;
      SupplierPartyLabel.Font = new Font("Segoe UI", 8.25F);
      SupplierPartyLabel.Location = new Point(0, 36);
      SupplierPartyLabel.Name = "SupplierPartyLabel";
      SupplierPartyLabel.Size = new Size(447, 13);
      SupplierPartyLabel.TabIndex = 37;
      SupplierPartyLabel.Text = "PRODAVAC";
      // 
      // InvoiceIDLeft
      // 
      InvoiceIDLeft.Dock = DockStyle.Top;
      InvoiceIDLeft.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
      InvoiceIDLeft.Location = new Point(0, 0);
      InvoiceIDLeft.Name = "InvoiceIDLeft";
      InvoiceIDLeft.Size = new Size(447, 36);
      InvoiceIDLeft.TabIndex = 33;
      InvoiceIDLeft.Text = "FU-19";
      InvoiceIDLeft.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // LegalMonetaryTotalPanel
      // 
      LegalMonetaryTotalPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      LegalMonetaryTotalPanel.Controls.Add(LineExtensionAmountPanel);
      LegalMonetaryTotalPanel.Controls.Add(TaxInclusiveAmountPanel);
      LegalMonetaryTotalPanel.Controls.Add(PayableAmountPanel);
      LegalMonetaryTotalPanel.Location = new Point(405, 494);
      LegalMonetaryTotalPanel.Name = "LegalMonetaryTotalPanel";
      LegalMonetaryTotalPanel.Size = new Size(539, 97);
      LegalMonetaryTotalPanel.TabIndex = 32;
      // 
      // LineExtensionAmountPanel
      // 
      LineExtensionAmountPanel.Controls.Add(LineExtensionAmountLabel);
      LineExtensionAmountPanel.Controls.Add(LineExtensionAmount);
      LineExtensionAmountPanel.Controls.Add(LineExtensionAmountCurrency);
      LineExtensionAmountPanel.Dock = DockStyle.Bottom;
      LineExtensionAmountPanel.Location = new Point(0, 3);
      LineExtensionAmountPanel.Name = "LineExtensionAmountPanel";
      LineExtensionAmountPanel.Size = new Size(539, 29);
      LineExtensionAmountPanel.TabIndex = 28;
      // 
      // LineExtensionAmountLabel
      // 
      LineExtensionAmountLabel.AutoSize = true;
      LineExtensionAmountLabel.Dock = DockStyle.Right;
      LineExtensionAmountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      LineExtensionAmountLabel.Location = new Point(412, 0);
      LineExtensionAmountLabel.MinimumSize = new Size(0, 30);
      LineExtensionAmountLabel.Name = "LineExtensionAmountLabel";
      LineExtensionAmountLabel.Size = new Size(37, 30);
      LineExtensionAmountLabel.TabIndex = 14;
      LineExtensionAmountLabel.Text = "Cena";
      LineExtensionAmountLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // LineExtensionAmount
      // 
      LineExtensionAmount.AutoSize = true;
      LineExtensionAmount.Dock = DockStyle.Right;
      LineExtensionAmount.Font = new Font("Segoe UI", 12F);
      LineExtensionAmount.Location = new Point(449, 0);
      LineExtensionAmount.MinimumSize = new Size(0, 30);
      LineExtensionAmount.Name = "LineExtensionAmount";
      LineExtensionAmount.Size = new Size(58, 30);
      LineExtensionAmount.TabIndex = 13;
      LineExtensionAmount.Text = "567.00";
      LineExtensionAmount.TextAlign = ContentAlignment.MiddleRight;
      // 
      // LineExtensionAmountCurrency
      // 
      LineExtensionAmountCurrency.AutoSize = true;
      LineExtensionAmountCurrency.Dock = DockStyle.Right;
      LineExtensionAmountCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      LineExtensionAmountCurrency.Location = new Point(507, 0);
      LineExtensionAmountCurrency.MinimumSize = new Size(0, 30);
      LineExtensionAmountCurrency.Name = "LineExtensionAmountCurrency";
      LineExtensionAmountCurrency.Size = new Size(32, 30);
      LineExtensionAmountCurrency.TabIndex = 15;
      LineExtensionAmountCurrency.Text = "RSD";
      LineExtensionAmountCurrency.TextAlign = ContentAlignment.MiddleRight;
      // 
      // TaxInclusiveAmountPanel
      // 
      TaxInclusiveAmountPanel.Controls.Add(TaxInclusiveAmountLabel);
      TaxInclusiveAmountPanel.Controls.Add(TaxAmount);
      TaxInclusiveAmountPanel.Controls.Add(TaxInclusiveAmountCurrency);
      TaxInclusiveAmountPanel.Dock = DockStyle.Bottom;
      TaxInclusiveAmountPanel.Location = new Point(0, 32);
      TaxInclusiveAmountPanel.Name = "TaxInclusiveAmountPanel";
      TaxInclusiveAmountPanel.Size = new Size(539, 29);
      TaxInclusiveAmountPanel.TabIndex = 27;
      // 
      // TaxInclusiveAmountLabel
      // 
      TaxInclusiveAmountLabel.AutoSize = true;
      TaxInclusiveAmountLabel.Dock = DockStyle.Right;
      TaxInclusiveAmountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      TaxInclusiveAmountLabel.Location = new Point(408, 0);
      TaxInclusiveAmountLabel.MinimumSize = new Size(0, 30);
      TaxInclusiveAmountLabel.Name = "TaxInclusiveAmountLabel";
      TaxInclusiveAmountLabel.Size = new Size(41, 30);
      TaxInclusiveAmountLabel.TabIndex = 14;
      TaxInclusiveAmountLabel.Text = "Porez";
      TaxInclusiveAmountLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // TaxAmount
      // 
      TaxAmount.AutoSize = true;
      TaxAmount.Dock = DockStyle.Right;
      TaxAmount.Font = new Font("Segoe UI", 12F);
      TaxAmount.Location = new Point(449, 0);
      TaxAmount.MinimumSize = new Size(0, 30);
      TaxAmount.Name = "TaxAmount";
      TaxAmount.Size = new Size(58, 30);
      TaxAmount.TabIndex = 13;
      TaxAmount.Text = "567.00";
      TaxAmount.TextAlign = ContentAlignment.MiddleRight;
      // 
      // TaxInclusiveAmountCurrency
      // 
      TaxInclusiveAmountCurrency.AutoSize = true;
      TaxInclusiveAmountCurrency.Dock = DockStyle.Right;
      TaxInclusiveAmountCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      TaxInclusiveAmountCurrency.Location = new Point(507, 0);
      TaxInclusiveAmountCurrency.MinimumSize = new Size(0, 30);
      TaxInclusiveAmountCurrency.Name = "TaxInclusiveAmountCurrency";
      TaxInclusiveAmountCurrency.Size = new Size(32, 30);
      TaxInclusiveAmountCurrency.TabIndex = 15;
      TaxInclusiveAmountCurrency.Text = "RSD";
      TaxInclusiveAmountCurrency.TextAlign = ContentAlignment.MiddleRight;
      // 
      // PayableAmountPanel
      // 
      PayableAmountPanel.Controls.Add(PayableAmountLabel);
      PayableAmountPanel.Controls.Add(PayableAmount);
      PayableAmountPanel.Controls.Add(PayableAmountCurrency);
      PayableAmountPanel.Dock = DockStyle.Bottom;
      PayableAmountPanel.Location = new Point(0, 61);
      PayableAmountPanel.Name = "PayableAmountPanel";
      PayableAmountPanel.Size = new Size(539, 36);
      PayableAmountPanel.TabIndex = 26;
      // 
      // PayableAmountLabel
      // 
      PayableAmountLabel.AutoSize = true;
      PayableAmountLabel.Dock = DockStyle.Right;
      PayableAmountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      PayableAmountLabel.Location = new Point(321, 0);
      PayableAmountLabel.MinimumSize = new Size(0, 30);
      PayableAmountLabel.Name = "PayableAmountLabel";
      PayableAmountLabel.Size = new Size(107, 30);
      PayableAmountLabel.TabIndex = 14;
      PayableAmountLabel.Text = "Iznos za plaćanje";
      PayableAmountLabel.TextAlign = ContentAlignment.MiddleRight;
      // 
      // PayableAmount
      // 
      PayableAmount.AutoSize = true;
      PayableAmount.Dock = DockStyle.Right;
      PayableAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
      PayableAmount.Location = new Point(428, 0);
      PayableAmount.MinimumSize = new Size(0, 30);
      PayableAmount.Name = "PayableAmount";
      PayableAmount.Size = new Size(79, 30);
      PayableAmount.TabIndex = 13;
      PayableAmount.Text = "567.00";
      PayableAmount.TextAlign = ContentAlignment.MiddleRight;
      // 
      // PayableAmountCurrency
      // 
      PayableAmountCurrency.AutoSize = true;
      PayableAmountCurrency.Dock = DockStyle.Right;
      PayableAmountCurrency.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
      PayableAmountCurrency.Location = new Point(507, 0);
      PayableAmountCurrency.MinimumSize = new Size(0, 30);
      PayableAmountCurrency.Name = "PayableAmountCurrency";
      PayableAmountCurrency.Size = new Size(32, 30);
      PayableAmountCurrency.TabIndex = 15;
      PayableAmountCurrency.Text = "RSD";
      PayableAmountCurrency.TextAlign = ContentAlignment.MiddleRight;
      // 
      // ControlDetail
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.Control;
      Controls.Add(LegalMonetaryTotalPanel);
      Controls.Add(SupplierPanel);
      Controls.Add(CustomerPanel);
      Controls.Add(MainTabControl);
      Name = "ControlDetail";
      Size = new Size(956, 594);
      MainTabControl.ResumeLayout(false);
      tpLines.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)LinesGrid).EndInit();
      CustomerPanel.ResumeLayout(false);
      DatePanel.ResumeLayout(false);
      TaxDatePanel.ResumeLayout(false);
      TaxDatePanel.PerformLayout();
      DueDatePanel.ResumeLayout(false);
      DueDatePanel.PerformLayout();
      IssueDatePanel.ResumeLayout(false);
      IssueDatePanel.PerformLayout();
      CustomerPartyFinPanel.ResumeLayout(false);
      CustomerPartyFinPanel.PerformLayout();
      SupplierPanel.ResumeLayout(false);
      SupplierPartyPaymentPanel.ResumeLayout(false);
      SupplierPartyPaymentPanel.PerformLayout();
      SupplierPartyFinPanel.ResumeLayout(false);
      SupplierPartyFinPanel.PerformLayout();
      LegalMonetaryTotalPanel.ResumeLayout(false);
      LineExtensionAmountPanel.ResumeLayout(false);
      LineExtensionAmountPanel.PerformLayout();
      TaxInclusiveAmountPanel.ResumeLayout(false);
      TaxInclusiveAmountPanel.PerformLayout();
      PayableAmountPanel.ResumeLayout(false);
      PayableAmountPanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private TabControl MainTabControl;
    private TabPage tpLines;
    private DataGridView LinesGrid;
    private DataGridViewTextBoxColumn ColLineID;
    private DataGridViewTextBoxColumn ColLineItemName;
    private DataGridViewTextBoxColumn ColLineInvoicedQuantity;
    private DataGridViewTextBoxColumn ColLineLineExtensionAmount;
    private DataGridViewTextBoxColumn ColLineItemClassifiedTaxCategory;
    private DataGridViewTextBoxColumn ColLineItemBaseQuantity;
    private DataGridViewTextBoxColumn ColLineItemClassifiedTaxCategoryPercent;
    private DataGridViewTextBoxColumn ColLineItemClassifiedTaxCategoryID;
    private DataGridViewTextBoxColumn ColLineItemClassifiedTaxCategoryTaxSchemeID;
    private DataGridViewTextBoxColumn ColLineItemPriceAmount;
    private TabPage tpTaxes;
    private Panel CustomerPanel;
    private Panel DatePanel;
    private Panel TaxDatePanel;
    private Label TaxDateLabel;
    private LinkLabel TaxDate;
    private Panel DueDatePanel;
    private Label DueDateLabel;
    private LinkLabel DueDate;
    private Panel IssueDatePanel;
    private Label IssueDateLabel;
    private LinkLabel IssueDate;
    private Panel CustomerPartyFinPanel;
    private Label CustomerPartyPIBLabel;
    private LinkLabel CustomerPartyPIB;
    private Label CustomerPartyMBLabel;
    private LinkLabel CustomerPartyMB;
    private LinkLabel CustomerPartyName;
    private Label CustomerPartyLabel;
    private Label InvoiceID;
    private Panel SupplierPanel;
    private Panel SupplierPartyPaymentPanel;
    private LinkLabel SupplierPartyPaymentBank;
    private Label SupplierPartyPaymentBankLabel;
    private LinkLabel SupplierPartyPaymentType;
    private Label SupplierPartyPaymentTypeLabel;
    private Panel SupplierPartyFinPanel;
    private LinkLabel SupplierPartyPIB;
    private Label SupplierPartyPIBLabel;
    private LinkLabel SupplierPartyMB;
    private Label SupplierPartyMBLabel;
    private Label SupplierPartyLabel;
    private Label SupplierPartyContact;
    private Label SupplierPartyAddress;
    private LinkLabel SupplierPartyName;
    private Label InvoiceIDLeft;
    private Panel LegalMonetaryTotalPanel;
    private Panel LineExtensionAmountPanel;
    private Label LineExtensionAmountLabel;
    private Label LineExtensionAmount;
    private Label LineExtensionAmountCurrency;
    private Panel TaxInclusiveAmountPanel;
    private Label TaxInclusiveAmountLabel;
    private Label TaxAmount;
    private Label TaxInclusiveAmountCurrency;
    private Panel PayableAmountPanel;
    private Label PayableAmountLabel;
    private Label PayableAmount;
    private Label PayableAmountCurrency;
    private TabPage tpDokumenta;
    private TabPage tpHistory;
  }
}
