using NTERacun.Classes.Export;
using System.Xml.Serialization;

namespace NTERacun.Classes
{
  public class Core
  {
    public Core()
    {

    }

    public void SaveExport(ExportItem iItem, string iFileName = "")
    {
      if (iItem != null)
      {
        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(iItem.GetType());
        string fFileXml = string.IsNullOrEmpty(iFileName) ? iItem.Name + ".xml" : iFileName;

        iItem.FileName = Path.GetFileName(fFileXml);

        using (FileStream fs = new FileStream(fFileXml, FileMode.Create))
        {
          x.Serialize(fs, iItem);
        }
      }
    }
    public bool LoadExport(string iFileName, out ExportItem oItem)
    {
      oItem = new ExportItem();

      using (FileStream fs = new FileStream(iFileName, FileMode.Open))
      {
        XmlSerializer _xSer = new XmlSerializer(typeof(ExportItem));

        var fObj = _xSer.Deserialize(fs);

        if (fObj != null)
        {
          oItem = (fObj as ExportItem);
          if (oItem != null)
          {
            oItem.FileName = Path.GetFileName(iFileName);

            return true;
          }
        }
      }

      return false;
    }
  }
}
