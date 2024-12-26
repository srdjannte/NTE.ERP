using nte.erp.core.Export;
using nte.erp.services.invoices.Classes;
using System.Data;
using System.Runtime.Versioning;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]
  public partial class FormEditorTransformRefresh : Form
  {
    private ExportItem? Export = null;
    private ExportSourceMap Map;
    private DataTable TableFields = new DataTable();
    private ExportTestData TestData = new ExportTestData();
    private List<string> TemplateMainFields = new List<string>();
    public FormEditorTransformRefresh(ExportItem iExport, ExportSourceMap iMap)
    {
      InitializeComponent();
      this.ShemaFields.AutoGenerateColumns = false;
      this.Export = iExport;
      this.Map = iMap;
      this.CreateFields();
    }
    private void FormEditorTransformRefresh_Shown(object sender, EventArgs e)
    {
      this.CheckChanges();
    }
    private void CreateFields()
    {
      this.TableFields = new DataTable();
      this.TableFields.Columns.Add("ItemSave", typeof(bool));
      this.TableFields.Columns.Add("ItemAction");
      //this.TableFields.Columns.Add("ItemNode");
      this.TableFields.Columns.Add("Name");
      this.TableFields.Columns.Add("SourceName");
      this.TableFields.Columns.Add("ConvertTo");
      this.TableFields.Columns.Add("ConvertError");
      this.TableFields.Columns.Add("IfEmpty");
      this.TableFields.Columns.Add("DefaultValue");
      this.TableFields.Columns.Add("ItemMessage");
      this.TableFields.Columns.Add("ItemIndex");
    }
    public bool CheckChanges(bool iForce = false)
    {
      #region Load Data
      this.TestData = new ExportTestData();
      if (!iForce && this.Export is not null && Utils.LoadTestData(this.Export, out ExportTestData oTestData))
      {
        this.TestData = oTestData;
        this.ReloadSourceLabel.Text = "Have Test Data";
      }
      else
      {
        this.ReloadSourceLabel.Text = "No Test Data";
      }
      #endregion

      #region Apply Data
      this.TemplateMainFields = Utils.GetParams(this.Map.Shema.TemplateMain);
      List<string> fParams = new List<string>();
      int fIndex = 0;
      foreach (ExportShemaField fField in this.Map.Shema.Fields)
      {
        DataRow fRow = this.TableFields.NewRow();

        fRow["ItemSave"] = false;
        fRow["ItemAction"] = "Ignore";
        fRow["Name"] = fField.Name;
        fRow["SourceName"] = fField.Name;
        fRow["ConvertTo"] = fField.ConvertTo;
        fRow["ConvertError"] = fField.ConvertError;
        fRow["IfEmpty"] = fField.IfEmpty;
        fRow["DefaultValue"] = fField.DefaultValue;
        fRow["ItemMessage"] = string.Empty;
        fRow["ItemIndex"] = fIndex++;

        this.TableFields.Rows.Add(fRow);
      }
      foreach (string fStr in this.TemplateMainFields)
      {
        fParams.Add(fStr.Replace("{", ""));
      };

      foreach (string fValue in fParams)
      {
        if (!this.FindParam(fValue))
        {
          DataRow fRow = this.TableFields.NewRow();

          fRow["ItemSave"] = true;
          fRow["ItemAction"] = "Add";
          fRow["Name"] = fValue;
          fRow["SourceName"] = string.Empty;
          fRow["ConvertTo"] = "Implicit";
          fRow["ConvertError"] = "Stop";
          fRow["IfEmpty"] = "Ignore";
          fRow["DefaultValue"] = string.Empty;
          fRow["ItemMessage"] = string.Empty;

          this.TableFields.Rows.Add(fRow);
        }
      }

      List<string> fSources = new List<string>();
      foreach (DataRow fRow in this.TableFields.Rows)
      {
        if (!fSources.Contains(Utils.GetAsString(fRow, "SourceName")))
        {
          fSources.Add(Utils.GetAsString(fRow, "SourceName"));
        }
      }
      if (this.TestData is not null && this.TestData.Data is not null)
      {
        foreach (DataTable fTable in this.TestData.Data.Tables)
        {
          if (this.Map is not null && fTable.TableName == this.Map.Query)
          {
            foreach (DataColumn fCol in fTable.Columns)
            {
              if (!fSources.Contains(fCol.ColumnName))
              {
                fSources.Add(fCol.ColumnName);
              }
            }
          }
        }
      }
      /*foreach (DataTable fTable in this.TestData.Tables)
      {
        foreach (DataColumn fCol in fTable.Columns)
        {
          if (!fSources.Contains(fCol.ColumnName))
          {
            fSources.Add(fCol.ColumnName);
          }
        }
      }*/

      this.ColSourceName.Items.Clear();
      this.ColSourceName.Items.AddRange(fSources.ToArray());

      this.ShemaFields.DataSource = this.TableFields;
      #endregion

      return true;
    }
    private bool FindParam(string iValue)
    {
      string expression = String.Format("Name = '{0}'", iValue);

      DataRow[] foundRows = this.TableFields.Select(expression);

      return (0 < foundRows.Length);
    }
    private bool FindSource(string iValue)
    {
      string expression = String.Format("Name = '{0}' OR SourceName = '{0}'", iValue);

      DataRow[] foundRows = this.TableFields.Select(expression);

      return (0 < foundRows.Length);
    }
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.CheckAll)
      {
        for (int i = 0; i < this.TableFields.Rows.Count; i++)
        {
          this.TableFields.Rows[i]["ItemSave"] = true;
        }
      }
      if (sender == this.DeCheckAll)
      {
        for (int i = 0; i < this.TableFields.Rows.Count; i++)
        {
          this.TableFields.Rows[i]["ItemSave"] = false;
        }
      }
      if (sender == this.ReloadSource && this.Export is not null)
      {
        using (FormEditorSourceTest fForm = new FormEditorSourceTest(this.Export, true))
        {
          if (fForm.ShowDialog() == DialogResult.OK)
          {
            this.TestData = fForm.TestData;
            this.ReloadSourceLabel.Text = "Have Test Data";
          }
        }
      }
      if (sender == this.doCancel)
      {
        DialogResult = DialogResult.Cancel;
      }
      if (sender == this.doSave)
      {
        for (int i = 0; i < this.TableFields.Rows.Count; i++)
        {
          DataRow fRowTmp = this.TableFields.Rows[i];
          if (Convert.ToBoolean(fRowTmp["ItemSave"]))
          {
            DataRow fRow = this.Map.Shema.TableFields.NewRow();

            fRow["Name"] = fRowTmp["Name"];
            fRow["SourceName"] = fRowTmp["SourceName"];
            fRow["ConvertTo"] = fRowTmp["ConvertTo"];
            fRow["ConvertError"] = fRowTmp["ConvertError"];
            fRow["IfEmpty"] = fRowTmp["IfEmpty"];
            fRow["DefaultValue"] = fRowTmp["DefaultValue"];

            this.Map.Shema.TableFields.Rows.Add(fRow);
          }
        }

        DialogResult = DialogResult.OK;
      }
    }
  }
}