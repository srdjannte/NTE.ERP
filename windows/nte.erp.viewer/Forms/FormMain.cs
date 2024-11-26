using nte.erp.viewer.Forms;
using static nte.erp.viewer.ControlHome;

namespace nte.erp.viewer
{
  public partial class FormMain : Form
  {
    private enum OpenActions { Home, Setup, Page, Details, Config };
    public FormMain()
    {
      InitializeComponent();

      this.Action_ShowPanel();

      this.MainHome.BackColor = Color.White;
      this.MainSetup.BackColor = Color.White;
      this.MainPage.BackColor = Color.White;
      this.MainDetails.BackColor = Color.White;
      this.MainConfig.BackColor = Color.White;
    }
    private void Action_ShowPanel(Panel iPanel = null)
    {
      if (iPanel == null)
      {
        this.MainHome.Visible = false;
        this.MainSetup.Visible = false;
        this.MainPage.Visible = false;
        this.MainDetails.Visible = false;
        this.MainConfig.Visible = false;
      }
      else
      {
        this.MainHome.Visible = (iPanel == this.MainHome);
        this.MainSetup.Visible = (iPanel == this.MainSetup);
        this.MainPage.Visible = (iPanel == this.MainPage);
        this.MainDetails.Visible = (iPanel == this.MainDetails);
        this.MainConfig.Visible = (iPanel == this.MainConfig);
      }
    }
    private void Action_ShowPage(OpenActions iActon)
    {
      switch (iActon)
      {
        case OpenActions.Home:
          if (this.MainHome.Controls.Count == 0)
          {
            ControlHome fPage = new ControlHome();
            fPage.Dock = DockStyle.Fill;
            fPage.ThresholdReached += c_ThresholdReached;
            this.MainHome.Controls.Add(fPage);
          }
          this.Action_ShowPanel(this.MainHome);
          break;
        case OpenActions.Setup:
          if (this.MainSetup.Controls.Count == 0)
          {
            ControlSetup fPage = new ControlSetup();
            fPage.Dock = DockStyle.Fill;
            this.MainSetup.Controls.Add(fPage);
          }
          this.Action_ShowPanel(this.MainSetup);
          break;
        case OpenActions.Page:
          if (this.MainPage.Controls.Count == 0)
          {
            ControlInvoiceImport fPage = new ControlInvoiceImport();
            fPage.Dock = DockStyle.Fill;
            this.MainPage.Controls.Add(fPage);
          }
          this.Action_ShowPanel(this.MainPage);
          break;
        case OpenActions.Details:
          if (this.MainDetails.Controls.Count == 0)
          {
            ControlSetup fPage = new ControlSetup();
            fPage.Dock = DockStyle.Fill;
            this.MainDetails.Controls.Add(fPage);
          }
          this.Action_ShowPanel(this.MainDetails);
          break;
        case OpenActions.Config:
          if (this.MainConfig.Controls.Count == 0)
          {
            ControlSetup fPage = new ControlSetup();
            fPage.Dock = DockStyle.Fill;
            this.MainConfig.Controls.Add(fPage);
          }
          this.Action_ShowPanel(this.MainConfig);
          break;
      }
    }
    private void c_ThresholdReached(object sender, EventArgs e)
    {
      this.Action_ShowPage(OpenActions.Page);
    }

    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.MenuGoHome)
      {
        this.Action_ShowPage(OpenActions.Home);
      }
      if (sender == this.MenuFileSetup)
      {
        this.Action_ShowPage(OpenActions.Setup);
      }
      if (sender == this.MenuFilePage)
      {
        this.Action_ShowPage(OpenActions.Page);
      }
      if (sender == this.MenuFileClose)
      {
        this.Close();
      }
    }
  }
}
