using nte.erp.client.Common;
using nte.erp.core;
using nte.erp.core.Export;

namespace nte.erp.client
{
  public partial class ControlConfig : ControlBase
  {
    public ControlConfig()
    {
      InitializeComponent();
    }

    #region Export Event 
    public event ThresholdReachedEventHandler ShowAction;
    public delegate void ThresholdReachedEventHandler(object sender, ActionEventArgs e);
    #endregion

    private void Action_Refresh(object sender, EventArgs e)
    {
      this.Action_Refresh();
    }
    private void Action_Refresh()
    {
      this.PartyName.Text = Utils.Config.Owner.Name;
      this.PartyContactName.Text = Utils.Config.Owner.ContactName;
      this.PartyContactEmail.Text = Utils.Config.Owner.ContactEmail;

      this.PartyTaxSchemeCompanyId.Text = Utils.Config.Owner.TaxSchemeCompanyId;
      this.PartyLegalEntityCompanyId.Text = Utils.Config.Owner.LegalEntityCompanyId;
      this.PartyAddressStreetName.Text = Utils.Config.Owner.AddressStreetName;
      this.PartyAddressCityName.Text = Utils.Config.Owner.AddressCityName;
      this.PartyAddressPostalZone.Text = Utils.Config.Owner.AddressPostalZone;

      this.OwnerLicenceKind.Text = Utils.Config.Owner.LicenceType.ToString();

      this.OwnerDestinationKind.Text = Utils.Config.Owner.Destination.Provider.ToString();
      this.OwnerSourceKind.Text = Utils.Config.Owner.Source.Kind.ToString();
    }

    private void Action_Click(object sender, EventArgs e)
    {

      if (sender == this.doOwnerDestinationKindSetup)
      {
        using (FormConfigDestination fSourceForm = new FormConfigDestination(this.OwnerDestinationKind.Text))
        {
          fSourceForm.ShowDialog(this);
        }
      }

      if (sender == this.doSave)
      {
        Utils.Config.Owner.Name = this.PartyName.Text;
        Utils.Config.Owner.TaxSchemeCompanyId = this.PartyTaxSchemeCompanyId.Text;
        Utils.Config.Owner.LegalEntityCompanyId = this.PartyLegalEntityCompanyId.Text;
        Utils.Config.Owner.AddressStreetName = this.PartyAddressStreetName.Text;
        Utils.Config.Owner.AddressCityName = this.PartyAddressCityName.Text;
        Utils.Config.Owner.AddressPostalZone = this.PartyAddressPostalZone.Text;
        Utils.Config.Owner.ContactName = this.PartyContactName.Text;
        Utils.Config.Owner.ContactEmail = this.PartyContactEmail.Text;

        if (Enum.TryParse(this.OwnerDestinationKind.Text, out ExportSendProvider fProvider))
        {
          Utils.Config.Owner.Destination.Provider = fProvider;
        }
        else
        {
          Utils.Config.Owner.Destination.Provider = ExportSendProvider.Skip;
        }

        if (Enum.TryParse(this.OwnerSourceKind.Text, out SourceKind fKind))
        {
          Utils.Config.Owner.Source.Kind = fKind;
        }

        switch (this.OwnerSourceKind.Items.IndexOf(this.OwnerSourceKind.Text))
        {
          case 1:
            Utils.Config.Owner.Licence = OwnerItem.Licences.Cloud;
            break;
          case 2:
            Utils.Config.Owner.Licence = OwnerItem.Licences.OnPremise;
            break;
          default:
            Utils.Config.Owner.Licence = OwnerItem.Licences.Local;
            break;
        }

        bool fNotFound = true;
        for (int i = 0; i < Utils.Config.Owners.Count; i++)
        {
          if (Utils.Config.Owners[i].Uid == Utils.Config.Owner.Uid)
          {
            Utils.Config.Owners[i] = Utils.Config.Owner;
            fNotFound = false;
          }
        }
        if (fNotFound)
        {
          Utils.Config.Owners.Add(Utils.Config.Owner);
        }
        Utils.Config.Save();
        Utils.Data.Sync(Utils.Config.Owner);
        Utils.Data.Save();
        ShowAction?.Invoke(this, new ActionEventArgs("Home"));
      }
    }

    private void Action_Change(object sender, EventArgs e)
    {
      this.OwnerOnPremiseLabel.Visible = (this.OwnerLicenceKind.Text == "On Premise");
      this.OwnerSourceOnPremise.Visible = (this.OwnerLicenceKind.Text == "On Premise");

      this.doOwnerDestinationKindSetup.Visible = (this.OwnerDestinationKind.Text != "");
      this.doOwnerSourceKindSetup.Visible = (this.OwnerSourceKind.Text != "");
    }
    private void Action_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!int.TryParse(e.KeyChar.ToString(), out int i))
      {
        e.KeyChar = '\0';
      }
    }
  }
}
