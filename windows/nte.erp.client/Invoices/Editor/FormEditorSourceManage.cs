using nte.erp.core.Export;
using System.Data;
using Utils = nte.erp.client.Utils;

namespace nte.erp.services.invoices
{
  public partial class FormEditorSourceManage : Form
  {
    public ExportSource Source = new ExportSource();
    private DataTable ListTable = new DataTable();
    private int SourceIndex = -1;
    public FormEditorSourceManage(ExportSource iSource)
    {
      InitializeComponent();
      this.Source = iSource;
      this.LoadList();
    }
    private void LoadList()
    {
      this.ListTable = new DataTable();
      this.ListTable.Columns.Add("Name");
      this.ListTable.Columns.Add("Kind");
      this.ListTable.Columns.Add("Action");
      this.ListTable.Columns.Add("Message");
      this.ListTable.Columns.Add("Index", typeof(int));

      bool fFound = false;
      bool fFoundChanged = true;

      for (int i = 0; i < Utils.Config.Sources.Count; i++)
      {
        DataRow fRow = this.ListTable.NewRow();

        fRow["Name"] = Utils.Config.Sources[i].Name;
        fRow["Kind"] = Utils.Config.Sources[i].Kind.ToString();
        fRow["Action"] = "Remove";
        fRow["Message"] = string.Empty;
        fRow["Index"] = i;

        if (Utils.Config.Sources[i].Name == this.Source.Name)
        {
          fFound = true;
          this.SourceIndex = i;
          switch (this.Source.Kind)
          {
            case ExportSourceKind.Test:
              if (Utils.Config.Sources[i].TestFileName != this.Source.TestFileName)
              {
                fRow["Action"] = "Update";
              }
              break;
            case ExportSourceKind.MsSql:
              if (
                Utils.Config.Sources[i].ConnectionStr != this.Source.ConnectionStr ||
                Utils.Config.Sources[i].ListQuery != this.Source.ListQuery ||
                Utils.Config.Sources[i].MainQuery != this.Source.MainQuery
                )
              {
                fRow["Action"] = "Update";
              }
              break;
            case ExportSourceKind.MySql:
              break;
            case ExportSourceKind.ODBC:
              break;
            case ExportSourceKind.Assembly:
              break;
            case ExportSourceKind.File:
              break;
          }
        }

        this.ListTable.Rows.Add(fRow);
      }

      if (!fFound && !string.IsNullOrEmpty(this.Source.Name))
      {
        DataRow fRow = this.ListTable.NewRow();

        fRow["Name"] = this.Source.Name;
        fRow["Kind"] = this.Source.Kind.ToString();
        fRow["Action"] = "Add";
        fRow["Message"] = string.Empty;
        fRow["Index"] = this.ListTable.Rows.Count;

        this.ListTable.Rows.Add(fRow);
      }

      this.ListView.AutoGenerateColumns = false;
      this.ListView.DataSource = this.ListTable;
    }
    private int SelectedIndex
    {
      get
      {
        if (0 < this.ListView.SelectedCells.Count)
        {
          DataRowView fRow = (this.ListView.Rows[this.ListView.SelectedCells[0].RowIndex].DataBoundItem as DataRowView);
          return Convert.ToInt32(fRow.Row["Index"]);
        }

        return -1;
      }
    }
    private DataRow SelectedRow
    {
      get
      {
        if (0 < this.ListView.SelectedCells.Count)
        {
          DataRowView fRow = (this.ListView.Rows[this.ListView.SelectedCells[0].RowIndex].DataBoundItem as DataRowView);
          return fRow.Row;
        }

        return null;
      }
    }
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doCancel)
      {
        this.DialogResult = DialogResult.Cancel;
      }
      if (sender == this.doSave)
      {
        if (-1 < this.SelectedIndex && this.SelectedIndex < Utils.Config.Sources.Count)
        {
          int i = this.SelectedIndex;
          this.Source.Name = Utils.Config.Sources[i].Name;
          this.Source.Kind = Utils.Config.Sources[i].Kind;
          switch (this.Source.Kind)
          {
            case ExportSourceKind.Test:
              this.Source.TestFileName = Utils.Config.Sources[i].TestFileName;
              break;
            case ExportSourceKind.MsSql:
              this.Source.ConnectionStr = Utils.Config.Sources[i].ConnectionStr;
              this.Source.ListQuery = Utils.Config.Sources[i].ListQuery;
              this.Source.MainQuery = Utils.Config.Sources[i].MainQuery;
              break;
            case ExportSourceKind.MySql:
              break;
            case ExportSourceKind.ODBC:
              break;
            case ExportSourceKind.Assembly:
              break;
            case ExportSourceKind.File:
              break;
          }

          this.DialogResult = DialogResult.OK;
        }
        else
        {
          this.ListView.Focus();
        }
      }
    }
    private void ListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex != 2)
      {
        return;
      }
      string fName = ListView.Rows[e.RowIndex].Cells["ColName"].Value.ToString();
      string fAction = ListView.Rows[e.RowIndex].Cells["ColAction"].Value.ToString();
      DataRowView fRow = (ListView.Rows[e.RowIndex].DataBoundItem as DataRowView);
      int fIndex = Convert.ToInt32(fRow.Row["Index"]);
      //int fIndex = Convert.ToInt32(fRow.Row["Action"]);

      switch (fAction)
      {
        case "Apply":
          //this.DialogResult = DialogResult.OK;
          break;
        case "Add":
          Utils.Config.Sources.Add(this.Source);
          Utils.Config.Save();
          this.ListTable.Rows[fIndex]["Action"] = "Remove";
          break;
        case "Update":
          for (int i = 0; i < Utils.Config.Sources.Count; i++)
          {
            if (Utils.Config.Sources[i].Name == this.Source.Name)
            {
              Utils.Config.Sources[i].Kind = this.Source.Kind;
              switch (this.Source.Kind)
              {
                case ExportSourceKind.Test:
                  Utils.Config.Sources[i].TestFileName = this.Source.TestFileName;
                  break;
                case ExportSourceKind.MsSql:
                  Utils.Config.Sources[i].ConnectionStr = this.Source.ConnectionStr;
                  Utils.Config.Sources[i].ListQuery = this.Source.ListQuery;
                  Utils.Config.Sources[i].MainQuery = this.Source.MainQuery;
                  break;
                case ExportSourceKind.MySql:
                  break;
                case ExportSourceKind.ODBC:
                  break;
                case ExportSourceKind.Assembly:
                  break;
                case ExportSourceKind.File:
                  break;
              }
              this.ListTable.Rows[fIndex]["Action"] = "Remove";
              break;
            }
          }
          break;
        case "Remove":
          Utils.Config.Sources.RemoveAt(fIndex);
          this.ListTable.Rows.RemoveAt(fIndex);
          break;
      }
    }

    private void ListView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.Action_Click(this.doSave, null);
    }

    private void ListView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      if (-1 < this.SourceIndex && this.SourceIndex < this.ListView.Rows.Count)
      {
        this.ListView.Rows[this.SourceIndex].DefaultCellStyle.BackColor = Color.LightGray;
      }
    }
  }
}
