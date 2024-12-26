using System;

namespace nte.erp.client
{
  partial class ControlConfig
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
      doSave = new Button();
      PartyPanel = new Panel();
      doOwnerSourceKindSetup = new LinkLabel();
      OwnerSourceKindLabel = new Label();
      OwnerSourceKind = new ComboBox();
      doOwnerDestinationKindSetup = new LinkLabel();
      OwnerDestinationKindLabel = new Label();
      OwnerDestinationKind = new ComboBox();
      OwnerOnPremiseLabel = new Label();
      OwnerSourceOnPremise = new TextBox();
      OwnerLicenceKindLabel = new Label();
      OwnerLicenceKind = new ComboBox();
      label7 = new Label();
      PartyContactEmail = new TextBox();
      label1 = new Label();
      PartyContactName = new TextBox();
      label5 = new Label();
      PartyAddressPostalZone = new TextBox();
      label6 = new Label();
      PartyAddressCityName = new TextBox();
      label4 = new Label();
      PartyAddressStreetName = new TextBox();
      label3 = new Label();
      PartyLegalEntityCompanyId = new TextBox();
      TaxSchemeCompanyIdLabel = new Label();
      PartyTaxSchemeCompanyId = new TextBox();
      OwnerNameLabel = new Label();
      PartyName = new TextBox();
      CmdPanel = new Panel();
      PartyPanel.SuspendLayout();
      CmdPanel.SuspendLayout();
      SuspendLayout();
      // 
      // doSave
      // 
      doSave.Location = new Point(8, 3);
      doSave.Name = "doSave";
      doSave.Size = new Size(133, 29);
      doSave.TabIndex = 6;
      doSave.Text = "Snimi";
      doSave.UseVisualStyleBackColor = true;
      doSave.Click += Action_Click;
      // 
      // PartyPanel
      // 
      PartyPanel.AutoScroll = true;
      PartyPanel.Controls.Add(doOwnerSourceKindSetup);
      PartyPanel.Controls.Add(OwnerSourceKindLabel);
      PartyPanel.Controls.Add(OwnerSourceKind);
      PartyPanel.Controls.Add(doOwnerDestinationKindSetup);
      PartyPanel.Controls.Add(OwnerDestinationKindLabel);
      PartyPanel.Controls.Add(OwnerDestinationKind);
      PartyPanel.Controls.Add(OwnerOnPremiseLabel);
      PartyPanel.Controls.Add(OwnerSourceOnPremise);
      PartyPanel.Controls.Add(OwnerLicenceKindLabel);
      PartyPanel.Controls.Add(OwnerLicenceKind);
      PartyPanel.Controls.Add(label7);
      PartyPanel.Controls.Add(PartyContactEmail);
      PartyPanel.Controls.Add(label1);
      PartyPanel.Controls.Add(PartyContactName);
      PartyPanel.Controls.Add(label5);
      PartyPanel.Controls.Add(PartyAddressPostalZone);
      PartyPanel.Controls.Add(label6);
      PartyPanel.Controls.Add(PartyAddressCityName);
      PartyPanel.Controls.Add(label4);
      PartyPanel.Controls.Add(PartyAddressStreetName);
      PartyPanel.Controls.Add(label3);
      PartyPanel.Controls.Add(PartyLegalEntityCompanyId);
      PartyPanel.Controls.Add(TaxSchemeCompanyIdLabel);
      PartyPanel.Controls.Add(PartyTaxSchemeCompanyId);
      PartyPanel.Controls.Add(OwnerNameLabel);
      PartyPanel.Controls.Add(PartyName);
      PartyPanel.Dock = DockStyle.Top;
      PartyPanel.Location = new Point(0, 0);
      PartyPanel.Name = "PartyPanel";
      PartyPanel.Size = new Size(611, 266);
      PartyPanel.TabIndex = 316;
      // 
      // doOwnerSourceKindSetup
      // 
      doOwnerSourceKindSetup.AutoSize = true;
      doOwnerSourceKindSetup.Location = new Point(193, 227);
      doOwnerSourceKindSetup.Name = "doOwnerSourceKindSetup";
      doOwnerSourceKindSetup.Size = new Size(42, 15);
      doOwnerSourceKindSetup.TabIndex = 332;
      doOwnerSourceKindSetup.TabStop = true;
      doOwnerSourceKindSetup.Text = "Podesi";
      // 
      // OwnerSourceKindLabel
      // 
      OwnerSourceKindLabel.AutoSize = true;
      OwnerSourceKindLabel.Location = new Point(192, 183);
      OwnerSourceKindLabel.Name = "OwnerSourceKindLabel";
      OwnerSourceKindLabel.Size = new Size(84, 15);
      OwnerSourceKindLabel.TabIndex = 330;
      OwnerSourceKindLabel.Text = "Izvor Podataka";
      // 
      // OwnerSourceKind
      // 
      OwnerSourceKind.DropDownStyle = ComboBoxStyle.DropDownList;
      OwnerSourceKind.FormattingEnabled = true;
      OwnerSourceKind.Items.AddRange(new object[] { "", "MsSql", "Excel", "XML File" });
      OwnerSourceKind.Location = new Point(192, 201);
      OwnerSourceKind.Name = "OwnerSourceKind";
      OwnerSourceKind.Size = new Size(170, 23);
      OwnerSourceKind.TabIndex = 331;
      OwnerSourceKind.SelectedIndexChanged += Action_Change;
      // 
      // doOwnerDestinationKindSetup
      // 
      doOwnerDestinationKindSetup.AutoSize = true;
      doOwnerDestinationKindSetup.Location = new Point(9, 227);
      doOwnerDestinationKindSetup.Name = "doOwnerDestinationKindSetup";
      doOwnerDestinationKindSetup.Size = new Size(42, 15);
      doOwnerDestinationKindSetup.TabIndex = 329;
      doOwnerDestinationKindSetup.TabStop = true;
      doOwnerDestinationKindSetup.Text = "Podesi";
      doOwnerDestinationKindSetup.Click += Action_Click;
      // 
      // OwnerDestinationKindLabel
      // 
      OwnerDestinationKindLabel.AutoSize = true;
      OwnerDestinationKindLabel.Location = new Point(8, 183);
      OwnerDestinationKindLabel.Name = "OwnerDestinationKindLabel";
      OwnerDestinationKindLabel.Size = new Size(109, 15);
      OwnerDestinationKindLabel.TabIndex = 327;
      OwnerDestinationKindLabel.Text = "Registracija Faktura";
      // 
      // OwnerDestinationKind
      // 
      OwnerDestinationKind.DropDownStyle = ComboBoxStyle.DropDownList;
      OwnerDestinationKind.FormattingEnabled = true;
      OwnerDestinationKind.Items.AddRange(new object[] { "", "SEF", "MojeRacun" });
      OwnerDestinationKind.Location = new Point(8, 201);
      OwnerDestinationKind.Name = "OwnerDestinationKind";
      OwnerDestinationKind.Size = new Size(178, 23);
      OwnerDestinationKind.TabIndex = 328;
      OwnerDestinationKind.SelectedIndexChanged += Action_Change;
      // 
      // OwnerOnPremiseLabel
      // 
      OwnerOnPremiseLabel.AutoSize = true;
      OwnerOnPremiseLabel.Location = new Point(368, 183);
      OwnerOnPremiseLabel.Name = "OwnerOnPremiseLabel";
      OwnerOnPremiseLabel.Size = new Size(137, 15);
      OwnerOnPremiseLabel.TabIndex = 326;
      OwnerOnPremiseLabel.Text = "Konekcija ka WebServisu";
      OwnerOnPremiseLabel.Visible = false;
      // 
      // OwnerSourceOnPremise
      // 
      OwnerSourceOnPremise.Location = new Point(368, 201);
      OwnerSourceOnPremise.Name = "OwnerSourceOnPremise";
      OwnerSourceOnPremise.Size = new Size(234, 23);
      OwnerSourceOnPremise.TabIndex = 325;
      OwnerSourceOnPremise.Visible = false;
      // 
      // OwnerLicenceKindLabel
      // 
      OwnerLicenceKindLabel.AutoSize = true;
      OwnerLicenceKindLabel.Location = new Point(368, 132);
      OwnerLicenceKindLabel.Name = "OwnerLicenceKindLabel";
      OwnerLicenceKindLabel.Size = new Size(72, 15);
      OwnerLicenceKindLabel.TabIndex = 320;
      OwnerLicenceKindLabel.Text = "Vrsta Usluge";
      // 
      // OwnerLicenceKind
      // 
      OwnerLicenceKind.DropDownStyle = ComboBoxStyle.DropDownList;
      OwnerLicenceKind.FormattingEnabled = true;
      OwnerLicenceKind.Items.AddRange(new object[] { "Local", "Cloud", "On Premise" });
      OwnerLicenceKind.Location = new Point(368, 150);
      OwnerLicenceKind.Name = "OwnerLicenceKind";
      OwnerLicenceKind.Size = new Size(234, 23);
      OwnerLicenceKind.TabIndex = 321;
      OwnerLicenceKind.SelectedIndexChanged += Action_Change;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(192, 132);
      label7.Name = "label7";
      label7.Size = new Size(36, 15);
      label7.TabIndex = 26;
      label7.Text = "Email";
      // 
      // PartyContactEmail
      // 
      PartyContactEmail.Location = new Point(192, 150);
      PartyContactEmail.Name = "PartyContactEmail";
      PartyContactEmail.ReadOnly = true;
      PartyContactEmail.Size = new Size(170, 23);
      PartyContactEmail.TabIndex = 25;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(8, 132);
      label1.Name = "label1";
      label1.Size = new Size(59, 15);
      label1.TabIndex = 24;
      label1.Text = "Zastupnik";
      // 
      // PartyContactName
      // 
      PartyContactName.Location = new Point(8, 150);
      PartyContactName.Name = "PartyContactName";
      PartyContactName.ReadOnly = true;
      PartyContactName.Size = new Size(178, 23);
      PartyContactName.TabIndex = 23;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(488, 75);
      label5.Name = "label5";
      label5.Size = new Size(36, 15);
      label5.TabIndex = 22;
      label5.Text = "Posta";
      // 
      // PartyAddressPostalZone
      // 
      PartyAddressPostalZone.Location = new Point(488, 93);
      PartyAddressPostalZone.MaxLength = 50;
      PartyAddressPostalZone.Name = "PartyAddressPostalZone";
      PartyAddressPostalZone.Size = new Size(114, 23);
      PartyAddressPostalZone.TabIndex = 21;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(368, 75);
      label6.Name = "label6";
      label6.Size = new Size(32, 15);
      label6.TabIndex = 20;
      label6.Text = "Grad";
      // 
      // PartyAddressCityName
      // 
      PartyAddressCityName.Location = new Point(368, 93);
      PartyAddressCityName.MaxLength = 250;
      PartyAddressCityName.Name = "PartyAddressCityName";
      PartyAddressCityName.Size = new Size(114, 23);
      PartyAddressCityName.TabIndex = 19;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(8, 75);
      label4.Name = "label4";
      label4.Size = new Size(43, 15);
      label4.TabIndex = 18;
      label4.Text = "Adresa";
      // 
      // PartyAddressStreetName
      // 
      PartyAddressStreetName.Location = new Point(8, 93);
      PartyAddressStreetName.MaxLength = 250;
      PartyAddressStreetName.Name = "PartyAddressStreetName";
      PartyAddressStreetName.Size = new Size(354, 23);
      PartyAddressStreetName.TabIndex = 17;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(488, 21);
      label3.Name = "label3";
      label3.Size = new Size(25, 15);
      label3.TabIndex = 16;
      label3.Text = "MB";
      // 
      // PartyLegalEntityCompanyId
      // 
      PartyLegalEntityCompanyId.Location = new Point(488, 39);
      PartyLegalEntityCompanyId.MaxLength = 9;
      PartyLegalEntityCompanyId.Name = "PartyLegalEntityCompanyId";
      PartyLegalEntityCompanyId.Size = new Size(114, 23);
      PartyLegalEntityCompanyId.TabIndex = 15;
      PartyLegalEntityCompanyId.KeyPress += Action_KeyPress;
      // 
      // TaxSchemeCompanyIdLabel
      // 
      TaxSchemeCompanyIdLabel.AutoSize = true;
      TaxSchemeCompanyIdLabel.Location = new Point(368, 21);
      TaxSchemeCompanyIdLabel.Name = "TaxSchemeCompanyIdLabel";
      TaxSchemeCompanyIdLabel.Size = new Size(24, 15);
      TaxSchemeCompanyIdLabel.TabIndex = 14;
      TaxSchemeCompanyIdLabel.Text = "PIB";
      // 
      // PartyTaxSchemeCompanyId
      // 
      PartyTaxSchemeCompanyId.Location = new Point(368, 39);
      PartyTaxSchemeCompanyId.MaxLength = 10;
      PartyTaxSchemeCompanyId.Name = "PartyTaxSchemeCompanyId";
      PartyTaxSchemeCompanyId.Size = new Size(114, 23);
      PartyTaxSchemeCompanyId.TabIndex = 13;
      PartyTaxSchemeCompanyId.KeyPress += Action_KeyPress;
      // 
      // OwnerNameLabel
      // 
      OwnerNameLabel.AutoSize = true;
      OwnerNameLabel.Location = new Point(8, 21);
      OwnerNameLabel.Name = "OwnerNameLabel";
      OwnerNameLabel.Size = new Size(74, 15);
      OwnerNameLabel.TabIndex = 12;
      OwnerNameLabel.Text = "Naziv Firme*";
      // 
      // PartyName
      // 
      PartyName.Location = new Point(8, 39);
      PartyName.MaxLength = 250;
      PartyName.Name = "PartyName";
      PartyName.Size = new Size(354, 23);
      PartyName.TabIndex = 11;
      // 
      // CmdPanel
      // 
      CmdPanel.AutoSize = true;
      CmdPanel.Controls.Add(doSave);
      CmdPanel.Dock = DockStyle.Top;
      CmdPanel.Location = new Point(0, 266);
      CmdPanel.Name = "CmdPanel";
      CmdPanel.Size = new Size(611, 35);
      CmdPanel.TabIndex = 318;
      // 
      // ControlConfig
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(CmdPanel);
      Controls.Add(PartyPanel);
      Name = "ControlConfig";
      Size = new Size(611, 329);
      Load += Action_Refresh;
      PartyPanel.ResumeLayout(false);
      PartyPanel.PerformLayout();
      CmdPanel.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Button doSave;
    private Panel PartyPanel;
    private Label label7;
    private TextBox PartyContactEmail;
    private Label label1;
    private TextBox PartyContactName;
    private Label label5;
    private TextBox PartyAddressPostalZone;
    private Label label6;
    private TextBox PartyAddressCityName;
    private Label label4;
    private TextBox PartyAddressStreetName;
    private Label label3;
    private TextBox PartyLegalEntityCompanyId;
    private Label TaxSchemeCompanyIdLabel;
    private TextBox PartyTaxSchemeCompanyId;
    private Label OwnerNameLabel;
    private TextBox PartyName;
    private Panel CmdPanel;
    private LinkLabel doOwnerDestinationKindSetup;
    private Label OwnerDestinationKindLabel;
    private ComboBox OwnerDestinationKind;
    private Label OwnerOnPremiseLabel;
    private TextBox OwnerSourceOnPremise;
    private Label OwnerLicenceKindLabel;
    private ComboBox OwnerLicenceKind;
    private LinkLabel doOwnerSourceKindSetup;
    private Label OwnerSourceKindLabel;
    private ComboBox OwnerSourceKind;
  }
}
