using nte.erp.client.Common;
using nte.erp.core;

namespace nte.erp.client
{
  public partial class ControlSetup : ControlBase
  {
    private OwnerItem Row = new OwnerItem();
    public ControlSetup()
    {
      InitializeComponent();
    }

    #region Export Event 
    public event ThresholdReachedEventHandler ShowAction;
    public delegate void ThresholdReachedEventHandler(object sender, ActionEventArgs e);
    #endregion

    #region Actions
    public void Action_Refresh(bool iIsNew = false)
    {
      if (iIsNew)
      {
        this.PartyName.Text = "";
        this.PartyTaxSchemeCompanyId.Text = "";
        this.PartyLegalEntityCompanyId.Text = "";
        this.PartyAddressStreetName.Text = "";
        this.PartyAddressCityName.Text = "";
        this.PartyAddressPostalZone.Text = "";
        this.PartyContactName.Text = Environment.UserName;
        this.PartyContactEmail.Text = "";
        this.OwnerSourceKind.Text = "Local";

        if (Utils.Config.OnPremiseForce)
        {
          this.OwnerSourceKind.SelectedIndex = 2;
        }

        this.PartyContactName.Focus();
      }
      else
      {
        this.PartyName.Text = Row.Name;
        this.PartyTaxSchemeCompanyId.Text = Row.TaxSchemeCompanyId;
        this.PartyLegalEntityCompanyId.Text = Row.LegalEntityCompanyId;
        this.PartyAddressStreetName.Text = Row.AddressStreetName;
        this.PartyAddressCityName.Text = Row.AddressCityName;
        this.PartyAddressPostalZone.Text = Row.AddressPostalZone;
        this.PartyContactName.Text = Row.ContactName;
        this.PartyContactEmail.Text = Row.ContactEmail;
        this.OwnerSourceKind.Text = Row.Source.Kind.ToString();
      }
    }
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doSave)
      {
        if (string.IsNullOrEmpty(this.PartyName.Text.Trim()))
        {
          MessageBox.Show("Naziv firme je obavezno!");
          this.PartyName.Focus();

          return;
        }
        if (string.IsNullOrEmpty(this.PartyContactName.Text.Trim()))
        {
          MessageBox.Show("Zastupnik je obavezno!");
          this.PartyContactName.Focus();

          return;
        }
        Row.Name = this.PartyName.Text;
        Row.ContactName = this.PartyContactName.Text;
        Row.ContactEmail = this.PartyContactEmail.Text;
        Row.TaxSchemeCompanyId = this.PartyTaxSchemeCompanyId.Text;
        Row.LegalEntityCompanyId = this.PartyLegalEntityCompanyId.Text;
        Row.AddressStreetName = this.PartyAddressStreetName.Text;
        Row.AddressCityName = this.PartyAddressCityName.Text;
        Row.AddressPostalZone = this.PartyAddressPostalZone.Text;

        Row.LicenceType = this.OwnerSourceKind.Text;
        switch (this.OwnerSourceKind.Items.IndexOf(this.OwnerSourceKind.Text))
        {
          case 1:
            Row.Licence = OwnerItem.Licences.Cloud;
            break;
          case 2:
            Row.Licence = OwnerItem.Licences.OnPremise;
            break;
          default:
            Row.Licence = OwnerItem.Licences.Local;
            break;
        }

        Row.ApiKey = Guid.NewGuid().ToString();
        Row.Uid = Guid.NewGuid().ToString();
        Row.Id = 0;
        Row.State = OwnerItem.States.Active;

        if (!Utils.Config.OwnerExsists(Row))
        {
          Utils.Config.Owner = Row;
          Utils.Config.Save();
          Utils.Data = new DataModule(Row);
          Utils.Config.Owner.DataFile = Utils.Data.FileName;
          Utils.Config.Owners.Add(Row);
          Utils.Config.Save();
          Utils.Data.Save();

          ShowAction?.Invoke(this, new ActionEventArgs("Home"));
        }
        else
        {

        }
      }
    }
    #endregion

  }
}