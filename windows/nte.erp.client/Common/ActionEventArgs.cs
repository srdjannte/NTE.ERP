namespace nte.erp.client
{
  public class ActionEventArgs : EventArgs
  {
    public ActionEventArgs()
    {

    }
    public ActionEventArgs(string iPageName)
    {
      PageName = iPageName;
    }
    public ActionEventArgs(string iPageName, string iModule)
    {
      PageName = iPageName;
      Module = iModule;
    }
    public string PageName { get; set; }
    public string Module { get; set; }
    public string Assembly { get; set; }
    public string Params { get; set; }

  }
}
