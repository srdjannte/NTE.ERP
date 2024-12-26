using System.Data;
using System.Xml.Serialization;

namespace nte.erp.core.Export
{
  [Serializable]
  [XmlRoot("TestData")]
  public class ExportTestData
  {
    public string DataStr = "";
    public string FieldsStr = "";
    [XmlIgnore]
    public DataSet? Data = null;
    [XmlIgnore]
    public DataTable? Fields = null;
    [XmlIgnore]
    public bool HasData
    {
      get
      {
        return (this.Data is not null);
      }
    }
    [XmlIgnore]
    public bool HasFields
    {
      get
      {
        return (this.Fields is not null);
      }
    }
    public void ReadXml(string iFileName)
    {
      using (FileStream fs = new FileStream(iFileName, FileMode.Open))
      {
        XmlSerializer _xSer = new XmlSerializer(typeof(ExportTestData));

        var fObj = _xSer.Deserialize(fs);

        if ((fObj is not null) && (fObj is ExportTestData))
        {
          ExportTestData fItem = (fObj as ExportTestData);
          if (fItem != null)
          {
            this.DataStr = fItem.DataStr;
            this.FieldsStr = fItem.FieldsStr;

            this.Data = new DataSet();
            if (!string.IsNullOrEmpty(this.DataStr))
            {
              using (var reader = new StringReader(this.DataStr))
              {
                this.Data.ReadXml(reader);
              }
            }
          }
        }
      }
    }
    public void WriteXml(string iFileName)
    {
      this.DataStr = (this.Data is not null) ? this.Data.GetXml() : "";
      //this.FieldsStr = this.Fields.GetXml();
      XmlSerializer x = new XmlSerializer(this.GetType());
      using (FileStream fs = new FileStream(iFileName, FileMode.Create))
      {
        x.Serialize(fs, this);
      }
    }
  }
}
