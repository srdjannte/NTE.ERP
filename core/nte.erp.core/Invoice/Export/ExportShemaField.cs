using System.Xml.Serialization;

namespace nte.erp.core.Export
{
  public enum ConvertToTypes { Implicit, String, Integer, Percent, Money, Date, Time, DateTime };
  public enum ConvertErrorTypes { Stop, Skip }
  public enum ConvertIfEmpty { Ignore, Remove, Stop, Default }
  [Serializable]
  [XmlRoot("Field")]
  public class ExportShemaField
  {
    public string Name = string.Empty;
    public string SourceName = string.Empty;
    public ConvertToTypes ConvertTo = ConvertToTypes.String;
    public ConvertErrorTypes ConvertError = ConvertErrorTypes.Stop;
    public ConvertIfEmpty IfEmpty = ConvertIfEmpty.Ignore;
    public string DefaultValue = string.Empty;
  }
}
