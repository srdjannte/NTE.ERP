namespace nte.erp.client
{
  public partial class FormConfigDestination : Form
  {
    private string ProviderText = string.Empty;
    public FormConfigDestination(string iProviderText)
    {
      InitializeComponent();
      this.ProviderText = iProviderText;
      this.ExportSendProvider.Text = this.ProviderText;// Utils.Config.Owner.Destination.Provider.ToString();
      this.ExportSendProvider_SelectedIndexChanged(this.ExportSendProvider, null);
    }

    private void ExportSendProvider_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.ExportSendProvider.Text)
      {
        case "File":
          this.SendToFilePanel.Visible = true;
          this.SendToSEFPanel.Visible = false;
          this.SendToMRPanel.Visible = false;
          break;
        case "SEF":
          this.SendToFilePanel.Visible = false;
          this.SendToSEFPanel.Visible = true;
          this.SendToMRPanel.Visible = false;
          break;
        case "MojeRacun":
          this.SendToFilePanel.Visible = false;
          this.SendToSEFPanel.Visible = false;
          this.SendToMRPanel.Visible = true;
          break;
        default:
          this.SendToFilePanel.Visible = false;
          this.SendToSEFPanel.Visible = false;
          this.SendToMRPanel.Visible = false;
          break;
      }
    }
  }
}
