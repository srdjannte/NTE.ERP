using nte.erp.client.Common;
using nte.erp.core;

namespace nte.erp.client
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();

      Utils.Language.Translate(this);

      this.Desing_Init();
      this.Design_Refresh();
    }

    #region Design
    private void Desing_Init()
    {
      this.Action_Resize(this.MainStrip, null);
      this.Design_ShowPanel();
      Utils.Styles.Page_Design(this.MainHome, this.MainSetup, this.MainPage, this.MainDetails, this.MainConfig);
    }
    private void Desing_SetTitle(string iSubTitle = "")
    {
      if (string.IsNullOrEmpty(iSubTitle))
      {
        this.Text = Application.ProductName;
      }
      else
      {
        this.Text = string.Format("{1} - {0}", Application.ProductName, iSubTitle);
        this.MenuPage.Text = iSubTitle;
      }
    }
    private void Design_Refresh()
    {
      switch (Utils.Config.Owner.State)
      {
        case OwnerItem.States.Empty:
        case OwnerItem.States.OnBoard:
          this.MenuFileSetup.Visible = true;

          this.MenuFileHomePage.Visible = false;
          this.MenuFileParty.Visible = false;
          this.MenuFileInvoiceImport.Visible = false;
          this.MenuFileInvoiceExport.Visible = false;
          this.MenuFileStatement.Visible = false;
          this.MenuFileDocument.Visible = false;
          this.MenuFileConfig.Visible = false;

          this.MenuOptions.Visible = false;


          //this.Action_ShowPage(new ActionEventArgs("Setup"));
          this.Action_ShowPage(new ActionEventArgs("Home"));
          break;
        case OwnerItem.States.Active:
          this.MenuFileSetup.Visible = false;

          this.MenuFileHomePage.Visible = true;
          this.MenuFileParty.Visible = true;
          this.MenuFileInvoiceImport.Visible = true;
          this.MenuFileInvoiceExport.Visible = true;
          this.MenuFileStatement.Visible = true;
          this.MenuFileDocument.Visible = true;
          this.MenuFileConfig.Visible = true;

          this.MenuOptions.Visible = true;

          this.Action_ShowPage(new ActionEventArgs("Home"));
          Utils.Data = new DataModule(Utils.Config.Owner.Source, Utils.Config.Owner.DataFile);
          Utils.Data.InfoUid = Utils.Config.Owner.Uid;
          break;
        case OwnerItem.States.Deleted:
          break;
      }
    }
    private void Design_ShowPanel(Panel iPanel, ControlBase iBase)
    {
      this.MainHome.Visible = (iPanel == this.MainHome);
      this.MainSetup.Visible = (iPanel == this.MainSetup);
      this.MainPage.Visible = (iPanel == this.MainPage);
      this.MainDetails.Visible = (iPanel == this.MainDetails);
      this.MainConfig.Visible = (iPanel == this.MainConfig);
    }
    private void Design_ShowPanel(Panel iPanel = null, Type classType = null)
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
        if ((iPanel == this.MainPage) && (classType != null))
        {
          bool fFound = false;
          foreach (ControlBase fBase in iPanel.Controls)
          {
            if (fBase.GetType() == classType)
            {
              fFound = true;
              fBase.Visible = true;
              this.SetMenuStrip(this.MenuPage, fBase.MenuItems);
            }
            else
            {
              fBase.Visible = false;
            }
          }

          if (!fFound)
          {
            ControlBase fPage = null;
            switch (classType.ToString())
            {
              case "nte.erp.client.Codebook.Party.ControlList":
                fPage = new Codebook.Party.ControlList();
                break;
              case "nte.erp.client.Invoices.Import.ControlList":
                fPage = new Invoices.Import.ControlList();
                break;
            }
            if (fPage != null)
            {
              fPage.Dock = DockStyle.Fill;
              this.MainPage.Controls.Add(fPage);
              this.SetMenuStrip(this.MenuPage, fPage.MenuItems);
              //this.SetMenuStrip(this.MainStrip, this.GetMenuItems(this.MainPage));
            }
          }
        }

        this.MenuPage.Visible = (iPanel == this.MainPage) && 0 < this.MenuPage.DropDownItems.Count;

        this.MainHome.Visible = (iPanel == this.MainHome);
        this.MainSetup.Visible = (iPanel == this.MainSetup);
        this.MainPage.Visible = (iPanel == this.MainPage);
        this.MainDetails.Visible = (iPanel == this.MainDetails);
        this.MainConfig.Visible = (iPanel == this.MainConfig);
      }
    }
    #endregion

    #region Actions
    private bool GetPage(Panel iPanel, out ControlBase iPage)
    {
      iPage = null;
      if ((iPanel != null) && (0 < iPanel.Controls.Count))
      {
        if (iPanel.Controls[0] is ControlBase)
        {
          iPage = (iPanel.Controls[0] as ControlBase);

          return true;
        }
      }

      return false;
    }
    private List<ToolStripItem> GetMenuItems(Panel iPanel)
    {
      if ((iPanel != null) && (0 < iPanel.Controls.Count))
      {
        if (iPanel.Controls[0] is ControlBase)
        {
          return (iPanel.Controls[0] as ControlBase).MenuItems;
        }
      }

      return new List<ToolStripItem>();
    }
    private void Action_ShowPage(ActionEventArgs iActon)
    {
      switch (iActon.PageName)
      {
        case "Home":
          this.Desing_SetTitle(Utils.Config.Owner.Name);

          switch (Utils.Config.Owner.State)
          {
            case OwnerItem.States.Empty:
              this.Text = "Dobrodosli - " + Application.ProductName;
              this.MenuFileSetup.Visible = true;

              this.MenuFileHomePage.Visible = false;
              this.MenuFileInvoiceImport.Visible = false;
              this.MenuFileInvoiceExport.Visible = false;
              this.MenuFileStatement.Visible = false;
              this.MenuFileDocument.Visible = false;
              this.MenuFileConfig.Visible = false;

              this.MenuOptions.Visible = false;
              break;
            case OwnerItem.States.OnBoard:
              this.Text = Utils.Config.Owner.Name + " - " + Application.ProductName;
              this.MenuFileSetup.Visible = true;

              this.MenuFileHomePage.Visible = false;
              this.MenuFileInvoiceImport.Visible = false;
              this.MenuFileInvoiceExport.Visible = false;
              this.MenuFileStatement.Visible = false;
              this.MenuFileDocument.Visible = false;
              this.MenuFileConfig.Visible = false;

              this.MenuOptions.Visible = false;
              break;
            case OwnerItem.States.Active:
              this.Text = Utils.Config.Owner.Name + " - " + Application.ProductName;
              this.MenuFileSetup.Visible = false;

              this.MenuFileHomePage.Visible = true;
              this.MenuFileInvoiceImport.Visible = true;
              this.MenuFileInvoiceExport.Visible = true;
              this.MenuFileStatement.Visible = true;
              this.MenuFileDocument.Visible = true;
              this.MenuFileConfig.Visible = true;

              this.MenuOptions.Visible = true;
              break;
            case OwnerItem.States.Deleted:
              this.Text = Utils.Config.Owner.Name + " - IZBRISANO - " + Application.ProductName;
              break;
          }

          if (this.MainHome.Controls.Count == 0)
          {
            ControlHome fPage = new ControlHome();
            fPage.Dock = DockStyle.Fill;
            fPage.ShowAction += Action_ShowAction;
            this.MainHome.Controls.Add(fPage);
          }
          (this.MainHome.Controls[0] as ControlHome).Action_Refresh();
          this.SetMenuStrip(this.MainStrip);
          this.Design_ShowPanel(this.MainHome);
          break;
        case "Setup":
          this.Desing_SetTitle("Setup");

          if (this.MainSetup.Controls.Count == 0)
          {
            ControlSetup fPage = new ControlSetup();
            fPage.Dock = DockStyle.Fill;
            fPage.ShowAction += Action_ShowAction;
            this.MainSetup.Controls.Add(fPage);
          }
          (this.MainSetup.Controls[0] as ControlSetup).Action_Refresh(true);
          this.Design_ShowPanel(this.MainSetup);
          break;
        case "Config":
          this.Desing_SetTitle("Podešavanje");

          if (this.MainConfig.Controls.Count == 0)
          {
            ControlConfig fPage = new ControlConfig();
            fPage.Dock = DockStyle.Fill;
            fPage.ShowAction += Action_ShowAction;
            this.MainConfig.Controls.Add(fPage);
          }
          this.Design_ShowPanel(this.MainConfig);
          break;
        case "Party":
          this.Desing_SetTitle("Adresar");
          this.Design_ShowPanel(this.MainPage, typeof(Codebook.Party.ControlList));
          break;
        case "InvoiceImport":
          this.Desing_SetTitle("Ulazne Fakture");
          this.Design_ShowPanel(this.MainPage, typeof(Invoices.Import.ControlList));
          break;
        case "Statements":
          this.Desing_SetTitle("Izvodi");
          this.Design_ShowPanel(this.MainPage, typeof(Statements.ControlList));
          break;
        case "Documents":
          this.Desing_SetTitle("Dokumenta");
          this.Design_ShowPanel(this.MainPage, typeof(Statements.ControlList));
          break;
        default:
          this.Desing_SetTitle();
          break;
      }
    }
    private void Action_ShowAction(object sender, ActionEventArgs e)
    {
      this.Action_ShowPage(e);
    }
    private void Action_Click(object sender, EventArgs e)
    {
      #region Program
      if (sender == this.MenuFileHomePage || sender == this.MenuStripGoHome)
      {
        this.Action_ShowPage(new ActionEventArgs("Home"));
      }
      if (sender == this.MenuFileSetup)
      {
        this.Action_ShowPage(new ActionEventArgs("Setup"));
      }
      if (sender == this.MenuFileConfig)
      {
        this.Action_ShowPage(new ActionEventArgs("Config"));
      }
      if (sender == this.MenuFileClose)
      {
        this.Close();
      }
      if (sender == this.MenuFileOwners)
      {
        using (FormAccounts fAccounts = new FormAccounts())
        {
          switch (fAccounts.ShowDialog(this))
          {
            case DialogResult.Continue:
              this.Action_ShowPage(new ActionEventArgs("Setup"));
              break;
          }
        }
      }
      #endregion

      #region Program Items      
      if (sender == this.MenuFileParty)
      {
        this.Action_ShowPage(new ActionEventArgs("Party"));
      }
      if (sender == this.MenuFileInvoiceImport)
      {
        this.Action_ShowPage(new ActionEventArgs("InvoiceImport"));
      }
      if (sender == this.MenuFileStatement)
      {
        this.Action_ShowPage(new ActionEventArgs("Statements"));
      }
      if (sender == this.MenuFileDocument)
      {
        this.Action_ShowPage(new ActionEventArgs("Documents"));
      }
      #endregion

      #region Page 
      if (sender == this.MenuPage)
      {

        //this.MenuPage.DropDownItems.Add()
      }
      #endregion
    }
    private void Action_Resize(object sender, EventArgs e)
    {
      try
      {
        if (sender == this.MainStrip)
        {
          this.MainStrip.Update();
          this.MainStrip.Refresh();
          int fWide = 0;

          for (int i = 0; i < this.MainStrip.Items.Count; i++)
          {
            if (this.MainStrip.Items[i].Name != "MenuStripWide")
            {
              fWide += this.MainStrip.Items[i].Width;
            }
          }

          if (0 < fWide && fWide < this.MainStrip.Width)
          {
            this.MenuStripWide.Width = this.MainStrip.Width - (fWide + 4);
          }
          this.MainStrip.Update();
          this.MainStrip.Refresh();
        }
      }
      catch
      {

      }
    }
    private void Action_FindText(object sender, EventArgs e)
    {
      this.FindPanel.Visible = !string.IsNullOrEmpty(this.MenuStripFindText.Text);
      this.FindPanel.BringToFront();
    }
    #endregion

    #region Set Menus
    public void SetMenuStrip(ToolStrip iMenu, List<ToolStripItem> iItems = null)
    {
      try
      {
        for (int i = (iMenu.Items.Count - 1); 0 <= i; i--)
        {
          if (iMenu.Items[i].Name != "MenuStripWide")
          {
            if (!iMenu.Items[i].Name.Contains("MenuStrip"))
            {
              //iMenu.Items.RemoveAt(i);
            }
          }
        }

        if ((iItems != null) && (0 < iItems.Count))
        {
          for (int i = 0; i < iItems.Count; i++)
          {
            iMenu.Items.Insert((2 + i), iItems[i]);
          }
        }
      }
      finally
      {
        //this.PageShowTimer.Enabled = true;
        this.Action_Resize(this.MainStrip, null);
      }
    }
    public void SetMenuStrip(ToolStripMenuItem iMenu, List<ToolStripItem> iItems = null)
    {
      try
      {
        iMenu.DropDownItems.Clear();

        if ((iItems != null) && (0 < iItems.Count))
        {
          for (int i = 0; i < iItems.Count; i++)
          {
            iMenu.DropDownItems.Add(iItems[i]);
          }
        }
      }
      catch
      {
      }
    }
    #endregion
  }
}
