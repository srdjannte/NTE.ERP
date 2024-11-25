namespace nte.erp.core.Export
{
  public enum ExportSourceKind { Test, MsSql, MySql, ODBC, File, WebService, Assembly };
  public class ExportSource
  {
    public string Name = string.Empty;
    public ExportSourceKind Kind = ExportSourceKind.Test;
    public string TestFileName = string.Empty;
    public int Timeout = 15;
    public string ConnectionStr = string.Empty;
    public string ListQuery = string.Empty;
    public string MainQuery = string.Empty;
    public string TestID = string.Empty;

    public void Update(string iName, string iKind, string iTestFileName, string iTimeout, string iConnectionStr, string iListQuery, string iMainQuery)
    {
      this.Name = iName;
      this.ConnectionStr = iConnectionStr;
      this.TestFileName = iTestFileName;
      this.ListQuery = iListQuery;
      this.MainQuery = iMainQuery;
      if (int.TryParse(iTimeout, out int oTimeout))
      {
        this.Timeout = oTimeout;
      }
      if (Enum.TryParse(iKind, out ExportSourceKind fKind))
      {
        this.Kind = fKind;
      }
    }
  }
}
