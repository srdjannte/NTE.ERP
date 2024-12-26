namespace nte.erp.client.Codebook.Party
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
      ColEndpointId = new DataGridViewTextBoxColumn();
      ColEndpointSchemeId = new DataGridViewTextBoxColumn();
      ColName = new DataGridViewTextBoxColumn();
      ColContactName = new DataGridViewTextBoxColumn();
      ColContactEmail = new DataGridViewTextBoxColumn();
      ColIdentificationId = new DataGridViewTextBoxColumn();
      ColAddressStreetName = new DataGridViewTextBoxColumn();
      ColAddressCityName = new DataGridViewTextBoxColumn();
      ColAddressPostalZone = new DataGridViewTextBoxColumn();
      ColTaxSchemeCompanyId = new DataGridViewTextBoxColumn();
      ColTaxSchemeId = new DataGridViewTextBoxColumn();
      ColAddressCountryIdentificationCode = new DataGridViewTextBoxColumn();
      ColLegalEntityCompanyId = new DataGridViewTextBoxColumn();
      ColLegalEntityRegistrationName = new DataGridViewTextBoxColumn();
      ColTaxSchemeRegistrationName = new DataGridViewTextBoxColumn();
      ListMenu = new ContextMenuStrip(components);
      ItemOpen = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      ItemAdd = new ToolStripMenuItem();
      ItemDelete = new ToolStripMenuItem();
      StatusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListGrid).BeginInit();
      ListMenu.SuspendLayout();
      SuspendLayout();
      // 
      // StatusBar
      // 
      StatusBar.Items.AddRange(new ToolStripItem[] { MainStatusLabel, StatusCapsLock, StatusNumLock, MainStatusState, MainStatusStat, toolStripStatusLabel1 });
      StatusBar.Location = new Point(0, 419);
      StatusBar.Name = "StatusBar";
      StatusBar.Padding = new Padding(1, 0, 16, 0);
      StatusBar.Size = new Size(655, 24);
      StatusBar.TabIndex = 3;
      StatusBar.Text = "Infomartions";
      // 
      // MainStatusLabel
      // 
      MainStatusLabel.Name = "MainStatusLabel";
      MainStatusLabel.Size = new Size(402, 19);
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
      ListGrid.Columns.AddRange(new DataGridViewColumn[] { ColEndpointId, ColEndpointSchemeId, ColName, ColContactName, ColContactEmail, ColIdentificationId, ColAddressStreetName, ColAddressCityName, ColAddressPostalZone, ColTaxSchemeCompanyId, ColTaxSchemeId, ColAddressCountryIdentificationCode, ColLegalEntityCompanyId, ColLegalEntityRegistrationName, ColTaxSchemeRegistrationName });
      ListGrid.ContextMenuStrip = ListMenu;
      ListGrid.Dock = DockStyle.Fill;
      ListGrid.Location = new Point(0, 0);
      ListGrid.Margin = new Padding(4, 3, 4, 3);
      ListGrid.Name = "ListGrid";
      ListGrid.RowHeadersVisible = false;
      ListGrid.Size = new Size(655, 419);
      ListGrid.TabIndex = 4;
      // 
      // ColEndpointId
      // 
      ColEndpointId.HeaderText = "PIB";
      ColEndpointId.Name = "ColEndpointId";
      // 
      // ColEndpointSchemeId
      // 
      ColEndpointSchemeId.DataPropertyName = "EndpointSchemeId";
      ColEndpointSchemeId.HeaderText = "Shema Tip";
      ColEndpointSchemeId.Name = "ColEndpointSchemeId";
      ColEndpointSchemeId.Visible = false;
      // 
      // ColName
      // 
      ColName.DataPropertyName = "Name";
      ColName.HeaderText = "Naziv";
      ColName.Name = "ColName";
      // 
      // ColContactName
      // 
      ColContactName.DataPropertyName = "ContactName";
      ColContactName.HeaderText = "Kontakt";
      ColContactName.Name = "ColContactName";
      // 
      // ColContactEmail
      // 
      ColContactEmail.DataPropertyName = "ContactEmail";
      ColContactEmail.HeaderText = "Email";
      ColContactEmail.Name = "ColContactEmail";
      // 
      // ColIdentificationId
      // 
      ColIdentificationId.DataPropertyName = "IdentificationId";
      ColIdentificationId.HeaderText = "Prepoznavanje";
      ColIdentificationId.Name = "ColIdentificationId";
      ColIdentificationId.Visible = false;
      // 
      // ColAddressStreetName
      // 
      ColAddressStreetName.DataPropertyName = "AddressStreetName";
      ColAddressStreetName.HeaderText = "Adresa";
      ColAddressStreetName.Name = "ColAddressStreetName";
      // 
      // ColAddressCityName
      // 
      ColAddressCityName.DataPropertyName = "AddressCityName";
      ColAddressCityName.HeaderText = "Grad";
      ColAddressCityName.Name = "ColAddressCityName";
      // 
      // ColAddressPostalZone
      // 
      ColAddressPostalZone.DataPropertyName = "AddressPostalZone";
      ColAddressPostalZone.HeaderText = "Posta";
      ColAddressPostalZone.Name = "ColAddressPostalZone";
      ColAddressPostalZone.Visible = false;
      // 
      // ColTaxSchemeCompanyId
      // 
      ColTaxSchemeCompanyId.HeaderText = "MB";
      ColTaxSchemeCompanyId.Name = "ColTaxSchemeCompanyId";
      // 
      // ColTaxSchemeId
      // 
      ColTaxSchemeId.DataPropertyName = "TaxSchemeId";
      ColTaxSchemeId.HeaderText = "Vrsta Poreza";
      ColTaxSchemeId.Name = "ColTaxSchemeId";
      // 
      // ColAddressCountryIdentificationCode
      // 
      ColAddressCountryIdentificationCode.DataPropertyName = "AddressCountryIdentificationCode";
      ColAddressCountryIdentificationCode.HeaderText = "AddressCountryIdentificationCode";
      ColAddressCountryIdentificationCode.Name = "ColAddressCountryIdentificationCode";
      ColAddressCountryIdentificationCode.Visible = false;
      // 
      // ColLegalEntityCompanyId
      // 
      ColLegalEntityCompanyId.DataPropertyName = "LegalEntityCompanyId";
      ColLegalEntityCompanyId.HeaderText = "PIB 2";
      ColLegalEntityCompanyId.Name = "ColLegalEntityCompanyId";
      ColLegalEntityCompanyId.Visible = false;
      // 
      // ColLegalEntityRegistrationName
      // 
      ColLegalEntityRegistrationName.DataPropertyName = "LegalEntityRegistrationName";
      ColLegalEntityRegistrationName.HeaderText = "MB 2";
      ColLegalEntityRegistrationName.Name = "ColLegalEntityRegistrationName";
      ColLegalEntityRegistrationName.Visible = false;
      // 
      // ColTaxSchemeRegistrationName
      // 
      ColTaxSchemeRegistrationName.DataPropertyName = "TaxSchemeRegistrationName";
      ColTaxSchemeRegistrationName.HeaderText = "TaxSchemeRegistrationName";
      ColTaxSchemeRegistrationName.Name = "ColTaxSchemeRegistrationName";
      ColTaxSchemeRegistrationName.Visible = false;
      // 
      // ListMenu
      // 
      ListMenu.Items.AddRange(new ToolStripItem[] { ItemOpen, toolStripSeparator1, ItemAdd, ItemDelete });
      ListMenu.Name = "ListMenu";
      ListMenu.Size = new Size(181, 98);
      // 
      // ItemOpen
      // 
      ItemOpen.Name = "ItemOpen";
      ItemOpen.Size = new Size(180, 22);
      ItemOpen.Text = "Otvori";
      ItemOpen.Click += Action_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(177, 6);
      // 
      // ItemAdd
      // 
      ItemAdd.Name = "ItemAdd";
      ItemAdd.ShortcutKeys = Keys.Insert;
      ItemAdd.Size = new Size(180, 22);
      ItemAdd.Text = "Add";
      ItemAdd.Click += Action_Click;
      // 
      // ItemDelete
      // 
      ItemDelete.Name = "ItemDelete";
      ItemDelete.ShortcutKeys = Keys.Delete;
      ItemDelete.Size = new Size(180, 22);
      ItemDelete.Text = "Izbrisi";
      ItemDelete.Click += Action_Click;
      // 
      // ControlList
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(ListGrid);
      Controls.Add(StatusBar);
      Name = "ControlList";
      Size = new Size(655, 443);
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
    private DataGridViewTextBoxColumn ColEndpointId;
    private DataGridViewTextBoxColumn ColEndpointSchemeId;
    private DataGridViewTextBoxColumn ColName;
    private DataGridViewTextBoxColumn ColContactName;
    private DataGridViewTextBoxColumn ColContactEmail;
    private DataGridViewTextBoxColumn ColIdentificationId;
    private DataGridViewTextBoxColumn ColAddressStreetName;
    private DataGridViewTextBoxColumn ColAddressCityName;
    private DataGridViewTextBoxColumn ColAddressPostalZone;
    private DataGridViewTextBoxColumn ColTaxSchemeCompanyId;
    private DataGridViewTextBoxColumn ColTaxSchemeId;
    private DataGridViewTextBoxColumn ColAddressCountryIdentificationCode;
    private DataGridViewTextBoxColumn ColLegalEntityCompanyId;
    private DataGridViewTextBoxColumn ColLegalEntityRegistrationName;
    private DataGridViewTextBoxColumn ColTaxSchemeRegistrationName;
    private ContextMenuStrip ListMenu;
    private ToolStripMenuItem ItemOpen;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ItemAdd;
    private ToolStripMenuItem ItemDelete;
  }
}
