using nte.erp.client.Common;
using nte.erp.core;
using nte.erp.core.Export;
using nte.erp.core.Import;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace nte.erp.client
{
  public static class Utils
  {
    public static bool IsDebug = false;
    public static bool IsSilente = false;
    public static StylesItem Styles = new StylesItem();
    public static BackgroundWorker? ReportWorker = null;
    public static ConfigModule Config = new ConfigModule();
    public static DataModule Data = null;
    public static List<ConfigModule> Configs = new List<ConfigModule>();
    public static Language Language = null;

    public class MsgItem
    {
      public DateTime CreateAt = DateTime.Now;
      public string CreatedBy;
      public string Message;
      public bool Debug = false;
      public MsgItem(string iMessage, bool iDebug = false)
      {
        CreateAt = DateTime.Now;
        CreatedBy = "";
        Message = iMessage;
        Debug = iDebug;
      }
    }
    public static List<MsgItem> Msgs = new List<MsgItem>();

    #region Logs
    public static void Write(string iText, bool iDebug = false)
    {
      try
      {
        if (iDebug && IsDebug)
        {
          Msgs.Add(new MsgItem(iText, iDebug));
          Console.WriteLine(iText);
        }
        else
        {
          if (!iDebug)
          {
            Msgs.Add(new MsgItem(iText, iDebug));
            Console.Write(iText);
          }
        }

        if (ReportWorker is not null)
        {
          if (ReportWorker.WorkerReportsProgress)
          {
            ReportWorker.ReportProgress(0, iText);
          }
        }
      }
      catch (Exception ex)
      {
        string oErrorText = ex.Message;
      }
    }
    public static void WriteLine(string iText, bool iDebug = false)
    {
      try
      {
        if (iDebug && IsDebug)
        {
          Msgs.Add(new MsgItem(iText, iDebug));
          Console.WriteLine(iText);
        }
        else
        {
          if (!iDebug)
          {
            Msgs.Add(new MsgItem(iText, iDebug));
            Console.WriteLine(iText);
          }
        }

        if (ReportWorker is not null)
        {
          if (ReportWorker.WorkerReportsProgress)
          {
            ReportWorker.ReportProgress(0, iText);
          }
        }
      }
      catch (Exception ex)
      {
        string oErrorText = ex.Message;
      }
    }
    public static void WriteLine(Exception iException, bool iDebug = false)
    {
      try
      {
        Msgs.Add(new MsgItem(iException.Message, iDebug));
        Console.WriteLine(iException.Message);

        if (ReportWorker is not null)
        {
          if (ReportWorker.WorkerReportsProgress)
          {
            ReportWorker.ReportProgress(0, iException.Message);
          }
        }
      }
      catch (Exception ex)
      {
        string oErrorText = ex.Message;
      }
    }
    public static void WaitKey(string iError = "")
    {

      if (IsSilente)
      {
        if (IsDebug && string.IsNullOrEmpty(iError))
        {
          Console.WriteLine("\nPress any key to exit...");
          Console.ReadKey();
        }
        if (!string.IsNullOrEmpty(iError))
        {
          Console.WriteLine(iError);
          Console.WriteLine("\nPress any key to exit...");
          Console.ReadKey();
        }
      }
      else
      {
        if (!string.IsNullOrEmpty(iError))
        {
          Console.WriteLine(iError);
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
      }
    }
    #endregion

    #region Load & Save
    public static bool LoadConfig()
    {
      Utils.Language = new Language();
      if (File.Exists(Config.FileName))
      {
        using (FileStream fs = new FileStream(Config.FileName, FileMode.Open))
        {
          XmlSerializer _xSer = new XmlSerializer(typeof(ConfigModule));

          var fObj = _xSer.Deserialize(fs);

          if (fObj is not null && fObj is ConfigModule)
          {
            Config = fObj as ConfigModule;
            //Config.SetFileName(Application.ExecutablePath);

            return true;
          }
        }
      }

      return false;
    }
    public static bool LoadTestData(ExportItem iExport, out DataSet oTestData)
    {
      oTestData = new DataSet();
      if (iExport is not null)
      {
        string fFileTestXml = Path.GetTempPath();
        fFileTestXml += !string.IsNullOrEmpty(iExport.Source.TestID) ? "nteracun-export-test-" + iExport.Source.TestID + ".xml" : "nteracun-export-test.xml";
        if (File.Exists(fFileTestXml))
        {
          oTestData.ReadXml(fFileTestXml);
          return true;
        }
      }

      return false;
    }
    public static bool LoadTestData(ExportItem iExport, out ExportTestData oTestData)
    {
      oTestData = new ExportTestData();
      if (iExport is not null)
      {
        if (!string.IsNullOrEmpty(iExport.Source.TestID))
        {
          string fFileTestIDXml = Path.GetTempPath() + "nteracun-export-test-" + iExport.Source.TestID + ".xml";
          if (File.Exists(fFileTestIDXml))
          {
            oTestData.ReadXml(fFileTestIDXml);
            return true;
          }
        }

        string fFileTestXml = "nteracun-export-test.xml";
        if (File.Exists(fFileTestXml))
        {
          if (oTestData.Data is not null)
          {
            oTestData.Data.ReadXml(fFileTestXml);
            return true;
          }
        }
      }

      return false;
    }
    public static bool SaveTestData(ExportItem iExport, ExportTestData iTestData)
    {
      if (iExport is not null && iTestData is not null)
      {
        string fFileTestIdXml = Path.GetTempPath() + "nteracun-export-test" + (string.IsNullOrEmpty(iExport.Source.TestID) ? "" : "-" + iExport.Source.TestID) + ".xml";
        iTestData.WriteXml(fFileTestIdXml);
        string fFileTestXml = Path.GetTempPath() + "nteracun-export-test.xml";
        if (iTestData.Data is not null)
        {
          iTestData.Data.WriteXml(fFileTestXml);
        }

        return true;
      }

      return false;
    }
    public static void SaveExport(ExportItem iItem, string iFileName = "")
    {
      if (iItem != null)
      {
        XmlSerializer x = new XmlSerializer(iItem.GetType());
        string fFileXml = string.IsNullOrEmpty(iFileName) ? iItem.Name + ".xml" : iFileName;

        iItem.FileName = Path.GetFileName(fFileXml);

        using (FileStream fs = new FileStream(fFileXml, FileMode.Create))
        {
          x.Serialize(fs, iItem);
        }
      }
    }
    public static bool LoadExport(string iFileName, out ExportItem oItem)
    {
      oItem = new ExportItem();

      using (FileStream fs = new FileStream(iFileName, FileMode.Open))
      {
        XmlSerializer _xSer = new XmlSerializer(typeof(ExportItem));

        var fObj = _xSer.Deserialize(fs);

        if (fObj is not null && fObj is ExportItem)
        {
          oItem = fObj as ExportItem ?? new ExportItem();
          if (oItem != null)
          {
            oItem.FileName = Path.GetFileName(iFileName);

            return true;
          }
        }
      }

      return false;
    }
    public static bool LoadFile(string iFileName, out ExportItem oExport, out ImportItem oImport)
    {
      oExport = null;
      oImport = null;

      string fFileText = File.ReadAllText(iFileName, Encoding.UTF8);
      if (fFileText.StartsWith("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ExportItem ", StringComparison.OrdinalIgnoreCase))
      {
        LoadExport(iFileName, out oExport);

        return true;
      }
      if (fFileText.StartsWith("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ImportItem ", StringComparison.OrdinalIgnoreCase))
      {
        LoadExport(iFileName, out oExport);

        return true;
      }

      return false;
    }
    #endregion

    #region Miscellaneous
    public static string NewGuid
    {
      get
      {
        return Guid.NewGuid().ToString();
      }
    }
    public static string GetAsString(DataRow iRow, string iColumnName, string iDefault = "")
    {
      if (iRow != null)
      {
        if (iRow.Table.Columns.Contains(iColumnName))
        {
          var fRow = iRow[iColumnName];
          if (fRow != null && Convert.ToString(fRow) != null)
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
    public static void SetException(Exception ex)
    {
      //ToDo
    }
    public static bool GetAsBoolean(DataRow iRow, string iColumnName, bool iDefault = false)
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
    public static List<string> GetParams(string iText, string iKind = "{")
    {
      string fRegExParam = @"\{\w+";
      List<string> fParams = Regex.Matches(iText, fRegExParam).Cast<Match>().Select(m => m.Value).ToList();
      List<string> fParamsFinal = new List<string>();
      foreach (string fStr in fParams)
      {
        fParamsFinal.Add(fStr.Replace("{", ""));
      };

      return fParamsFinal;
    }
    public static DataTable GetTableFromString(String iData)
    {
      DataSet fDS = new DataSet();
      fDS.ReadXml(XmlReader.Create(new StringReader(String.Format("<dataset>{0}</dataset>", iData))));
      if (fDS != null && 0 < fDS.Tables.Count)
      {
        return fDS.Tables[0];
      }

      return null;
    }

    public static DataTable GetTableFromString(String iData, String iTableName)
    {
      if (!String.IsNullOrEmpty(iData))
      {
        DataSet fDS = new DataSet();
        fDS.ReadXml(XmlReader.Create(new StringReader(iData)));
        if (fDS != null && 0 < fDS.Tables.Count)
        {
          return fDS.Tables[iTableName];
        }
      }

      return null;
    }

    public static DataTable GetTableFromString(String iData, int iTableIndex)
    {
      DataSet fDS = new DataSet();
      fDS.ReadXml(XmlReader.Create(new StringReader(iData)));
      if (fDS != null && iTableIndex < fDS.Tables.Count)
      {
        return fDS.Tables[iTableIndex];
      }

      return null;
    }
    public static String GetStringFromTable(DataTable iTable)
    {
      if (iTable != null)
      {
        DataSet fDS = new DataSet();
        //fDS.DataSetName = "DataSet";
        fDS.Tables.Add(iTable.Copy());
        StringWriter sw = new StringWriter();
        fDS.WriteXml(sw);

        return sw.ToString();
      }

      return String.Empty;
    }
    #endregion
  }
}