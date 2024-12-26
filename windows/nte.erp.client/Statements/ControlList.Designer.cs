namespace nte.erp.client.Statements
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
      ColIdentificationId = new DataGridViewTextBoxColumn();
      ColName = new DataGridViewTextBoxColumn();
      ColAddressStreetName = new DataGridViewTextBoxColumn();
      ColAddressCityName = new DataGridViewTextBoxColumn();
      ColAddressPostalZone = new DataGridViewTextBoxColumn();
      ColAddressCountryIdentificationCode = new DataGridViewTextBoxColumn();
      ColTaxSchemeId = new DataGridViewTextBoxColumn();
      ColTaxSchemeCompanyId = new DataGridViewTextBoxColumn();
      ColLegalEntityCompanyId = new DataGridViewTextBoxColumn();
      ColLegalEntityRegistrationName = new DataGridViewTextBoxColumn();
      ColTaxSchemeRegistrationName = new DataGridViewTextBoxColumn();
      ColContactName = new DataGridViewTextBoxColumn();
      ColContactEmail = new DataGridViewTextBoxColumn();
      StatusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ListGrid).BeginInit();
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
      MainStatusLabel.Size = new Size(371, 19);
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
      ListGrid.Columns.AddRange(new DataGridViewColumn[] { ColEndpointId, ColEndpointSchemeId, ColIdentificationId, ColName, ColAddressStreetName, ColAddressCityName, ColAddressPostalZone, ColAddressCountryIdentificationCode, ColTaxSchemeId, ColTaxSchemeCompanyId, ColLegalEntityCompanyId, ColLegalEntityRegistrationName, ColTaxSchemeRegistrationName, ColContactName, ColContactEmail });
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
      ColEndpointSchemeId.HeaderText = "EndpointSchemeId";
      ColEndpointSchemeId.Name = "ColEndpointSchemeId";
      // 
      // ColIdentificationId
      // 
      ColIdentificationId.HeaderText = "IdentificationId";
      ColIdentificationId.Name = "ColIdentificationId";
      // 
      // ColName
      // 
      ColName.HeaderText = "Name";
      ColName.Name = "ColName";
      // 
      // ColAddressStreetName
      // 
      ColAddressStreetName.HeaderText = "AddressStreetName";
      ColAddressStreetName.Name = "ColAddressStreetName";
      // 
      // ColAddressCityName
      // 
      ColAddressCityName.HeaderText = "AddressCityName";
      ColAddressCityName.Name = "ColAddressCityName";
      // 
      // ColAddressPostalZone
      // 
      ColAddressPostalZone.HeaderText = "AddressPostalZone";
      ColAddressPostalZone.Name = "ColAddressPostalZone";
      // 
      // ColAddressCountryIdentificationCode
      // 
      ColAddressCountryIdentificationCode.HeaderText = "AddressCountryIdentificationCode";
      ColAddressCountryIdentificationCode.Name = "ColAddressCountryIdentificationCode";
      // 
      // ColTaxSchemeId
      // 
      ColTaxSchemeId.HeaderText = "TaxSchemeId";
      ColTaxSchemeId.Name = "ColTaxSchemeId";
      // 
      // ColTaxSchemeCompanyId
      // 
      ColTaxSchemeCompanyId.HeaderText = "TaxSchemeCompanyId";
      ColTaxSchemeCompanyId.Name = "ColTaxSchemeCompanyId";
      // 
      // ColLegalEntityCompanyId
      // 
      ColLegalEntityCompanyId.HeaderText = "LegalEntityCompanyId";
      ColLegalEntityCompanyId.Name = "ColLegalEntityCompanyId";
      // 
      // ColLegalEntityRegistrationName
      // 
      ColLegalEntityRegistrationName.HeaderText = "LegalEntityRegistrationName";
      ColLegalEntityRegistrationName.Name = "ColLegalEntityRegistrationName";
      // 
      // ColTaxSchemeRegistrationName
      // 
      ColTaxSchemeRegistrationName.HeaderText = "TaxSchemeRegistrationName";
      ColTaxSchemeRegistrationName.Name = "ColTaxSchemeRegistrationName";
      // 
      // ColContactName
      // 
      ColContactName.HeaderText = "ContactName";
      ColContactName.Name = "ColContactName";
      // 
      // ColContactEmail
      // 
      ColContactEmail.HeaderText = "ContactEmail";
      ColContactEmail.Name = "ColContactEmail";
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
    private DataGridViewTextBoxColumn ColIdentificationId;
    private DataGridViewTextBoxColumn ColName;
    private DataGridViewTextBoxColumn ColAddressStreetName;
    private DataGridViewTextBoxColumn ColAddressCityName;
    private DataGridViewTextBoxColumn ColAddressPostalZone;
    private DataGridViewTextBoxColumn ColAddressCountryIdentificationCode;
    private DataGridViewTextBoxColumn ColTaxSchemeId;
    private DataGridViewTextBoxColumn ColTaxSchemeCompanyId;
    private DataGridViewTextBoxColumn ColLegalEntityCompanyId;
    private DataGridViewTextBoxColumn ColLegalEntityRegistrationName;
    private DataGridViewTextBoxColumn ColTaxSchemeRegistrationName;
    private DataGridViewTextBoxColumn ColContactName;
    private DataGridViewTextBoxColumn ColContactEmail;
  }
}
