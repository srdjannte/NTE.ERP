using nte.erp.core.Export;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace nte.erp.core
{
  public enum SourceKind { Local, Cloud, OnPremise, MsSql, MySql, ODBC, File, WebService, Assembly };

  [Serializable]
  [XmlRoot("Source")]
  [Table("Source")]
  public class SourceModule : IDisposable
  {
    public string Name = string.Empty;
    public SourceKind Kind = SourceKind.Local;
    public string TestFileName = string.Empty;
    public int Timeout = 15;
    public string ConnectionStr = string.Empty;
    public string ListQuery = string.Empty;
    public string MainQuery = string.Empty;
    public string TestID = string.Empty;

    public string ConnectionString = string.Empty;
    [XmlIgnore]
    public DataSet DataSet = new DataSet();
    public SourceModule()
    {
    }
    public DataTable GetTable(string iID, string iSql, string iTableName, SqlConnection iConnection)
    {
      string fSql = iSql.Replace("{ID}", iID);
      SqlCommand cmd = iConnection.CreateCommand();
      cmd.CommandTimeout = 10;
      cmd.CommandText = fSql;

      SqlDataAdapter sda = new SqlDataAdapter(cmd);
      DataTable dt = new DataTable(iTableName);
      sda.Fill(dt);

      return dt.Copy();
    }
    public DataSet GetTables(string iID, string iSql, SqlConnection iConnection)
    {
      string fSql = iSql.Replace("{ID}", iID);
      SqlCommand cmd = iConnection.CreateCommand();
      cmd.CommandTimeout = 10;
      cmd.CommandText = fSql;

      SqlDataAdapter sda = new SqlDataAdapter(cmd);
      DataSet dt = new DataSet("TempDataSet");
      sda.Fill(dt);

      return dt;
    }
    public SqlConnection GetConnection(string iConnectionString)
    {
      return new SqlConnection(iConnectionString);
    }
    public bool LoadData(string iID, string iConnectionString, string iMain, out string oErrorText)
    {
      oErrorText = String.Empty;

      try
      {
        this.ConnectionString = iConnectionString;
        this.DataSet = new DataSet();
        using (SqlConnection fConnection = new SqlConnection(this.ConnectionString))
        {
          fConnection.Open();
          this.DataSet.Tables.Add(GetTable(iID, iMain, "TableMaster", fConnection));
          /*this.DataSet.Tables.Add(GetTable(iID, iItems, "TableItems", fConnection));
          this.DataSet.Tables.Add(GetTable(iID, iTaxes, "TableTaxes", fConnection));*/
          fConnection.Close();
        }
      }
      catch (Exception ex)
      {
        oErrorText = ex.Message;
      }

      return (oErrorText == string.Empty);
    }
    public bool LoadData(string iID, ExportItem iExport, out string oErrorText)
    {
      oErrorText = String.Empty;
      // Utils.WriteLine(string.Format("Starting {0}[{1}]...", iExport.Source.Name, iExport.Source.Kind), true);
      try
      {
        switch (iExport.Source.Kind)
        {
          case ExportSourceKind.Test:
            this.DataSet = new DataSet();
            // Utils.WriteLine(string.Format("Loading [{0}]...", iExport.Source.TestFileName), true);
            this.DataSet.ReadXml(iExport.Source.TestFileName);
            // Utils.WriteLine(string.Format("Loaded [{0}]", iExport.Source.TestFileName), true);
            break;
          case ExportSourceKind.MsSql:
            this.ConnectionString = iExport.Source.ConnectionStr;
            this.DataSet = new DataSet();
            // Utils.WriteLine("Connecting...", true);
            using (SqlConnection fConnection = new SqlConnection(this.ConnectionString))
            {
              fConnection.Open();
              // Utils.WriteLine("Connected", true);
              // Utils.WriteLine(string.Format("Querying Master[{0}]...", iExport.Source.MainQuery), true);
              foreach (DataTable fTableMain in this.GetTables(iID, iExport.Source.MainQuery, fConnection).Tables)
              {
                // Utils.WriteLine("Connection Closing...", true);
                this.DataSet.Tables.Add(fTableMain.Copy());
              }
              foreach (ExportSourceMap fMap in iExport.Maps)
              {
                if (!fMap.Query.StartsWith("Table"))
                {
                  // Utils.WriteLine(string.Format("Querying {0}[{1}]...", fMap.Name, fMap.Query), true);
                  this.DataSet.Tables.Add(this.GetTable(iID, fMap.Query, fMap.Name, fConnection));
                }
              }

              // Utils.WriteLine("Connection Closing...", true);
              fConnection.Close();
              // Utils.WriteLine("Connection Closed", true);
            }
            break;
        }
      }
      catch (Exception ex)
      {
        oErrorText = ex.Message;
        // Utils.WriteLine(ex, true);
      }

      return (oErrorText == string.Empty);
    }
    public void Update(string iName, string iKind, string iTestFileName, string iTimeout, string iConnectionStr, string iListQuery, string iMainQuery)
    {
      this.Name = iName;
      this.ConnectionStr = iConnectionStr;
      this.TestFileName = iTestFileName;
      this.ListQuery = iListQuery;
      this.MainQuery = iMainQuery;
      if (int.TryParse(iTimeout, out int oTimeout))
      {
        this.Timeout = oTimeout;
      }
      if (Enum.TryParse(iKind, out SourceKind fKind))
      {
        this.Kind = fKind;
      }
    }
    public string AsXML()
    {
      XmlSerializer x = new XmlSerializer(this.GetType());

      using (StringWriter textWriter = new StringWriter())
      {
        x.Serialize(textWriter, this);
        return textWriter.ToString();
      }
    }
    public void Dispose()
    {

    }
  }
}