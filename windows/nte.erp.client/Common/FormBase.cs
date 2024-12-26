using System.ComponentModel;
using System.Data;
using System.Text;

namespace nte.erp.client.Common
{
  public partial class FormBase : Form
  {
    public FormBase()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterParent;
      this.KeyPreview = true;
      this.KeyDown += this.FormBase_KeyDown;
    }

    #region Variables

    public Boolean CloseAfterSave = false;
    private Boolean _isChange = false;
    private BackgroundWorker Worker = null;
    private String TitleForm = "";
    private ToolStripItem _WindowItem = null;

    public String TableName = "";
    public String TableNameKey = "sysid";
    public String TableNameUID = "sysuid";
    public String TableFields = "";
    public DataRow DataRow = null;

    public String KeyId = "";
    public String KeyUID = "";
    public Exception LastException;

    public enum States { None, Initialized, New, Load, Reload, Error, Data, DataReload };
    public States State = States.None;

    #endregion Variables

    #region Events
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      if (this._WindowItem != null)
      {
        this._WindowItem.Visible = false;
        this._WindowItem.Tag = null;
      }

      base.OnFormClosed(e);
    }

    protected override void OnGotFocus(EventArgs e)
    {
      base.OnGotFocus(e);
    }

    protected override void OnActivated(EventArgs e)
    {
      if ((this._WindowItem != null) && (this._WindowItem is ToolStripButton))
        (this._WindowItem as ToolStripButton).Checked = true;

      base.OnActivated(e);
    }

    protected override void OnDeactivate(EventArgs e)
    {
      if ((this._WindowItem != null) && (this._WindowItem is ToolStripButton))
        (this._WindowItem as ToolStripButton).Checked = false;

      base.OnDeactivate(e);
    }

    private void WindowsListSelect(object sender, EventArgs e)
    {
      this.Focus();
    }

    public void SetWindowsList(ToolStripItem iWindowItem)
    {
    }

    public void SaveData(object sender, EventArgs e)
    {
      if (this.getSave != null)
        this.getSave(sender, e);
    }

    #endregion Events

    #region Action
    public struct Field
    {
      public object Control;
      public string Name;
      public object Value;
      public object Default;
    }
    public Dictionary<string, object> Fields;
    public void setFields(params object[] iControls)
    {
      this.Fields = new Dictionary<string, object>();

      for (int i = 0; i < iControls.Length; i++)
      {
        if (iControls[i] is TextBox)
        {
          this.Fields.Add((iControls[i] as TextBox).Name, (iControls[i] as TextBox));
        }

        if (iControls[i] is ComboBox)
        {
          this.Fields.Add((iControls[i] as ComboBox).Name, (iControls[i] as ComboBox));
        }

        if (iControls[i] is DataGridView)
        {
          this.Fields.Add((iControls[i] as DataGridView).Name, (iControls[i] as DataGridView));
        }
      }
    }

    public Dictionary<string, object> getFieldValues()
    {
      Dictionary<string, object> fValues = new Dictionary<string, object>();

      if (this.Fields != null)
      {
        foreach (KeyValuePair<string, object> fField in this.Fields)
        {
          if (fField.Value is TextBox)
          {
            fValues.Add(fField.Key, (fField.Value as TextBox).Text);
          }

          if (fField.Value is ComboBox)
          {
            if ((fField.Value as ComboBox).SelectedItem is ComboboxItem)
            {
              var sysid = (((fField.Value as ComboBox).SelectedItem as ComboboxItem).Value as DataRow)["sysid"].ToString();
              fValues.Add(fField.Key, sysid);
            }
            else
            {
              fValues.Add(fField.Key, (fField.Value as ComboBox).SelectedIndex);
            }
          }

          if (fField.Value is DataGridView)
          {
            DataGridView fGridView = (DataGridView)fField.Value;

            if (fGridView.DataMember != null && fGridView.DataSource != null)
            {
              String fTableName = fGridView.DataMember;
              DataSet fDS = (fGridView.DataSource as DataSet);

              if (fDS != null && fDS.Tables.Count > 0)
              {
                //String fKeyValue = Utils.GetStringFromDataSet(fDS, fTableName);
                //fValues.Add(fField.Key, fKeyValue);
              }

            }
            /*string JSONString = string.Empty;
						JSONString = JsonConvert.SerializeObject(((iControls[i] as DataGridView).DataSource as DataSet).Tables[(iControls[i] as DataGridView).DataMember]);

						StringWriter sw = new StringWriter();
						((iControls[i] as DataGridView).DataSource as DataSet).Tables[(iControls[i] as DataGridView).DataMember].WriteXml(sw);

						String fProp = sw.ToString().Replace("</NewDataSet>", "").Replace("<NewDataSet>", "");

						fReturn += String.Format("{0}={1}", (iControls[i] as DataGridView).Name, this.SetBase64(JSONString));*/
          }
        }
      }

      return fValues;
    }
    public bool isSame(DataRow iRow)
    {
      return false;
    }

    public DataRow DataInfo
    {
      get
      {
        return null;
      }
    }

    public Boolean myChange = false;
    public Boolean isChange
    {
      get
      {
        return this._isChange;
      }

      set
      {
        if (value)
        {
          this.Text = "* " + this.TitleForm;
          if (this._WindowItem != null)
            this._WindowItem.Text = "* " + this.TitleForm;
        }
        else
        {
          this.Text = this.TitleForm;
          if (this._WindowItem != null)
            this._WindowItem.Text = this.TitleForm;
        }

        this._isChange = value;
      }
    }

    public Boolean isBusy
    {
      get
      {
        if ((this.Worker != null) && (this.Worker.IsBusy))
          return true;

        if (this.State == States.Load)
          return true;

        if (this.State == States.Reload)
          return true;

        return false;
      }

    }

    public String getParam(String iParamName)
    {
      return this.getParam(iParamName, "");
    }

    public String getParam(String iParamName, String iDefault)
    {
      String fReturn = iDefault;
      return fReturn;
    }

    public class ComboboxItem
    {
      public string Text { get; set; }
      public object Value { get; set; }

      public ComboboxItem(string iText, object iValue)
      {
        this.Text = iText;
        this.Value = iValue;
      }

      public override string ToString()
      {
        return Text;
      }
    }

    public void setItems(ComboBox iComboBox, String iSqlQuery, String iAddItems)
    {
    }

    public void SetValue(ComboBox iComboBox, String iSqlQuery, String iAddItems, Object iValue, String iKeyField = "sysid")
    {
    }
    public String GetValue(ComboBox iComboBox, String iKeyField = "sysid", String iDefault = "")
    {
      if (iComboBox == null)
      {
        return iDefault;
      }

      if ((iComboBox.SelectedItem != null) && (iComboBox.SelectedItem is ComboboxItem))
      {
        if (((iComboBox.SelectedItem as ComboboxItem).Value as DataRow).Table.Columns.Contains(iKeyField))
        {
          return ((iComboBox.SelectedItem as ComboboxItem).Value as DataRow)[iKeyField].ToString();
        }
      }

      return iDefault;
    }

    #endregion Action

    #region Worker

    public void setData()
    {
      this.Worker = new BackgroundWorker();
      this.Worker.DoWork += mainWorker_DoWork;
      this.Worker.RunWorkerCompleted += mainWorker_RunWorkerCompleted;
      this.Worker.RunWorkerAsync(this.getFieldValues());
    }

    public void getData()
    {
      this.Worker = new BackgroundWorker();
      this.Worker.DoWork += mainWorker_DoWork;
      this.Worker.RunWorkerCompleted += mainWorker_RunWorkerCompleted;
      this.Worker.RunWorkerAsync(this.KeyId);
    }

    public void getData(String iKey)
    {
      this.Worker = new BackgroundWorker();
      this.Worker.DoWork += mainWorker_DoWork;
      this.Worker.RunWorkerCompleted += mainWorker_RunWorkerCompleted;
      this.Worker.RunWorkerAsync(iKey);
    }

    public event EventHandler getDataEnd;
    public event EventHandler getSave;
    private void mainWorker_DoWork(object sender, DoWorkEventArgs e)
    {
    }

    private void mainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
    }

    #endregion Worker

    #region Controls

    public void ShowException()
    {
      MessageBox.Show(this.LastException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    //public String GetValue(String iColumnName)
    //{
    //    if ((this.DataInfo != null) && (this.DataInfo[iColumnName] != null))
    //    {
    //        return this.DataInfo[iColumnName].ToString();
    //    }

    //    return String.Empty;
    //}

    public DataTable GetValue(String iColumnName)
    {
      try
      {
        if ((this.DataInfo != null) && (this.DataInfo[iColumnName] != null))
        {
          DataTable dt = new DataTable();// = (DataTable)JsonConvert.DeserializeObject(this.DataInfo[iColumnName].ToString(), (typeof(DataTable)));
          return dt;
          //return (this.DataInfo[iColumnName] as DataTable);
        }
      }
      catch
      {

      }

      return null;
    }

    public Object GetValue(String iColumnName, Object iDefault)
    {
      try
      {
        if ((this.DataInfo != null) && (this.DataInfo[iColumnName] != null))
        {
          return this.DataInfo[iColumnName];
        }
      }
      catch
      {

      }

      return iDefault;
    }
    public int GetValue(String iColumnName, int iDefault)
    {
      try
      {
        if ((this.DataInfo != null) && (this.DataInfo[iColumnName] != null))
        {
          return Convert.ToInt32(this.DataInfo[iColumnName]);
        }
      }
      catch
      {

      }

      return iDefault;
    }

    public void SetValue(FormBase iControl)
    {
      this.SetValue(iControl, String.Empty);
    }
    public void SetValue(FormBase iControl, String iDefault)
    {
      String fText = iDefault;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
            fText = "";
            break;
          case States.New:
            fText = "New";
            break;
          case States.Load:
            fText = "";

            /*if (this._WindowItem != null)
								this._WindowItem.Image = Properties.Resources.Loading;*/

            if (iDefault.Trim().ToString() != "")
            {
              fText = fText + iDefault;
            }
            break;
          case States.Reload:
            //if (this._WindowItem != null)
            //this._WindowItem.Image = Properties.Resources.Loading;

            fText = null;
            break;
          case States.DataReload:
          case States.Data:
            if (this.Tag != null)
            {
              fText = this.Tag.ToString();
            }

            this.TitleForm = fText;
            this.isChange = false;
            break;
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fText != null))
      {
        iControl.Text = fText;
      }
    }
    public void SetValue(Label iControl)
    {
      this.SetValue(iControl, "", "", false);
    }

    public void SetValue(Label iControl, Boolean iForceLoad)
    {
      this.SetValue(iControl, "", "", iForceLoad);
    }

    public void SetValue(Label iControl, String iDefault)
    {
      this.SetValue(iControl, iDefault, "", false);
    }

    public void SetValue(Label iControl, String iDefault, String iColumnName, Boolean iForceLoad)
    {
      String fText = null;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
            fText = "";
            break;
          case States.Load:
            fText = "";
            if (iDefault.Trim().ToString() != "")
              fText = iDefault;
            break;
          case States.Reload:
            if (iForceLoad == true)
            {
              String fColumnName1 = iControl.Name;
              DataRow iRow1 = this.DataInfo;

              if (iRow1[fColumnName1] != null)
                fText = iRow1[fColumnName1].ToString();

            }
            else
              fText = null;
            break;
          case States.Data:
            String fColumnName = iControl.Name;
            DataRow iRow = this.DataInfo;

            if (iRow[fColumnName] != null)
              fText = iRow[fColumnName].ToString();
            break;
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fText != null))
        iControl.Text = fText;
    }

    public void SetValue(TextBox iControl)
    {
      this.SetValue(iControl, "", "", false);
    }

    public void SetValue(TextBox iControl, Boolean iForceLoad)
    {
      this.SetValue(iControl, "", "", iForceLoad);
    }

    public void SetValue(TextBox iControl, String iDefault)
    {
      this.SetValue(iControl, iDefault, "", false);
    }

    public void SetValue(TextBox iControl, String iDefault, String iColumnName, Boolean iForceLoad)
    {
      String fText = null;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
          case States.New:
          case States.Load:
            fText = "";
            if (iDefault.Trim().ToString() != "")
            {

            }
            fText = iDefault;
            break;
          case States.Reload:
            if (iForceLoad == true)
            {
              String fColumnName1 = iControl.Name;
              DataRow iRow1 = this.DataInfo;

              if (iRow1[fColumnName1] != null)
                fText = iRow1[fColumnName1].ToString();

            }
            else
              fText = null;
            break;
          case States.DataReload:
            String fColumnNameR = iControl.Name;
            DataRow iRowR = this.DataInfo;

            if (iRowR[fColumnNameR] != null)
              if (fText != iRowR[fColumnNameR].ToString())
                fText = iRowR[fColumnNameR].ToString();
            break;
          case States.Data:
            String fColumnName = iControl.Name;
            DataRow iRow = this.DataInfo;

            if ((iRow != null) && (iRow[fColumnName] != null))
            {
              //fText = ((iControl.Multiline) ? this.GetBase64(iRow[fColumnName].ToString(), true) : iRow[fColumnName].ToString());
              fText = iRow[fColumnName].ToString();
            }
            break;
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fText != null))
      {
        iControl.Text = fText;
      }
    }

    public void SetValue(ComboBox iControl)
    {
      this.SetValue(iControl, "", "", false);
    }

    public void SetValue(ComboBox iControl, int iSelectIndex)
    {
      this.SetValue(iControl, iSelectIndex, "", false);
    }

    public void SetValue(ComboBox iControl, Boolean iForceLoad)
    {
      this.SetValue(iControl, "", "", iForceLoad);
    }

    public void SetValue(ComboBox iControl, Object iDefault, String iColumnName, Boolean iForceLoad)
    {
      int fIndex = -1;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
          case States.New:
            #region Populate list
            if (iControl != null)
            {
              switch (iControl.Name)
              {
                case "StatusId":
                  iControl.Items.Clear();
                  iControl.Items.Add("Deleted");
                  iControl.Items.Add("Active");
                  iControl.Items.Add("Development");
                  break;
                case "KindId":
                  iControl.Items.Clear();
                  iControl.Items.Add("XML");
                  iControl.Items.Add("Json");
                  iControl.Items.Add("Table all");
                  iControl.Items.Add("Phisical");
                  iControl.Items.Add("CRUD");
                  iControl.Items.Add("Memory");
                  break;
                case "Visibility":
                  iControl.Items.Clear();
                  iControl.Items.Add("(default)");
                  iControl.Items.Add("Blackbox");
                  iControl.Items.Add("Project");
                  iControl.Items.Add("Company");
                  iControl.Items.Add("User");
                  iControl.Items.Add("Session");
                  iControl.Items.Add("Relation");
                  break;
                case "SqlTypeId":
                  iControl.Items.Clear();
                  iControl.Items.Add("(default)");
                  iControl.Items.Add("SQL");
                  iControl.Items.Add("PHP");
                  iControl.Items.Add("Javascript");
                  iControl.Items.Add("Transaction");
                  break;
              }
            }
            #endregion Populate list

            if (iDefault is int)
            {
              fIndex = Convert.ToInt32(iDefault);
            }
            else
            {
              fIndex = -1;
            }
            break;
          case States.Load:
          case States.DataReload:
            break;
          case States.Reload:
            if (iForceLoad == true)
            {
              String fColumnName1 = iControl.Name;
              DataRow iRow1 = this.DataInfo;

              if (iRow1[fColumnName1] != null)
                int.TryParse(iRow1[fColumnName1].ToString(), out fIndex);
            }
            break;
          case States.Data:
            String fColumnName = iControl.Name;
            DataRow iRow = this.DataInfo;

            try
            {
              if ((iRow != null) && (iRow[fColumnName] != null))
              {

                if (iControl.DropDownStyle == ComboBoxStyle.DropDown)
                {
                  iControl.Text = iRow[fColumnName].ToString();
                }
                else
                {
                  int.TryParse(iRow[fColumnName].ToString(), out fIndex);
                }
              }
            }
            catch (Exception ex)
            {
              //Utils.SetException(ex);
            }

            break;
        }
      }
      catch (Exception ex)
      {
        iControl.Text = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fIndex != -1))
      {
        //Boolean fNotSet = true;
        for (int i = 0; i < iControl.Items.Count; i++)
        {
          if (iControl.Items[i] is ComboboxItem)
          {
            if (((iControl.Items[i] as ComboboxItem).Value as DataRow)["sysid"].ToString() == fIndex.ToString())
            {
              fIndex = i;
              break;
            }
          }
        }
        if (fIndex < iControl.Items.Count)
        {
          iControl.SelectedIndex = fIndex;
        }
      }
    }

    public void SetValue(CheckBox iControl)
    {
      this.SetValue(iControl, "", "", false);
    }

    public void SetValue(CheckBox iControl, Boolean iForceLoad)
    {
      this.SetValue(iControl, "", "", iForceLoad);
    }

    public void SetValue(CheckBox iControl, String iDefault)
    {
      this.SetValue(iControl, iDefault, "", false);
    }

    public void SetValue(CheckBox iControl, String iDefault, String iColumnName, Boolean iForceLoad)
    {
      String fText = null;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
          case States.New:
          case States.Load:
            fText = "";
            if (iDefault.Trim().ToString() != "")
            {

            }
            fText = iDefault;
            break;
          case States.Reload:
            if (iForceLoad == true)
            {
              String fColumnName1 = iControl.Name;
              DataRow iRow1 = this.DataInfo;

              if (iRow1[fColumnName1] != null)
                fText = iRow1[fColumnName1].ToString();

            }
            else
              fText = null;
            break;
          case States.DataReload:
            String fColumnNameR = iControl.Name;
            DataRow iRowR = this.DataInfo;

            if (iRowR[fColumnNameR] != null)
              if (fText != iRowR[fColumnNameR].ToString())
                fText = iRowR[fColumnNameR].ToString();
            break;
          case States.Data:
            String fColumnName = iControl.Name;
            DataRow iRow = this.DataInfo;

            if ((iRow != null) && (iRow[fColumnName] != null))
            {
              //fText = ((iControl.Multiline) ? this.GetBase64(iRow[fColumnName].ToString(), true) : iRow[fColumnName].ToString());
              fText = iRow[fColumnName].ToString();
            }
            break;
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fText != null))
      {
        if (iControl.ThreeState)
        {
          switch (fText.Trim().ToLower())

          {
            case "true":
              iControl.CheckState = CheckState.Checked;
              break;
            case "false":
              iControl.CheckState = CheckState.Unchecked;
              break;
            default:
              iControl.CheckState = CheckState.Indeterminate;
              break;
          }
        }
        else
        {
          iControl.CheckState = (fText == "True") ? CheckState.Checked : CheckState.Unchecked;
        }
      }
    }

    public void SetValue(NumericUpDown iControl)
    {
      this.SetValue(iControl, "", "", false);
    }

    public void SetValue(NumericUpDown iControl, Boolean iForceLoad)
    {
      this.SetValue(iControl, "", "", iForceLoad);
    }

    public void SetValue(NumericUpDown iControl, String iDefault)
    {
      this.SetValue(iControl, iDefault, "", false);
    }

    public void SetValue(NumericUpDown iControl, String iDefault, String iColumnName, Boolean iForceLoad)
    {
      String fText = null;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
          case States.New:
          case States.Load:
            fText = "";
            if (iDefault.Trim().ToString() != "")
            {

            }
            fText = iDefault;
            break;
          case States.Reload:
            if (iForceLoad == true)
            {
              String fColumnName1 = iControl.Name;
              DataRow iRow1 = this.DataInfo;

              if (iRow1[fColumnName1] != null)
                fText = iRow1[fColumnName1].ToString();

            }
            else
              fText = null;
            break;
          case States.DataReload:
            String fColumnNameR = iControl.Name;
            DataRow iRowR = this.DataInfo;

            if (iRowR[fColumnNameR] != null)
              if (fText != iRowR[fColumnNameR].ToString())
                fText = iRowR[fColumnNameR].ToString();
            break;
          case States.Data:
            String fColumnName = iControl.Name;
            DataRow iRow = this.DataInfo;

            if ((iRow != null) && (iRow[fColumnName] != null))
            {
              //fText = ((iControl.Multiline) ? this.GetBase64(iRow[fColumnName].ToString(), true) : iRow[fColumnName].ToString());
              fText = iRow[fColumnName].ToString();
            }
            break;
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fText != null) && (!string.IsNullOrEmpty(fText)))
      {
        try
        {
          iControl.Value = Convert.ToInt32(fText);
        }
        catch { }
      }
    }

    public void SetValue(DataGridView iControl)
    {
      this.SetValue(iControl, "", "", false);
    }

    public void SetValue(DataGridView iControl, Boolean iForceLoad)
    {
      this.SetValue(iControl, "", "", iForceLoad);
    }

    public void SetValue(DataGridView iControl, String iDefault)
    {
      this.SetValue(iControl, iDefault, "", false);
    }

    public void SetValue(DataGridView iControl, String iDefault, String iColumnName, Boolean iForceLoad)
    {
      String fText = null;

      try
      {
        switch (this.State)
        {
          case States.None:
          case States.Initialized:
          case States.New:
          case States.Load:
            fText = "";
            if (iDefault.Trim().ToString() != "")
            {

            }
            fText = iDefault;
            break;
          case States.Reload:
            if (iForceLoad == true)
            {
              String fColumnName1 = iControl.Name;
              DataRow iRow1 = this.DataInfo;

              if (iRow1[fColumnName1] != null)
                fText = iRow1[fColumnName1].ToString();

            }
            else
              fText = null;
            break;
          case States.DataReload:
            String fColumnNameR = iControl.Name;
            DataRow iRowR = this.DataInfo;

            if (iRowR[fColumnNameR] != null)
              if (fText != iRowR[fColumnNameR].ToString())
                fText = iRowR[fColumnNameR].ToString();
            break;
          case States.Data:
            String fColumnName = iControl.Name;
            DataRow iRow = this.DataInfo;

            if (iRow[fColumnName] != null)
            {
              //fText = ((iControl.Multiline) ? this.GetBase64(iRow[fColumnName].ToString(), true) : iRow[fColumnName].ToString());
              fText = iRow[fColumnName].ToString();
            }
            break;
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }

      if ((iControl != null) && (fText != null))
      {
        String fTableName = iControl.DataMember;
        DataSet fDS = (iControl.DataSource as DataSet);

        /*DataSet fTempDS = Utils.GetDataSetFromString(fText);

        if (fTempDS != null && 0 < fTempDS.Tables.Count && fTempDS.Tables[fTableName] != null)
        {
          //fDS.Tables.Remove(fTableName);
          //fDS.Tables.Add(fTempDS.Tables[fTableName].Copy());
          Utils.SetTableSync(fTableName, fTempDS, fDS);
        }*/
      }
    }
    public String GetBase64(String iString, Boolean iForce)
    {
      String fReturn = iString;

      try
      {

        if ((iString.EndsWith("==")) || (iForce))
        {
          byte[] data = Convert.FromBase64String(iString);
          fReturn = Encoding.ASCII.GetString(data);
        }
      }
      catch
      {

      }

      return fReturn;
    }

    public String SetBase64(String iString)
    {
      String fReturn = iString;

      if (!iString.EndsWith("=="))
      {
        var plainTextBytes = System.Text.Encoding.ASCII.GetBytes(iString);
        fReturn = "B64:" + System.Convert.ToBase64String(plainTextBytes);

        fReturn = fReturn.Replace("+", "%2B");
      }

      return fReturn;
    }

    #endregion Controls

    #region SetDataRow

    public void SetDataRow(TextBox iControl)
    {
      String fColumnName = iControl.Name;

      if ((this.DataRow != null) && (this.DataRow[fColumnName] != null))
      {
        try
        {
          this.DataRow[fColumnName] = iControl.Text;
        }
        catch { }
      }
    }

    public void SetDataRow(ComboBox iControl)
    {
      String fColumnName = iControl.Name;

      if ((this.DataRow != null) && (this.DataRow[fColumnName] != null))
      {
        if (iControl.Text != "")
        {
          if ((iControl.SelectedItem != null) && (iControl.SelectedItem is ComboboxItem))
          {
            ComboboxItem fCItem = (iControl.SelectedItem as ComboboxItem);
            if ((fCItem.Value != null) && (fCItem.Value is DataRow))
            {
              this.DataRow[fColumnName] = (fCItem.Value as DataRow)[0];
            }
          }
          else
          {
            try
            {
              if (iControl.Text == "(none)")
              {
                //this.DataRow[fColumnName] = iControl.Text;
              }
              else
              {
                this.DataRow[fColumnName] = iControl.Text;
              }
            }
            catch (Exception ex)
            {
              //Utils.SetException(ex);
            }
          }
        }
      }
    }

    public void SetDataRow(CheckBox iControl)
    {
      String fColumnName = iControl.Name;

      if ((this.DataRow != null))
      {
        if (iControl.ThreeState)
        {
          switch (iControl.CheckState)

          {
            case CheckState.Checked:
              this.DataRow[fColumnName] = true;
              break;
            case CheckState.Unchecked:
              this.DataRow[fColumnName] = false;
              break;
            case CheckState.Indeterminate:
              this.DataRow[fColumnName] = DBNull.Value;
              break;
          }
        }
        else
        {
          this.DataRow[fColumnName] = iControl.Checked;
        }
      }
    }

    public void SetDataRow(NumericUpDown iControl)
    {
      String fColumnName = iControl.Name;

      if ((this.DataRow != null) && (this.DataRow[fColumnName] != null))
      {
        this.DataRow[fColumnName] = iControl.Value;
      }
    }

    #endregion
    private void FormBase_KeyDown(object sender, KeyEventArgs e)
    {
      if ((e.Control) && (e.KeyCode == Keys.L) && (Utils.Language != null))
      {
        FormLanguage fLang = new FormLanguage();
        fLang.SetFormName(this.Name);
        fLang.SetShow();

        Utils.Language.SetLanguage(this, true);
      }
    }
  }
}
