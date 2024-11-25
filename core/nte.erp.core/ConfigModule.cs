using nte.erp.core.Export;
using System.Xml.Serialization;

namespace nte.erp.core
{
  [Serializable]
  [XmlRoot("Config")]
  public class ConfigModule
  {
    private string FileExe = string.Empty;
    public bool IsDebug = false;
    public bool IsSilente = false;
    public List<ExportSource> Sources = new List<ExportSource>();
    public List<ExportSend> Sends = new List<ExportSend>();
    public List<string> Recent = new List<string>();
    public ConfigModule()
    {
    }
    public void SetFileName(string iFileExe)
    {
      this.FileExe = iFileExe;
    }
    [XmlIgnore]
    public string FileName
    {
      get
      {
        if(!string.IsNullOrEmpty(this.FileExe))
        {
          string fFileName = this.FileExe.Replace(".exe", ".config");
          if (!fFileName.EndsWith(".config"))
          {
            fFileName += ".config";
          }
          return fFileName;
        }

        return "default.config";
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
  }
}
