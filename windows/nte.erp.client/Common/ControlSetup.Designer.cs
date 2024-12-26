namespace nte.erp.client
{
  partial class ControlSetup
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
      statusStrip1 = new StatusStrip();
      doSave = new Button();
      PartyPanel = new Panel();
      OwnerSourceKindLabel = new Label();
      OwnerSourceKind = new ComboBox();
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
      label2 = new Label();
      PartyName = new TextBox();
      doLoadFile = new LinkLabel();
      PartyPanel.SuspendLayout();
      SuspendLayout();
      // 
      // statusStrip1
      // 
      statusStrip1.Location = new Point(0, 382);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(617, 22);
      statusStrip1.TabIndex = 0;
      statusStrip1.Text = "statusStrip1";
      // 
      // doSave
      // 
      doSave.Location = new Point(19, 195);
      doSave.Name = "doSave";
      doSave.Size = new Size(104, 23);
      doSave.TabIndex = 2;
      doSave.Text = "Otvori Nalog";
      doSave.UseVisualStyleBackColor = true;
      doSave.Click += Action_Click;
      // 
      // PartyPanel
      // 
      PartyPanel.Controls.Add(OwnerSourceKindLabel);
      PartyPanel.Controls.Add(OwnerSourceKind);
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
      PartyPanel.Controls.Add(label2);
      PartyPanel.Controls.Add(PartyName);
      PartyPanel.Dock = DockStyle.Top;
      PartyPanel.Location = new Point(0, 0);
      PartyPanel.Name = "PartyPanel";
      PartyPanel.Size = new Size(617, 185);
      PartyPanel.TabIndex = 11;
      // 
      // OwnerSourceKindLabel
      // 
      OwnerSourceKindLabel.AutoSize = true;
      OwnerSourceKindLabel.Location = new Point(368, 18);
      OwnerSourceKindLabel.Name = "OwnerSourceKindLabel";
      OwnerSourceKindLabel.Size = new Size(72, 15);
      OwnerSourceKindLabel.TabIndex = 320;
      OwnerSourceKindLabel.Text = "Vrsta Usluge";
      // 
      // OwnerSourceKind
      // 
      OwnerSourceKind.DropDownStyle = ComboBoxStyle.DropDownList;
      OwnerSourceKind.FormattingEnabled = true;
      OwnerSourceKind.Items.AddRange(new object[] { "Local", "Cloud", "OnPremise" });
      OwnerSourceKind.Location = new Point(368, 36);
      OwnerSourceKind.Name = "OwnerSourceKind";
      OwnerSourceKind.Size = new Size(234, 23);
      OwnerSourceKind.TabIndex = 321;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(203, 18);
      label7.Name = "label7";
      label7.Size = new Size(36, 15);
      label7.TabIndex = 26;
      label7.Text = "Email";
      // 
      // PartyContactEmail
      // 
      PartyContactEmail.Location = new Point(203, 36);
      PartyContactEmail.Name = "PartyContactEmail";
      PartyContactEmail.Size = new Size(156, 23);
      PartyContactEmail.TabIndex = 25;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(19, 18);
      label1.Name = "label1";
      label1.Size = new Size(64, 15);
      label1.TabIndex = 24;
      label1.Text = "Zastupnik*";
      // 
      // PartyContactName
      // 
      PartyContactName.Location = new Point(19, 36);
      PartyContactName.Name = "PartyContactName";
      PartyContactName.Size = new Size(178, 23);
      PartyContactName.TabIndex = 23;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(488, 130);
      label5.Name = "label5";
      label5.Size = new Size(36, 15);
      label5.TabIndex = 22;
      label5.Text = "Pošta";
      // 
      // PartyAddressPostalZone
      // 
      PartyAddressPostalZone.Location = new Point(488, 148);
      PartyAddressPostalZone.Name = "PartyAddressPostalZone";
      PartyAddressPostalZone.Size = new Size(114, 23);
      PartyAddressPostalZone.TabIndex = 21;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(368, 130);
      label6.Name = "label6";
      label6.Size = new Size(32, 15);
      label6.TabIndex = 20;
      label6.Text = "Grad";
      // 
      // PartyAddressCityName
      // 
      PartyAddressCityName.Location = new Point(368, 148);
      PartyAddressCityName.Name = "PartyAddressCityName";
      PartyAddressCityName.Size = new Size(114, 23);
      PartyAddressCityName.TabIndex = 19;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(19, 130);
      label4.Name = "label4";
      label4.Size = new Size(83, 15);
      label4.TabIndex = 18;
      label4.Text = "Sedište Adresa";
      // 
      // PartyAddressStreetName
      // 
      PartyAddressStreetName.Location = new Point(19, 148);
      PartyAddressStreetName.Name = "PartyAddressStreetName";
      PartyAddressStreetName.Size = new Size(340, 23);
      PartyAddressStreetName.TabIndex = 17;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(488, 74);
      label3.Name = "label3";
      label3.Size = new Size(25, 15);
      label3.TabIndex = 16;
      label3.Text = "MB";
      // 
      // PartyLegalEntityCompanyId
      // 
      PartyLegalEntityCompanyId.Location = new Point(488, 92);
      PartyLegalEntityCompanyId.Name = "PartyLegalEntityCompanyId";
      PartyLegalEntityCompanyId.Size = new Size(114, 23);
      PartyLegalEntityCompanyId.TabIndex = 15;
      // 
      // TaxSchemeCompanyIdLabel
      // 
      TaxSchemeCompanyIdLabel.AutoSize = true;
      TaxSchemeCompanyIdLabel.Location = new Point(368, 74);
      TaxSchemeCompanyIdLabel.Name = "TaxSchemeCompanyIdLabel";
      TaxSchemeCompanyIdLabel.Size = new Size(24, 15);
      TaxSchemeCompanyIdLabel.TabIndex = 14;
      TaxSchemeCompanyIdLabel.Text = "PIB";
      // 
      // PartyTaxSchemeCompanyId
      // 
      PartyTaxSchemeCompanyId.Location = new Point(368, 92);
      PartyTaxSchemeCompanyId.Name = "PartyTaxSchemeCompanyId";
      PartyTaxSchemeCompanyId.Size = new Size(114, 23);
      PartyTaxSchemeCompanyId.TabIndex = 13;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(19, 74);
      label2.Name = "label2";
      label2.Size = new Size(74, 15);
      label2.TabIndex = 12;
      label2.Text = "Naziv Firme*";
      // 
      // PartyName
      // 
      PartyName.Location = new Point(19, 92);
      PartyName.Name = "PartyName";
      PartyName.Size = new Size(340, 23);
      PartyName.TabIndex = 11;
      // 
      // doLoadFile
      // 
      doLoadFile.AutoSize = true;
      doLoadFile.Font = new Font("Segoe UI", 9F);
      doLoadFile.LinkBehavior = LinkBehavior.HoverUnderline;
      doLoadFile.LinkColor = SystemColors.HotTrack;
      doLoadFile.Location = new Point(19, 231);
      doLoadFile.Name = "doLoadFile";
      doLoadFile.Size = new Size(131, 15);
      doLoadFile.TabIndex = 16;
      doLoadFile.TabStop = true;
      doLoadFile.Text = "Učitaj datoteku sa diska";
      doLoadFile.TextAlign = ContentAlignment.MiddleRight;
      // 
      // ControlSetup
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(doLoadFile);
      Controls.Add(PartyPanel);
      Controls.Add(doSave);
      Controls.Add(statusStrip1);
      Name = "ControlSetup";
      Size = new Size(617, 404);
      PartyPanel.ResumeLayout(false);
      PartyPanel.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private StatusStrip statusStrip1;
    private Button doSave;
    private Panel PartyPanel;
    private Label TaxSchemeCompanyIdLabel;
    private TextBox PartyTaxSchemeCompanyId;
    private Label label2;
    private TextBox PartyName;
    private Label label3;
    private TextBox PartyLegalEntityCompanyId;
    private Label label4;
    private TextBox PartyAddressStreetName;
    private Label label5;
    private TextBox PartyAddressPostalZone;
    private Label label6;
    private TextBox PartyAddressCityName;
    private Label label7;
    private TextBox PartyContactEmail;
    private Label label1;
    private TextBox PartyContactName;
    private Label OwnerSourceKindLabel;
    private ComboBox OwnerSourceKind;
    private LinkLabel doLoadFile;
  }
}
