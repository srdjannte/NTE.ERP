using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace nte.core
{
  public partial class ControlGrid : System.Windows.Forms.UserControl
  {
    public FormItem Frm = null;
    public DataSet Data = null;
    public DataSet View = null;
    public DataSet Meta = null;

    public class FilterEventArgs : EventArgs
    {
      public FieldItem Fld = null;
      public String Sign = "=";
      public Object Value = null;
    }
    public event EventHandler<FilterEventArgs> FilterEvent;
    public event EventHandler<FilterEventArgs> FilterColumnEvent;

    public event EventHandler CellOpen;
    //public event EventHandler CellCopy;
    public event EventActionHandler CellAction;
    public event EventHandler SelectionChanged;
    public event EventHandler StatChanged;
    public event DataGridViewCellMouseEventHandler CellMouseDoubleClick;
    public event DataGridViewColumnEventHandler ColumnWidthChanged;

    private Boolean _RowAdd = false;
    public Boolean RowAdd
    {
      get
      {
        return this._RowAdd;
      }
      set
      {
        this._RowAdd = value;
      }
    }

    private Boolean _RowChange = false;
    public Boolean RowChange
    {
      get
      {
        return this._RowChange;
      }
      set
      {
        this._RowChange = value;
      }
    }

    private Boolean _RowDelete = false;
    public Boolean RowDelete
    {
      get
      {
        return this._RowDelete;
      }
      set
      {
        this._RowDelete = value;
      }
    }

    private Boolean _ListExport = false;
    public Boolean ListExport
    {
      get
      {
        return this._ListExport;
      }
      set
      {
        this._ListExport = value;
      }
    }

    private Boolean _ListImport = false;
    public Boolean ListImport
    {
      get
      {
        return this._ListImport;
      }
      set
      {
        this._ListImport = value;
      }
    }

    public ControlGrid()
    {
      InitializeComponent();
      this.ListGrid.MouseWheel += ListGrid_MouseWheel;
      this.doDesign();
    }

    public bool IsControlDown()
    {
      return false;
      /*return (System.Windows.Input.Keyboard.Modifiers == ModifierKeys.Control);
			return (this.ModifierKeys & Keys.Control) == Keys.Control;*/
    }

    private void ListGrid_MouseWheel(object sender, MouseEventArgs e)
    {
      if (this.IsControlDown())
      {
        int fWeel = e.Delta;
      }
    }

    private void doDesign()
    {
      this.ListGrid.AutoGenerateColumns = false;
      this.ListGrid.ReadOnly = true;
      this.ListGrid.RowHeadersVisible = false;
      this.ListGrid.AllowUserToAddRows = false;
      this.ListGrid.AllowUserToOrderColumns = true;
      this.ListGrid.AllowUserToResizeColumns = true;
      this.ListGrid.AllowUserToResizeRows = false;
    }

    #region Create

    public void SetForm(FormItem iForm)
    {
      if ((this.Frm != null) && (this.Frm.UpdateCount == iForm.UpdateCount))
      {
        //this.Frm = iForm;
        return;
      }

      this.Frm = iForm;

      this.View = this.Frm.ListViewDS;
      this.Meta = this.Frm.ListMetaDS;
      this.SetMeta();
      this.SetView();
    }

    #endregion

    #region Columns

    public List<DataGridViewColumn> GetColumns()
    {
      List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
      foreach (DataGridViewColumn fHead in this.ListGrid.Columns)
      {
        if ((fHead.DataPropertyName != null) && (!(fHead is DataGridViewButtonColumn)))
        {
          columns.Add(fHead);
        }
      }

      return columns;
    }

    public void SetColumns(List<String> iColumns)
    {
      List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
      foreach (DataGridViewColumn fHead in this.ListGrid.Columns)
      {
        if (fHead.DataPropertyName != "")
        {
          fHead.Visible = (iColumns.IndexOf(fHead.DataPropertyName.ToString()) != -1);
        }
      }
    }

    public List<DataGridViewColumn> GetColumnsVisible()
    {
      List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
      foreach (DataGridViewColumn fHead in this.ListGrid.Columns)
      {
        if (fHead.Visible)
        {
          columns.Add(fHead);
        }
      }

      return columns;
    }

    public List<DataGridViewColumn> GetColumnsSelectable()
    {
      List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
      foreach (DataGridViewColumn fHead in this.ListGrid.Columns)
      {
        FieldItem fField;
        if ((this.Frm != null) && (!String.IsNullOrEmpty(fHead.DataPropertyName)) && (this.Frm.TryListColumn(fHead.DataPropertyName, out fField)))
        {
          if (fField.Selectable || fField.Visible)
          {
            columns.Add(fHead);
          }
        }
      }

      return columns;
    }

    public List<String> GetColumnsName()
    {
      List<String> columns = new List<String>();
      foreach (DataGridViewColumn fHead in this.ListGrid.Columns)
      {
        if (fHead.Visible)
        {
          columns.Add(fHead.DataPropertyName);
        }
      }

      return columns;
    }

    #endregion

    public void SetDevelop(DataSet iData)
    {
      this.SetMeta(null);
      this.SetView(null);
      this.SetData(iData);
    }

    public void SetDevelop(DataSet iData, DataSet iView, DataSet iMeta)
    {
      this.SetMeta(iMeta);
      this.SetView(iView);
      this.SetData(iData);
    }

    private DataSet StringToDataSet(String iData)
    {
      if (iData != null && iData != "" && iData != "Error: Object reference not set to an instance of an object.")
      {
        DataSet fReturn = new DataSet();
        fReturn.ReadXml(XmlReader.Create(new StringReader(iData)));

        return fReturn;
      }

      return null;
    }

    public void SetValue(String iData, String iView, String iMeta)
    {
      this.Data = this.StringToDataSet(iData);
      this.View = this.StringToDataSet(iView);
      this.Meta = this.StringToDataSet(iMeta);
      this.SetMeta();
      this.SetView();
      this.SetData();
    }

    private void SetData()
    {
      if (this.Data != null)
      {
        this.ListGrid.AutoGenerateColumns = false;
        this.ListGrid.DataSource = this.Data;
        this.ListGrid.DataMember = this.Data.Tables[0].TableName;
      }
    }

    public void SetData(DataSet iData, List<FilterItem> iLocalFilter = null)
    {
      if (iData != null)
      {
        this.Data = iData.Copy();
      }

      if ((iLocalFilter != null) && (0 < iLocalFilter.Count))
      {
        this.SetFilterLocal(iLocalFilter);
      }
      else
      {
        this.SetData();
      }
    }

    private bool SetColumnsSync(DataRow iRow)
    {
      Boolean fSelectable = Utils.GetBool(iRow, "listselectable");
      Boolean fVisible = Utils.GetBool(iRow, "listvisible", "fieldvisible");

      if (fVisible || fSelectable)
      {
        for (int i = 0; i < this.ListGrid.Columns.Count; i++)
        {
          if (this.ListGrid.Columns[i].DataPropertyName == iRow["fieldname"].ToString())
          {
            this.ListGrid.Columns[i].HeaderText = iRow["syscaption"].ToString();
            this.ListGrid.Columns[i].Visible = fVisible;

            return true;
          }
        }

        String fFieldControl = Utils.GetString(iRow, "fieldcontrol", "Text");

        DataGridViewColumn fColumn = null;


        if (fFieldControl == "Checkbox")
        {
          fColumn = new DataGridViewCheckBoxColumn();
        }

        if (fFieldControl == "Action")
        {
          fColumn = new DataGridViewButtonColumn();
        }

        if (fColumn == null)
        {
          fColumn = new DataGridViewTextBoxColumn();
        }

        fColumn.DataPropertyName = Utils.GetValue(iRow, "fieldname");
        fColumn.MinimumWidth = 5;
        if (0 < Utils.GetInt(iRow, "listwidth", 0))
        {
          fColumn.Width = Utils.GetInt(iRow, "listwidth", 35);
        }
        else
        {
          fColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        fColumn.HeaderText = Utils.GetString(iRow, "listcaption", "syscaption");
        fColumn.Visible = fVisible;
        if (fFieldControl == "Numeric")
        {
          fColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        if (fFieldControl == "TimeHourMin")
        {
          fColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        int fLastIndex = this.ListGrid.Columns.Add(fColumn);

        FieldItem fField = new FieldItem(iRow);

        if ((fField.liststyle != "") && (fField.liststyle != "<NewDataSet />"))
        {
          this.Styles.Add(fLastIndex, fField);
        }
        if (fFieldControl == "TimeHourMin")
        {
          this.TimeHourMin.Add(fLastIndex, fField);
        }
        if (fFieldControl == "Action")
        {
          this.Actions.Add(fLastIndex, fField);
        }
      }
      else
      {
        foreach (DataGridViewColumn fItem in this.ListGrid.Columns)
        {
          if (fItem.DataPropertyName == iRow["fieldname"].ToString())
          {
            this.ListGrid.Columns.Remove(fItem);
            return true;
          }
        }
      }

      return true;
    }

    public void SetView(DataSet iView)
    {
      if (iView != null)
      {
        this.View = iView.Copy();
      }
      else
      {
        this.View = null;
      }

      this.SetView();
    }

    private void SetView()
    {
      if (this.View != null)
      {
        this.ListGrid.AutoGenerateColumns = false;
        if ((0 < this.View.Tables.Count) && (this.View.Tables["Columns"] != null))
        {
          foreach (DataRow fCol in this.View.Tables["Columns"].Rows)
          {
            this.SetColumnsSync(fCol);
          }
        }

        foreach (ActionItem fItem in Utils.GetListActions(this.Meta))
        {
          if (fItem.ActionRow && !this.ListGrid.Columns.Contains(fItem.UID))
          {
            DataGridViewButtonColumn fColumn = new DataGridViewButtonColumn();

            fColumn.HeaderText = "";
            fColumn.Name = fItem.UID;
            fColumn.UseColumnTextForButtonValue = true;
            fColumn.Text = fItem.Caption;
            fColumn.Tag = fItem;
            fColumn.Width = 60;
            fColumn.MinimumWidth = 20;

            this.ListGrid.Columns.Add(fColumn);
          }
        }
      }
      else
      {
        this.ListGrid.Columns.Clear();
        this.ListGrid.AutoGenerateColumns = true;
      }
    }

    public void SetMeta(DataSet iMeta)
    {
      if (iMeta != null)
      {
        this.Meta = iMeta.Copy();
      }
      else
      {
        this.Meta = null;
      }

      this.SetMeta();
    }

    private void SetMeta()
    {

    }

    private Boolean Is4Find(String iFieldName)
    {
      for (int i = 0; i < this.ListGrid.Columns.Count; i++)
      {
        if ((this.ListGrid.Columns[i] != null) && (this.ListGrid.Columns[i].DataPropertyName == iFieldName) && (this.ListGrid.Columns[i].Visible))
        {
          return true;
        }
      }

      return false;
    }

    public void SetFind(String iFindText)
    {
      this.SetFind(iFindText, null);
    }

    public void SetFind(String iFindText, Object iFieldName)
    {
      if ((this.Data != null) && (0 < this.Data.Tables.Count))
        try
        {
          if (String.IsNullOrEmpty(iFindText))
          {
            this.ListGrid.DataSource = this.Data;
            this.ListGrid.DataMember = this.Data.Tables[0].TableName;
          }
          else
          {
            String f = String.Empty;
            if ((iFieldName != null) && (iFieldName.ToString().Trim() != ""))
            {
              f = String.Format("({0} like '%{1}%')", iFieldName, iFindText);
            }
            else
            {
              f = "(1=2)";
              for (int i = 0; i < this.Data.Tables[0].Columns.Count; i++)
              {
                if (this.Is4Find(this.Data.Tables[0].Columns[i].ColumnName))
                {
                  if (this.Data.Tables[0].Columns[i].DataType.Name == "String")
                  {
                    f += String.Format(" OR ({0} like '%{1}%')", this.Data.Tables[0].Columns[i].ColumnName, iFindText);
                  }
                  int fFindNumber;
                  if ((this.Data.Tables[0].Columns[i].DataType.Name == "Int32") && (int.TryParse(iFindText, out fFindNumber)))
                  {
                    f += String.Format(" OR ({0} = {1})", this.Data.Tables[0].Columns[i].ColumnName, fFindNumber);
                  }
                }
              }
            }
            DataView dv = new DataView(this.Data.Tables[0]);
            dv.RowFilter = f;
            this.ListGrid.DataSource = dv;

            //this.ListGrid.DataSource = this.Data.Tables[0].Select(f);
          }
        }
        catch (Exception ex)
        {
          Utils.SetException(ex);
        }
    }

    public void SetFilterLocal(List<FilterItem> iFilter)
    {
      if ((this.Data != null) && (0 < this.Data.Tables.Count))
      {
        try
        {
          if (0 < iFilter.Count)
          {
            int fOrOpen = 0;
            String f = "(1=1)";
            foreach (FilterItem fFilter in iFilter)
            {
              //if ((fFilter.Oper == "OR") && (fOrOpen == 0))
              //{
              //  f += " AND ( ";
              //  fOrOpen++;
              //}
              //if ((fFilter.Oper == "AND") && (fOrOpen != 0))
              //{
              //  f += " ) ";
              //  fOrOpen = 0;
              //}

              f += fFilter.GetFiter();
            }
            if (fOrOpen != 0)
            {
              f += " ) ";
              fOrOpen = 0;
            }
            DataView dv = new DataView(this.Data.Tables[0]);
            dv.RowFilter = f;
            this.ListGrid.DataSource = dv;
          }
          else
          {
            this.ListGrid.DataSource = this.Data;
            this.ListGrid.DataMember = this.Data.Tables[0].TableName;
          }
        }
        catch (Exception ex)
        {
          Utils.SetException(ex);
        }
      }
    }

    public void ClearFind()
    {
      if ((this.Data != null) && (0 < this.Data.Tables.Count))
      {
        this.ListGrid.DataSource = this.Data;
        this.ListGrid.DataMember = this.Data.Tables[0].TableName;
      }
    }

    private void ListGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        if (e.RowIndex == -1)
        {
          if (e.ColumnIndex < this.ListGrid.Columns.Count)
          {
            int c = e.ColumnIndex;
            FieldItem fField;
            if ((this.Frm != null) && (this.Frm.TryListColumn(this.ListGrid.Columns[e.ColumnIndex].DataPropertyName, out fField)))
            {
              this.MenuHeaderVisible.Visible = true;
              this.MenuHeaderVisible.Enabled = fField.Selectable;
              this.MenuHeaderVisible.Checked = this.ListGrid.Columns[c].Visible;
            }
            else
            {
              this.MenuHeaderVisible.Visible = false;
            }

            if (this.MenuHeaderColumns.DropDownItems.Count == 2)
            {
              foreach (DataGridViewColumn fColumn in this.GetColumnsSelectable())
              {
                ToolStripMenuItem fItem = new ToolStripMenuItem();

                fItem.Text = fColumn.HeaderText;
                fItem.Checked = fColumn.Visible;
                fItem.Enabled = true;
                fItem.Tag = fColumn.Index;
                fItem.Click += this.MenuHeaderVisible_Click;
                FieldItem fFieldFound;
                if (this.Frm.TryListColumn(fColumn.DataPropertyName, out fFieldFound))
                {
                  fItem.Enabled = fFieldFound.Selectable;
                }
                this.MenuHeaderColumns.DropDownItems.Add(fItem);
              }
            }
            else
            {
              foreach (ToolStripItem fColumn in this.MenuHeaderColumns.DropDownItems)
              {
                int i;
                if ((fColumn.Tag != null) && (int.TryParse(fColumn.Tag.ToString(), out i)))
                {
                  if ((fColumn as ToolStripMenuItem).Checked != this.ListGrid.Columns[i].Visible)
                  {
                    (fColumn as ToolStripMenuItem).Checked = this.ListGrid.Columns[i].Visible;
                  }
                }
              }
            }

            this.MenuHeader.Tag = c;
          }

          this.MenuHeader.Show(Cursor.Position);
        }
        else
        {
          this.MenuCell.Show(Cursor.Position);
          this.ListGrid.CurrentCell = this.ListGrid[e.ColumnIndex, e.RowIndex];
        }

      }
    }

    public void SetFocusIdentety(String iRowUID, String iFieldName)
    {
      //foreach(DataRow fRow in this.ListGrid.Rows
    }

    public int GetRowsCount()
    {
      if (this.ListGrid != null)
      {
        return ListGrid.RowCount;
      }

      return 0;
    }

    public string GetSelColName()
    {
      if (this.ListGrid.CurrentCell == null)
      {
        return String.Empty;
      }

      int fColindex = this.ListGrid.CurrentCell.ColumnIndex;

      return this.ListGrid.Columns[fColindex].DataPropertyName;
    }

    public DataRow GetNewRow()
    {
      return this.Data.Tables[0].NewRow();
    }

    public DataRow GetSelRow()
    {
      try
      {
        if (ListGrid.CurrentRow != null)
        {
          DataRowView currentDataRowView = (DataRowView)ListGrid.CurrentRow.DataBoundItem;
          DataRow row = currentDataRowView.Row;

          return row;
        }
      }
      catch { }

      return null;
      /*DataGridViewRow row = this.ListGrid.Rows[this.ListGrid.SelectedCells[0].RowIndex];

			DataRow rows = ((DataRow)row.DataBoundItem);*/

      /*if (0 < this.ListGrid.SelectedRows.Count)
			{
				return ((DataRowView)this.ListGrid.SelectedRows[0].DataBoundItem).Row;
			}*/
      //return null;
      //DataRow row = ((DataRowView)this.ListGrid.DataBoundItem).Row;
    }

    public DataGridViewColumn GetSelCol()
    {
      if (this.ListGrid.CurrentCell == null)
      {
        return null;
      }

      int fColindex = this.ListGrid.CurrentCell.ColumnIndex;

      return this.ListGrid.Columns[fColindex];
    }

    public int GetSelRowIndex()
    {
      if (this.ListGrid.CurrentCell == null)
      {
        return 0;
      }

      return this.ListGrid.CurrentCell.RowIndex;
    }

    public void SetSelRowIndex(int iRowIndex)
    {
      if ((0 < iRowIndex) && (iRowIndex < this.ListGrid.Rows.Count))
      {
        this.ListGrid.Rows[iRowIndex].Selected = true;
        this.ListGrid.FirstDisplayedScrollingRowIndex = iRowIndex;
      }
    }

    public FieldItem GetSelField()
    {
      if (this.ListGrid.CurrentCell == null)
      {
        return null;
      }

      int cI = this.ListGrid.CurrentCell.ColumnIndex;

      if (cI < this.ListGrid.Columns.Count)
      {
        FieldItem fField;
        if (this.Frm.TryListColumn(this.ListGrid.Columns[cI].DataPropertyName, out fField))
        {
          return fField;
        }
      }

      return null;
    }

    public object GetSelValue()
    {
      return this.ListGrid.CurrentCell.Value;
    }

    public String GetSelFieldValueText()
    {
      if (this.ListGrid.CurrentCell == null)
      {
        return String.Empty;
      }

      String fResult = String.Empty;

      int cI = this.ListGrid.CurrentCell.ColumnIndex;
      int rI = this.ListGrid.CurrentCell.RowIndex;

      if (cI < this.ListGrid.Columns.Count)
      {
        fResult = String.Format("#{0} {1}: {2}", rI + 1, this.ListGrid.Columns[cI].HeaderText, this.ListGrid.CurrentCell.Value);
      }
      else
      {
        fResult = String.Format("#{0} {1}", rI + 1, this.ListGrid.CurrentCell.Value);
      }

      return fResult;
    }

    public String GetSelPosText()
    {
      return this.GetSelPosText("[{0},{1}]");
    }

    public String GetSelPosText(String iFormat)
    {
      if (this.ListGrid.CurrentCell == null)
      {
        return String.Empty;
      }

      String fResult = String.Empty;

      int cI = this.ListGrid.CurrentCell.ColumnIndex;
      int rI = this.ListGrid.CurrentCell.RowIndex;

      fResult = String.Format(iFormat, rI + 1, cI + 1);

      return fResult;
    }

    private void ListGrid_SelectionChanged(object sender, EventArgs e)
    {
      this.GetStatsRun();
      if (this.SelectionChanged != null)
      {
        this.SelectionChanged.Invoke(sender, e);
      }
    }

    private void ListGrid_MouseDown(object sender, MouseEventArgs e)
    {
      //e.
      //MenuHeader
    }

    private void ListGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if ((0 < this.ListGrid.SelectedCells.Count) && (0 <= this.ListGrid.SelectedCells[0].ColumnIndex) && (0 <= this.ListGrid.SelectedCells[0].RowIndex) && (0 <= e.ColumnIndex) && (0 <= e.RowIndex))
      {
        if (this.CellMouseDoubleClick != null)
        {
          this.CellMouseDoubleClick.Invoke(sender, e);
        }

        if (this.CellOpen != null)
        {
          this.CellOpen.Invoke(sender, e);
        }
      }
    }

    private void MenuHeader_Click(object sender, EventArgs e)
    {
      if (sender == this.MenuHeaderVisible)
      {
        int fColIndex = Convert.ToInt32(this.MenuHeader.Tag);
        this.ListGrid.Columns[fColIndex].Visible = !this.ListGrid.Columns[fColIndex].Visible;
      }

      if (sender == this.MenuHeaderColumnsAll)
      {
        for (int c = 0; c < this.ListGrid.Columns.Count; c++)
        {
          this.ListGrid.Columns[c].Visible = true;
        }
      }
    }

    private void MenuHeaderVisible_Click(object sender, EventArgs e)
    {
      int fColIndex = Convert.ToInt32((sender as ToolStripMenuItem).Tag);
      this.ListGrid.Columns[fColIndex].Visible = !this.ListGrid.Columns[fColIndex].Visible;
    }

    private void MenuCell_Click(object sender, EventArgs e)
    {
      if (sender == this.MenuCellOpen)
      {
        if (this.CellOpen != null)
        {
          this.CellOpen.Invoke(sender, null);
        }
      }

      if (sender == this.MenuCellCopy)
      {
        if (this.ListGrid.SelectedCells.Count > 0)
        {
          Clipboard.SetText(this.ListGrid.SelectedCells[0].Value.ToString());
        }
      }

      if (sender == this.MenuCellIn)
      {
        if (this.FilterEvent != null)
        {
          FilterEventArgs fArg = new FilterEventArgs();

          fArg.Fld = this.GetSelField();
          fArg.Sign = "=";
          fArg.Value = this.GetSelValue();

          this.FilterEvent.Invoke(sender, fArg);
        }
      }

      if (sender == this.MenuCellOut)
      {
        if (this.FilterEvent != null)
        {
          FilterEventArgs fArg = new FilterEventArgs();

          fArg.Fld = this.GetSelField();
          fArg.Sign = "!=";
          fArg.Value = this.GetSelValue();

          this.FilterEvent.Invoke(sender, fArg);
        }
      }
    }

    #region Stats

    //public event EventHandler StatsChanged;
    public String GetStatText = String.Empty;
    public String GetStatType = "Count";
    public String GetStatField = String.Empty;
    public Object GetStatValue = null;
    public StatData GetStatData = new StatData();
    public class StatData
    {
      public DataGridViewColumn Column = null;
      public String Field = String.Empty;
      public String Type = "Count";
      public long Count = 0;

      public long ValInt = 0;
      public long ValIntLow = int.MaxValue;
      public long ValIntHigh = int.MinValue;
      public long ValIntAvg = 0;
      public long ValIntSum = 0;

      public decimal ValDec = 0;
      public decimal ValDecLow = decimal.MaxValue;
      public decimal ValDecHigh = decimal.MinValue;
      public decimal ValDecAvg = 0;
      public decimal ValDecSum = 0;

      public DateTime ValDT = DateTime.Now;
      public DateTime ValDTLow = DateTime.MaxValue;
      public DateTime ValDTHigh = DateTime.MinValue;
      public DateTime ValDTAvg = DateTime.Now;
      public DateTime ValDTSum = DateTime.Now;

      public StatData()
      {

      }

      public StatData(String iType, DataGridViewColumn iColumn)
      {
        this.Type = iType;
        this.Column = iColumn;
        this.Field = (iColumn != null) ? iColumn.DataPropertyName : String.Empty;
      }

      public object GetValue()
      {
        object fResult = String.Empty;

        if ((this.Column != null) && (this.Column.ValueType != null))
        {
          String fColType = this.Column.ValueType.ToString();

          switch (this.Type)
          {
            case "Count":
              fResult = this.Count;
              break;
            case "Min":
              switch (fColType)
              {
                case "System.Double":
                case "System.Decimal":
                  fResult = this.ValDecLow;
                  break;
                case "System.String":
                case "System.Int32":
                  fResult = this.ValIntLow;
                  break;
                case "System.DateTime":
                  fResult = this.ValDTLow;
                  break;
                default:
                  break;
              }
              break;
            case "Max":
              switch (fColType)
              {
                case "System.Double":
                case "System.Decimal":
                  fResult = this.ValDecHigh;
                  break;
                case "System.String":
                case "System.Int32":
                  fResult = this.ValIntHigh;
                  break;
                case "System.DateTime":
                  fResult = this.ValDTHigh;
                  break;
                default:
                  break;
              }
              break;
            case "Avg":
              switch (fColType)
              {
                case "System.Double":
                case "System.Decimal":
                  fResult = this.ValDecAvg;
                  break;
                case "System.String":
                case "System.Int32":
                  fResult = this.ValIntAvg;
                  break;
                case "System.DateTime":
                  fResult = this.ValDTAvg;
                  break;
                default:
                  break;
              }
              break;
            case "Sum":
              switch (fColType)
              {
                case "System.Double":
                case "System.Decimal":
                  fResult = this.ValDecSum;
                  break;
                case "System.String":
                case "System.Int32":
                  fResult = this.ValIntSum;
                  break;
                case "System.DateTime":
                  fResult = this.ValDTSum;
                  break;
                default:
                  break;
              }
              break;
          }
        }
        else
        {
          fResult = this.Count;
        }
        return fResult;
      }
    }

    public String SetStatType(object iType)
    {
      this.GetStatType = iType.ToString();
      this.GetStatsRun();

      return this.GetStatType;
    }

    private void GetStatsRun()
    {
      if (!this.StatsBW.IsBusy)
      {
        DataGridViewColumn fCol = this.GetSelCol();
        this.StatsBW.RunWorkerAsync(new StatData(this.GetStatType, fCol));
      }
    }

    private void StatsBW_DoWork(object sender, DoWorkEventArgs e)
    {
      if ((e.Argument == null) || !(e.Argument is StatData))
      {
        e.Result = false;

        return;
      }

      StatData fStat = (e.Argument as StatData);

      if (fStat.Type == "Count")
      {
        fStat.Count = -1;
        if ((this.Data != null) && (0 < this.Data.Tables.Count))
        {
          fStat.Count = this.Data.Tables[0].Rows.Count;
        }
      }
      else
      {
        if (this.Data != null && 0 < this.Data.Tables.Count)
        {
          foreach (DataRow fRow in this.Data.Tables[0].Rows)
          {
            if (this.StatsBW.CancellationPending)
            {
              e.Result = false;

              return;
            }
            try
            {
              fStat.Count++;
              if ((fStat.Column != null) && (fStat.Column.ValueType != null))
                switch (fStat.Column.ValueType.ToString())
                {
                  case "System.Double":
                  case "System.Decimal":
                    fStat.ValDec = Convert.ToDecimal(fRow[fStat.Field]);
                    fStat.ValDecLow = (fStat.ValDecLow > fStat.ValDec) ? fStat.ValDec : fStat.ValDecLow;
                    fStat.ValDecHigh = (fStat.ValDecHigh < fStat.ValDec) ? fStat.ValDec : fStat.ValDecHigh;
                    fStat.ValDecSum += fStat.ValDec;
                    fStat.ValDecAvg = Math.Round(Convert.ToDecimal(fStat.ValDecSum / fStat.Count), 2);
                    break;
                  case "System.Int32":
                    fStat.ValInt = Convert.ToInt32(fRow[fStat.Field]);
                    fStat.ValIntLow = (fStat.ValIntLow > fStat.ValInt) ? fStat.ValInt : fStat.ValIntLow;
                    fStat.ValIntHigh = (fStat.ValIntHigh < fStat.ValInt) ? fStat.ValInt : fStat.ValIntHigh;
                    fStat.ValIntSum += fStat.ValInt;
                    fStat.ValIntAvg = Convert.ToInt32(fStat.ValIntSum / fStat.Count);
                    break;
                  case "System.String":
                    fStat.ValInt = Convert.ToString(fRow[fStat.Field]).Length;
                    fStat.ValIntLow = (fStat.ValIntLow > fStat.ValInt) ? fStat.ValInt : fStat.ValIntLow;
                    fStat.ValIntHigh = (fStat.ValIntHigh < fStat.ValInt) ? fStat.ValInt : fStat.ValIntHigh;
                    fStat.ValIntSum += fStat.ValInt;
                    fStat.ValIntAvg = Convert.ToInt32(fStat.ValIntSum / fStat.Count);
                    break;
                  case "System.DateTime":
                    fStat.ValDT = Convert.ToDateTime(fRow[fStat.Field]);
                    fStat.ValInt = fStat.ValDT.Ticks;
                    fStat.ValDTLow = (fStat.ValDTLow > fStat.ValDT) ? fStat.ValDT : fStat.ValDTLow;
                    fStat.ValDTHigh = (fStat.ValDTHigh < fStat.ValDT) ? fStat.ValDT : fStat.ValDTHigh;

                    fStat.ValIntSum += fStat.ValInt;
                    fStat.ValIntAvg = Convert.ToInt32(fStat.ValIntSum / fStat.Count);

                    fStat.ValDTSum = new DateTime(fStat.ValIntSum);
                    fStat.ValDTAvg = new DateTime(fStat.ValIntAvg);
                    break;
                  default:
                    break;
                }
            }
            catch (Exception ex)
            {
              Utils.SetException(ex);
            }
          }
          //this.StatsBW.ReportProgress(1, fStat.GetValue());
        }
      }

      e.Result = fStat;
    }

    private void StatsBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      if (1 == e.ProgressPercentage)
      {
        this.GetStatText = String.Format("{0}: {1}", this.GetStatType, e.UserState);
        if (this.StatChanged != null)
        {
          this.StatChanged.Invoke(sender, null);
        }
      }
    }

    private void StatsBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Result is StatData)
      {
        this.GetStatData = (e.Result as StatData);
        this.GetStatText = String.Format("{0}: {1}", this.GetStatData.Type, this.GetStatData.GetValue());
        if (this.StatChanged != null)
        {
          this.StatChanged.Invoke(sender, null);
        }
      }
      if (e.Result is Boolean)
      {
        if (!Convert.ToBoolean(e.Result))
        {
          this.GetStatsRun();
        }
      }
    }

    #endregion Stats

    #region Events

    private void MenuCell_Opening(object sender, CancelEventArgs e)
    {
      this.MenuCellOpen.Visible = ((this.Frm.ListOpenType != "") && (this.Frm.ListOpenType != "(nothing)"));

      this.MenuCellChange.Enabled = this.RowChange;
      //this.MenuCellDelete.Enabled = this.RowDelete;
      this.MenuCellDelete.Enabled = this.Frm.ListDelete;
      this.MenuCellAction.Visible = this.RowChange || this.RowDelete;
    }

    private void ListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if ((this.ListGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) && (0 <= e.RowIndex))
      {
        if (((this.ListGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Tag != null) && ((this.ListGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Tag is ActionItem))
        {
          if ((this.CellAction != null) && (this.GetSelRow() != null))
          {
            ActionItem fAction = (this.ListGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn).Tag as ActionItem;
            fAction.DataItem = this.GetSelRow();

            EventActionArgs eTmp = new EventActionArgs();
            eTmp.Action = fAction;
            this.CellAction.Invoke(sender, eTmp);
          }
        }

        if ((0 < this.Actions.Count) && (this.Actions.ContainsKey(e.ColumnIndex)))
        {
          DataRow fSelRow = this.GetSelRow();
          if ((this.CellAction != null) && (fSelRow != null))
          {
            String fPropStr = this.ListGrid.Columns[e.ColumnIndex].DataPropertyName;
            String fActionStr = Utils.GetString(fSelRow, fPropStr);
            ActionItem fAction = new ActionItem(fActionStr, fSelRow);

            EventActionArgs eTmp = new EventActionArgs();
            eTmp.Action = fAction;
            this.CellAction.Invoke(sender, eTmp);
          }


          /*if ((e.Value != null) && (e.Value.ToString() != ""))
          {

            e.Value = this.GetAsParams(e.Value.ToString())["Caption"].ToString();
          }*/
        }
      }
    }

    public Dictionary<string, string> GetAsParams(String iParams)
    {
      String fStr = iParams;
      Dictionary<string, string> fReturn = new Dictionary<string, string>();

      foreach (String fLine in fStr.Split(';'))
      {
        if (fLine != "" && -1 < fLine.IndexOf('='))
        {
          String[] fLineArr = fLine.Split('=');
          fReturn.Add(fLineArr[0], fLineArr[1]);
        }
      }

      return fReturn;
    }

    private Dictionary<int, FieldItem> Styles = new Dictionary<int, FieldItem>();
    private Dictionary<int, FieldItem> Actions = new Dictionary<int, FieldItem>();
    private Dictionary<int, FieldItem> TimeHourMin = new Dictionary<int, FieldItem>();

    private void ListGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      try
      {
        if ((0 < this.Styles.Count) && (this.Styles.ContainsKey(e.ColumnIndex)))
        {
          string fValue = (this.ListGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) ? this.ListGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() : "";
          FieldItem fField;
          Color fColor;
          if ((this.Styles.TryGetValue(e.ColumnIndex, out fField)) && (fField.TryListStyleColor("Cell Color", fValue, out fColor)))
          {
            e.CellStyle.BackColor = fColor;
          }
        }

        if ((0 < this.TimeHourMin.Count) && (this.TimeHourMin.ContainsKey(e.ColumnIndex)))
        {
          e.Value = String.Format("{0}h", (Convert.ToInt32(e.Value) / 60));
        }
        if ((0 < this.Actions.Count) && (this.Actions.ContainsKey(e.ColumnIndex)))
        {
          if ((e.Value != null) && (e.Value.ToString() != ""))
          {
            
            e.Value = this.GetAsParams(e.Value.ToString())["Caption"].ToString();
          }
        }
      }
      catch
      {
      }
    }

    #endregion

    private bool IsIdentyFocus(int iColumnIndex, int iRowIndex, out IdentityItem oIdentity)
    {
      oIdentity = null;

      return false;
    }

    private void ListGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      IdentityItem fIdentity;
      if (e.ColumnIndex > -1 && e.RowIndex > -1 && this.IsIdentyFocus(e.ColumnIndex, e.RowIndex, out fIdentity))
      {
        using (var selectedPen = new Pen(fIdentity.Color, 1))
        {
          var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
          var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
          var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
          var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

          e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
          e.Graphics.DrawRectangle(selectedPen, new System.Drawing.Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));

          e.Handled = true;
        }
      }
      /*
			//Draw only grid content cells not ColumnHeader cells nor RowHeader cells
			if (e.ColumnIndex > -1 & e.RowIndex > -1)
			{
				//Pen for left and top borders
				using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))
				//Pen for bottom and right borders
				using (var gridlinePen = new Pen(ListGrid.GridColor, 1))
				//Pen for selected cell borders
				using (var selectedPen = new Pen(Color.Red, 1))
				{
					var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
					var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
					var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
					var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

					//Draw selected cells here
					if (this.ListGrid[e.ColumnIndex, e.RowIndex].Selected)
					{
						//Paint all parts except borders.
						e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

						//Draw selected cells border here
						e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));

						//Handled painting for this cell, Stop default rendering.
						e.Handled = true;
					}
					//Draw non-selected cells here
					else
					{
							//Paint all parts except borders.
							e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

							//Top border of first row cells should be in background color
							if (e.RowIndex == 0)
								e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

							//Left border of first column cells should be in background color
							if (e.ColumnIndex == 0)
								e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

							//Bottom border of last row cells should be in gridLine color
							if (e.RowIndex == ListGrid.RowCount - 1)
								e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
							else  //Bottom border of non-last row cells should be in background color
								e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

							//Right border of last column cells should be in gridLine color
							if (e.ColumnIndex == ListGrid.ColumnCount - 1)
								e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
							else //Right border of non-last column cells should be in background color
								e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

							//Top border of non-first row cells should be in gridLine color, and they should be drawn here after right border
							if (e.RowIndex > 0)
								e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

							//Left border of non-first column cells should be in gridLine color, and they should be drawn here after bottom border
							if (e.ColumnIndex > 0)
								e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

							//We handled painting for this cell, Stop default rendering.
							e.Handled = true;
						}
					}
				}
			*/
    }

    private void ListGrid_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if ((this.FilterColumnEvent != null))
      {
        String fFieldName = this.ListGrid.Columns[e.ColumnIndex].DataPropertyName;

        FilterEventArgs fArg = new FilterEventArgs();

        foreach (FieldItem fItem in this.Frm.GetFields())
        {
          if (fItem.Name == fFieldName)
          {
            fArg.Fld = fItem;
            //fArg.Sign = "=";

            this.FilterColumnEvent.Invoke(sender, fArg);
          }
        }
      }
    }

    private void ListGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
    {
      if (this.ColumnWidthChanged != null)
      {
        this.ColumnWidthChanged.Invoke(sender, e);
      }
    }
  }
}
