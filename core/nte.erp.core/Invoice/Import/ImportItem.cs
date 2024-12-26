using nte.erp.core.Export;
using System.Xml.Serialization;

namespace nte.erp.core.Import
{
  public class ImportItem
  {
    public string Name = string.Empty;
    public string Description = string.Empty;

    public ExportSource Source = new ExportSource();
    public ExportSend Target = new ExportSend();
    public ExportSend Result = new ExportSend();

    public string CreateUid = string.Empty;
    public DateTime CreateAt = DateTime.Now;
    public string CreateBy = string.Empty;
    public DateTime ChangeAt = DateTime.Now;
    public string ChangeBy = string.Empty;
    public string ChangeOn = string.Empty;
    public int ChangeRev = 0;
    [XmlIgnore]
    public string FileName = string.Empty;
    [XmlIgnore]
    public DateTime LoadAt;
    [XmlIgnore]
    public DateTime SaveAt;
    public ImportItem()
    {

    }
    public ImportItem(string iName)
    {
      this.Name = iName;

      this.CreateUid = Guid.NewGuid().ToString();
      this.CreateAt = DateTime.Now;
      this.CreateBy = Environment.UserName;
      this.ChangeAt = DateTime.Now;
      this.ChangeBy = String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
      this.ChangeOn = Environment.MachineName;
    }
    public void Update(string iName, string iDescription, string iFileName = "")
    {
      this.Name = iName;
      this.Description = iDescription;
      if (!string.IsNullOrEmpty(iFileName))
      {
        this.FileName = iFileName;
      }
    }
    public void UpdateSave()
    {
      this.ChangeRev++;
      this.ChangeAt = DateTime.Now;
      this.ChangeBy = String.Format("{0}\\{1}", Environment.UserDomainName, Environment.UserName);
      this.ChangeOn = Environment.MachineName;
    }
  }
}
