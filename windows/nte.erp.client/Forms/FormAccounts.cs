using nte.erp.core;

namespace nte.erp.client
{
  public partial class FormAccounts : Form
  {
    public FormAccounts()
    {
      InitializeComponent();
      Utils.Styles.SetBody(this.PanelBody);
      Utils.Styles.SetCmd(this.PanelCmd);
      this.Action_Refresh();
    }

    private void Action_Refresh()
    {
      this.AccList.Items.Clear();
      foreach (OwnerItem fOwner in Utils.Config.Owners)
      {
        this.AccList.Items.Add(fOwner.Name);
      }
    }

    private void Action_Click(object sender, EventArgs e)
    {

    }
  }
}
