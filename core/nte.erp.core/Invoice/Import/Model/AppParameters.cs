namespace nte.erp.core.Import
{
  public class AppParameters
  {
    public string PredefinedConfigName { get; set; }
    public int? Id { get; set; }
    public int? SyncLastDays { get; set; }
    public DateTime? SyncFrom { get; set; }
    public DateTime? SyncTo { get; set; }
    public bool FullSync { get; set; }
    public bool? Accept { get; set; }
    public bool SyncStatus { get; set; }
    public string Comment { get; set; }
    public bool SyncXml { get; set; }
    public string XmlFilePath { get; set; }
    public bool IsValid { get; set; }
    public string ValidationErrorMessage { get; set; }
  }
}
