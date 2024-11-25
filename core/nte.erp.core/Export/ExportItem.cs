using System.Xml.Serialization;

namespace nte.erp.core.Export
{
  public class ExportItem
  {
    public string Name = string.Empty;
    public string Description = string.Empty;

    public ExportSource Source = new ExportSource();
    public List<ExportSourceMap> Maps = new List<ExportSourceMap>();
    public ExportSend Send = new ExportSend();

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
    public ExportItem()
    {

    }
    public ExportItem(string iName)
    {
      this.Name = iName;
      this.Source = new ExportSource();
      //this.Shema = new ExportShema();
      ExportSourceMap fMapMaster = new ExportSourceMap();
      fMapMaster.Name = "Master";
      fMapMaster.Query = "Table";
      this.Maps.Add(fMapMaster);
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
      this.SaveAt = DateTime.Now;
    }
  }
}