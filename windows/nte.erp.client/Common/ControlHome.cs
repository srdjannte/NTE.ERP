using nte.erp.client.Common;

namespace nte.erp.client
{
  public partial class ControlHome : ControlBase
  {
    public ControlHome()
    {
      InitializeComponent();
    }

    #region Export Event 
    public event ThresholdReachedEventHandler ShowAction;
    public delegate void ThresholdReachedEventHandler(object sender, ActionEventArgs e);
    #endregion

    public void Action_Refresh()
    {
      if (Utils.Config.Owner.State == core.OwnerItem.States.Empty)
      {
        this.OwnerPanel.Visible = false;
        this.MenuPanel.Visible = false;
        this.CmdPanel.Visible = false;
        this.EmptyPanel.Visible = true;
      }
      else
      {
        this.OwnerName.Text = Utils.Config.Owner.Name;

        this.OwnerInfo.Text = string.Format("PIB: {0}  MB: {1} {2}", Utils.Config.Owner.TaxSchemeCompanyId, Utils.Config.Owner.LegalEntityCompanyId, Utils.Config.Owner.AddressCityName);

        this.OwnerPanel.Visible = true;
        this.MenuPanel.Visible = true;
        this.CmdPanel.Visible = true;
        this.EmptyPanel.Visible = false;
      }
    }

    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doInvoiceImport)
      {
        ShowAction?.Invoke(this, new ActionEventArgs("InvoiceImport"));
      }
      if (sender == this.doConfig)
      {
        ShowAction?.Invoke(this, new ActionEventArgs("Config"));
      }
      if (sender == this.doOwnerNew)
      {
        ShowAction?.Invoke(this, new ActionEventArgs("Setup"));
      }
      if (sender == this.doOwnerOpenFile)
      {
        //ShowAction?.Invoke(this, new ActionEventArgs("Config"));
      }
      if (sender == this.doParty)
      {
        ShowAction?.Invoke(this, new ActionEventArgs("Party"));
      }
      if (sender == this.doStatements)
      {
        ShowAction?.Invoke(this, new ActionEventArgs("Statements"));
      }
      if (sender == this.doDocuments)
      {
        ShowAction?.Invoke(this, new ActionEventArgs("Documents"));
      }
    }
  }
}
