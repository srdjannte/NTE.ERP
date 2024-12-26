namespace nte.erp.client
{
  public class StylesItem
  {
    private bool noStyle = true;
    private Color BackGround = Color.White;
    public StylesItem()
    {

    }
    public void Page_Design(params Panel[] iPanels)
    {
      if (this.noStyle)
      {
        return;
      }
      foreach (Panel fPanel in iPanels)
      {
        fPanel.BackColor = this.BackGround;
      }
    }
    public void SetBody(Panel iPanel)
    {
      if (this.noStyle)
      {
        return;
      }
      iPanel.BackColor = this.BackGround;
    }
    public void SetBody(TabControl iTab)
    {
      if (this.noStyle)
      {
        return;
      }
      iTab.BackColor = this.BackGround;
    }
    public void SetBody(Invoices.Import.ControlDetail iPanel)
    {
      if (this.noStyle)
      {
        return;
      }
      iPanel.BackColor = this.BackGround;
    }
    public void SetCmd(Panel iPanel)
    {
      if (this.noStyle)
      {
        return;
      }
      iPanel.BackColor = this.BackGround;
    }
    public void SetInputLabel(params Label[] iControls)
    {
      if (this.noStyle || iControls == null)
      {
        return;
      }
      foreach (Label fControl in iControls)
      {
        fControl.Enabled = false;
      }
    }
    public void SetInputText(params TextBox[] iControls)
    {
      if (this.noStyle || iControls == null)
      {
        return;
      }
      foreach (TextBox fControl in iControls)
      {
      }
    }
    public void SetInputLink(params LinkLabel[] iControls)
    {
      if (this.noStyle || iControls == null)
      {
        return;
      }
      foreach (LinkLabel fControl in iControls)
      {
        fControl.LinkColor = SystemColors.MenuHighlight;
      }
    }
  }
}
