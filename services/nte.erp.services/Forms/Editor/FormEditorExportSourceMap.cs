using nte.erp.core.Export;
using System.Data;
using System.Runtime.Versioning;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]
  public partial class FormEditorExportSourceMap : Form
  {
    public ExportSourceMap Map = new ExportSourceMap();
    private DataSet? TestData;
    public FormEditorExportSourceMap(DataSet? iTestData = null)
    {
      InitializeComponent();
      this.TestData = iTestData;
      this.Action_Refresh();
    }
    public FormEditorExportSourceMap(ExportSourceMap iMap, DataSet? iTestData = null)
    {
      InitializeComponent();
      this.Map = iMap;
      this.TestData = iTestData;
      this.Action_Refresh();
    }
    private void Action_Refresh()
    {
      this.MapName.Text = this.Map.Name;
      this.MapFilter.Text = this.Map.Filter;
      this.MapReplaceKey.Text = this.Map.ReplaceKey;
      if (this.TestData is not null)
      {
        this.MapKind.Items.Clear();
        this.MapKind.Items.Add("Query");
        if (0 < this.TestData.Tables.Count)
        {
          foreach (DataTable fTable in this.TestData.Tables)
          {
            this.MapKind.Items.Add(fTable.TableName);
          }
        }
        else
        {
          this.MapKind.Items.Add("Table");
          this.MapKind.Items.Add("Table1");
        }
      }
      if (this.Map.Query.StartsWith("Table"))
      {
        this.MapKind.Text = this.Map.Query;
      }
      else
      {
        this.MapKind.Text = "Query";
        this.MapQuery.Text = this.Map.Query;
      }
      this.MapName.Enabled = (this.Map.Name != "Master");
      this.MapReplaceKeyLabel.Visible = (this.Map.Name != "Master");
      this.MapReplaceKey.Visible = (this.Map.Name != "Master");
    }
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doSave)
      {
        if (string.IsNullOrEmpty(this.MapName.Text.Trim()))
        {
          MessageBox.Show("Name is mandatory!", "Validaton Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.MapName.Focus();
          return;
        }
        if ((this.MapKind.Text == "Query") && (string.IsNullOrEmpty(this.MapQuery.Text.Trim())))
        {
          MessageBox.Show("Query is mandatory!", "Validaton Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.MapName.Focus();
          return;
        }
        this.Map.Name = this.MapName.Text;
        this.Map.Query = (this.MapKind.Text == "Query") ? this.MapQuery.Text : this.MapKind.Text;
        this.Map.Filter = this.MapFilter.Text;
        this.Map.ReplaceKey = this.MapReplaceKey.Text;
        this.DialogResult = DialogResult.OK;
      }
      if (sender == this.doCancel)
      {
        this.DialogResult = DialogResult.Cancel;
      }
      if (sender == this.MapKind)
      {
        this.MapQuery.Visible = (this.MapKind.Text == "Query");
        this.MapQueryLabel.Visible = this.MapQuery.Visible;
      }
    }
  }
}
