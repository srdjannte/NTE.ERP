using System.Xml.Serialization;

namespace nte.erp.core.Export
{
  public class ExportSourceMap
  {
    public string Name = string.Empty;
    public string Filter = string.Empty;
    public string Kind = string.Empty;
    public string Query = string.Empty;
    public string ReplaceKey = string.Empty;
    public bool RemoveIfEmpty = false;
    public ExportShema Shema = new ExportShema();
    [XmlIgnore]
    public string TableName
    {
      get
      {
        return this.Query.Contains("Table") ? this.Query : this.Name;
      }
    }
  }
}
