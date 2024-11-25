using System.Data;
using System.Xml.Serialization;

namespace nte.erp.core.Export
{
  public enum ExportShemaProccessor { All, Dynamic, Fields, DynamicFields }
  public class ExportShema
  {
    public string Name = string.Empty;
    public ExportShemaProccessor Proccessor = ExportShemaProccessor.All;
    public List<ExportShemaField> Fields = new List<ExportShemaField>();
    //public ExportShema Validation = new ExportShema();
    public string TemplateMain = string.Empty;
    public string SourceMap = string.Empty;
    [XmlIgnore]
    public DataTable TableFields = new DataTable();
    public ExportShema()
    {
      this.TableFields = new DataTable();

      this.TableFields.Columns.Add("Name");
      this.TableFields.Columns.Add("SourceName");
      this.TableFields.Columns.Add("ConvertTo");
      this.TableFields.Columns.Add("ConvertError");
      this.TableFields.Columns.Add("IfEmptyThenNone", typeof(bool));
    }
    public void TableLoad()
    {
      this.TableFields = new DataTable();

      this.TableFields.Columns.Add("Name");
      this.TableFields.Columns.Add("SourceName");
      this.TableFields.Columns.Add("ConvertTo");
      this.TableFields.Columns.Add("ConvertError");
      this.TableFields.Columns.Add("IfEmpty");
      this.TableFields.Columns.Add("DefaultValue");

      foreach (ExportShemaField fField in this.Fields)
      {
        DataRow fRow = this.TableFields.NewRow();

        fRow["Name"] = fField.Name;
        fRow["SourceName"] = fField.SourceName;
        fRow["ConvertTo"] = fField.ConvertTo;
        fRow["ConvertError"] = fField.ConvertError;
        fRow["IfEmpty"] = fField.IfEmpty;
        fRow["DefaultValue"] = fField.DefaultValue;

        this.TableFields.Rows.Add(fRow);
      }
    }
    public void UpdateFields()
    {
      this.Fields.Clear();
      foreach (DataRow fRow in this.TableFields.Rows)
      {
        ExportShemaField fField = new ExportShemaField();

        fField.Name = this.GetAsString(fRow, "Name");
        fField.SourceName = this.GetAsString(fRow, "SourceName");
        if (Enum.TryParse(this.GetAsString(fRow, "ConvertTo"), out ConvertToTypes oConvertTo))
        {
          fField.ConvertTo = oConvertTo;
        }
        else
        {
          fField.ConvertTo = ConvertToTypes.Implicit;
        }
        if (Enum.TryParse(this.GetAsString(fRow, "ConvertError"), out ConvertErrorTypes oConvertError))
        {
          fField.ConvertError = oConvertError;
        }
        else
        {
          fField.ConvertError = ConvertErrorTypes.Stop;
        }
        fField.IfEmpty = ConvertIfEmpty.Ignore;
        if (Enum.TryParse(this.GetAsString(fRow, "IfEmpty"), out ConvertIfEmpty fIfEmpty))
        {
          fField.IfEmpty = fIfEmpty;
        }
        fField.DefaultValue = this.GetAsString(fRow, "DefaultValue");

        this.Fields.Add(fField);
      }
    }
    public void Update(string iName, string iProccessor, string iTemplateMain)
    {
      this.Name = iName;
      if (Enum.TryParse(iProccessor, out ExportShemaProccessor oProccessor))
      {
        this.Proccessor = oProccessor;
      }
      this.TemplateMain = iTemplateMain;
    }
    public ExportShemaProccessor GetProccessor(string? iValue)
    {
      if (iValue is not null && Enum.TryParse(iValue, out ExportShemaProccessor oProccessor))
      {
        return oProccessor;
      }

      return ExportShemaProccessor.All;
    }

    private string GetAsString(DataRow iRow, string iColumnName, string iDefault = "")
    {
      if (iRow != null)
      {
        if (iRow.Table.Columns.Contains(iColumnName))
        {
          var fRow = iRow[iColumnName];
          if ((fRow != null) && (Convert.ToString(fRow) != null))
          {
            string fResult = Convert.ToString(fRow);
            if (!string.IsNullOrEmpty(fResult))
            {
              return fResult;
            }
          }
        }
      }

      return iDefault;
    }
    private bool GetAsBoolean(DataRow iRow, string iColumnName, bool iDefault = false)
    {
      if (iRow != null)
      {
        if (iRow.Table.Columns.Contains(iColumnName))
        {
          if (string.IsNullOrEmpty(Convert.ToString(iRow[iColumnName])))
          {
            return iDefault;
          }
          else
          {
            return Convert.ToBoolean(iRow[iColumnName]);
          }
        }
      }

      return iDefault;
    }
  }
}
