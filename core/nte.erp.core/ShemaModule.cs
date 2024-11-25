using nte.erp.core.Export;
using System.Data;
using System.Globalization;

namespace nte.erp.core
{
  public class ShemaModule : IDisposable
  {
    public string Body = string.Empty;
    public ShemaModule() { }
    public bool LoadData(DataSet iData, ExportShema iShema, out string oErrorText)
    {
      oErrorText = string.Empty;

      if (iData == null)
      {
        oErrorText = "Error: No Data!";
      }
      if (iShema == null)
      {
        oErrorText = "Error: No Shema!";
      }

      string fXmlMaster = string.Empty;
      if ((iShema != null) && (!string.IsNullOrEmpty(iShema.TemplateMain)))
      {
        fXmlMaster = iShema.TemplateMain;
      }
      else
      {
        oErrorText = $"Error: No Master Template!";
      }
      string fXmlItems = string.Empty;
      /*if (!string.IsNullOrEmpty(iShema.TemplateItems))
      {
        fXmlItems = iShema.TemplateItems;
      }
      else
      {
        oErrorText = $"Error: No Items Template!";
      }*/
      string fXmlTaxes = string.Empty;
      /*if (!string.IsNullOrEmpty(iShema.TemplateTaxes))
      {
        fXmlTaxes = string.Empty;// iShema.TemplateTaxes;
      }
      else
      {
        oErrorText = $"Error: No Texes Template!";
      }*/

      if (oErrorText == string.Empty)
      {
        // Utils.Write($"Converting...", true);
        try
        {
          if ((iData != null) && (iData.Tables.Contains("TableMaster")))
            foreach (DataRow fRow in iData.Tables["TableMaster"].Rows)
            {
              this.Body += this.GetConvert(fXmlMaster, fRow);
            }

          string fItems = "";
          foreach (DataRow fRow in iData.Tables["TableItems"].Rows)
          {
            fItems += this.GetConvert(fXmlItems, fRow);
          }

          string fTaxes = "";
          foreach (DataRow fRow in iData.Tables["TableTaxes"].Rows)
          {
            fTaxes += this.GetConvert(fXmlTaxes, fRow);
          }

          this.Body = this.Body.Replace("<cac:InvoiceLine/>", fItems.Trim());
          this.Body = this.Body.Replace("<cac:TaxSubtotal/>", fTaxes.Trim());

          this.Body = this.Body.Replace("{NowDate}", DateTime.Now.ToString("yyyy-MM-dd"));
          this.Body = this.Body.Replace("{NowTime}", DateTime.Now.ToString("HH:mm:ss"));

          // Utils.WriteLine("OK", true);

          /*if (Utils.XMLSave)
          {
            string fXmlFile = Utils.XMLSavingLocation.Trim();

            if (!fXmlFile.EndsWith("\\"))
            {
              fXmlFile += "\\";
            }

            fXmlFile = this.GetReplace(fXmlFile, "NowDate", DateTime.Now);

            if (fXmlFile.Contains("{ID}"))
            {
              fXmlFile = fXmlFile.Replace("{ID}", Utils.IDs);
            }
            else
            {
              fXmlFile += Utils.IDs + "-send.xml";
            }

            File.WriteAllText(fXmlFile, this.Body, Encoding.UTF8);
            // Utils.WriteLine($"Saved {fXmlFile}", true);
          }*/
        }
        catch (Exception ex)
        {
          oErrorText = ex.Message;
          // Utils.WriteLine($"ERROR: {oErrorText}", true);
        }
      }


      return (oErrorText == string.Empty);
    }
    public bool LoadData(DataSet iData, ExportItem iExport, out string oErrorText)
    {
      oErrorText = string.Empty;

      if (iData == null)
      {
        oErrorText = "Error: No Data!";
      }
      if (iExport == null)
      {
        oErrorText = "Error: No Shema!";
      }
      string fXmlMaster = string.Empty;

      if (oErrorText == string.Empty && iExport is not null && iData is not null)
      {
        // Utils.Write($"Converting...", true);
        try
        {
          this.Body = "";
          for (int i = 0; i < iExport.Maps.Count; i++)
          {
            if (i == 0)
            {
              fXmlMaster = iExport.Maps[0].Shema.TemplateMain;

              if (iData.Tables.Contains(iExport.Maps[i].TableName))
              {
                foreach (DataRow fRow in iData.Tables[iExport.Maps[i].TableName].Rows)
                {
                  this.Body = this.GetConvert(fXmlMaster, fRow);
                }
              }
            }
            else
            {
              if (!string.IsNullOrEmpty(iExport.Maps[i].ReplaceKey))
              {
                string fXmlInnerTemplate = iExport.Maps[i].Shema.TemplateMain;
                string fXmlInner = string.Empty;

                if (iData.Tables.Contains(iExport.Maps[i].TableName))
                {
                  foreach (DataRow fRow in iData.Tables[iExport.Maps[i].TableName].Rows)
                  {
                    fXmlInner += this.GetConvert(fXmlInnerTemplate, fRow);
                  }
                }

                this.Body = this.Body.Replace(iExport.Maps[i].ReplaceKey, fXmlInner);
              }
            }
          }
          this.Body = this.Body.Replace("{NowDate}", DateTime.Now.ToString("yyyy-MM-dd"));
          this.Body = this.Body.Replace("{NowTime}", DateTime.Now.ToString("HH:mm:ss"));

          // Utils.WriteLine("OK", true);

          /*if (Utils.XMLSave)
          {
            string fXmlFile = Utils.XMLSavingLocation.Trim();

            if (!fXmlFile.EndsWith("\\"))
            {
              fXmlFile += "\\";
            }

            fXmlFile = this.GetReplace(fXmlFile, "NowDate", DateTime.Now);

            if (fXmlFile.Contains("{ID}"))
            {
              fXmlFile = fXmlFile.Replace("{ID}", Utils.IDs);
            }
            else
            {
              fXmlFile += Utils.IDs + "-send.xml";
            }

            File.WriteAllText(fXmlFile, this.Body, Encoding.UTF8);
            // Utils.WriteLine($"Saved {fXmlFile}", true);
          }*/
        }
        catch (Exception ex)
        {
          oErrorText = ex.Message;
          // Utils.WriteLine($"ERROR: {oErrorText}", true);
        }
      }


      return (oErrorText == string.Empty);
    }
    private string GetReplace(string iText, string iColumnName, object iValue)
    {
      string fText = iText;
      string fRplc = "{" + iColumnName + "}";
      if (-1 < iText.IndexOf(fRplc))
      {
        fText = fText.Replace(fRplc, iValue.ToString());
      }

      return fText;
    }
    private string GetReplace(string iText, string iColumnName, string iValue)
    {
      string fText = iText;
      string fRplc = "{" + iColumnName + "}";
      if (-1 < iText.IndexOf(fRplc))
      {
        fText = fText.Replace(fRplc, iValue);
      }

      return fText;
    }
    private string GetReplace(string iText, string iColumnName, DateTime iValue)
    {
      string fText = iText;
      string fRplc = "{" + iColumnName + "}";
      if (-1 < iText.IndexOf(fRplc))
      {
        fText = fText.Replace(fRplc, iValue.ToString("yyyy-MM-dd"));
      }

      return fText;
    }
    private string GetConvert(string iTemplate, DataRow iRow)
    {
      string fTempate = iTemplate.ToString();

      try
      {
        foreach (DataColumn fColumn in iRow.Table.Columns)
        {
          if (iRow[fColumn.ColumnName] == DBNull.Value)
          {
            fTempate = this.GetReplace(fTempate, fColumn.ColumnName, String.Empty);
          }
          else
          {
            switch (fColumn.DataType.ToString())
            {
              case "System.Single":
              case "System.Int32":
                int fValueInt = Convert.ToInt32(iRow[fColumn.ColumnName]);
                fTempate = this.GetReplace(fTempate, fColumn.ColumnName, fValueInt.ToString(CultureInfo.InvariantCulture));
                break;
              case "System.Double":
              case "System.Decimal":
                decimal fValueMoney = Convert.ToDecimal(iRow[fColumn.ColumnName]);
                fTempate = this.GetReplace(fTempate, fColumn.ColumnName, fValueMoney.ToString("0.00", CultureInfo.InvariantCulture));
                break;
              case "System.DateTime":
                DateTime fValueDate = Convert.ToDateTime(iRow[fColumn.ColumnName]);
                fTempate = this.GetReplace(fTempate, fColumn.ColumnName, fValueDate);
                break;
              case "System.String":
                string fValueStr = Convert.ToString(iRow[fColumn.ColumnName]);
                fValueStr = fValueStr.Trim().Replace(Environment.NewLine, " ");
                fTempate = this.GetReplace(fTempate, fColumn.ColumnName, fValueStr);
                break;
              default:
                fTempate = this.GetReplace(fTempate, fColumn.ColumnName, iRow[fColumn.ColumnName]);
                break;
            }
          }
        }
      }
      catch (Exception ex)
      {
        // Utils.WriteLine("Error: " + ex.Message);
      }

      return fTempate;
    }
    public string GetString(string iValue)
    {
      if (string.IsNullOrEmpty(iValue))
      {
        return "";
      }
      else
      {
        return iValue.Replace(Environment.NewLine, " ").Trim();
      }
    }
    public string GetPercent(decimal? iValue)
    {
      return iValue.HasValue ? iValue.Value.ToString() : "";
    }
    public void Dispose()
    {

    }
  }
}
