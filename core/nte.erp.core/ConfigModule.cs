using nte.erp.core.Export;
using System.Xml.Serialization;

namespace nte.erp.core
{
  [Serializable]
  [XmlRoot("Config")]
  public class ConfigModule
  {
    private string ConfigFileIn = string.Empty;
    public bool IsDebug = false;
    public bool IsSilente = false;
    public bool OnPremiseForce = false;
    public string OnPremiseURL = string.Empty;
    public string ClaudURL = "htttp://localhost/api.asmx";
    public OwnerItem Owner = new OwnerItem();
    public List<OwnerItem> Owners = new List<OwnerItem>();
    public List<ExportSource> Sources = new List<ExportSource>();
    public List<ExportSend> Sends = new List<ExportSend>();
    public List<string> Recent = new List<string>();
    public ConfigModule()
    {
    }
    public void SetFileName(string iFileExe)
    {
      this.ConfigFileIn = iFileExe;
    }
    [XmlIgnore]
    public string FileName
    {
      get
      {
        if (!string.IsNullOrEmpty(this.ConfigFileIn))
        {
          string fFileName = this.ConfigFileIn.Replace(".exe", ".config");
          if (!fFileName.EndsWith(".config"))
          {
            fFileName += ".config";
          }
          return fFileName;
        }

        string fPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NTE ERP\\";
        if (!Directory.Exists(fPath))
        {
          Directory.CreateDirectory(fPath);
        }
        
        return fPath + "erp.config";
      }
    }
    public void Save()
    {
      XmlSerializer x = new XmlSerializer(this.GetType());
      using (FileStream fs = new FileStream(this.FileName, FileMode.Create))
      {
        x.Serialize(fs, this);
      }
    }
    public void SetRecent(string iFileName)
    {
      if (this.Recent.Contains(iFileName))
      {
        this.Recent.Remove(iFileName);
      }
      this.Recent.Insert(0, iFileName);

      this.Save();
    }
    public bool OwnerExsists(OwnerItem iOwner)
    {
      foreach (OwnerItem fOwner in this.Owners)
      {
        if (fOwner.Uid == iOwner.Uid)
        {
          return true;
        }
      }

      return false;
    }
  }
}
