using System.Data;

namespace nte.erp.client.Common
{
  public partial class ControlBase : UserControl
  {
    private int Id;
    public List<ToolStripItem> MenuItems = new List<ToolStripItem>();
    /*public List<ToolStripItem> MenuItems
    { 
      get {

        return new List<ToolStripItem>();
      } 
    }*/
    public DataRow DataInfo = null;
    public enum States { None, Initialized, New, Load, Reload, Error, Data, DataReload };
    public States State = States.None;
    public ControlBase()
    {
      InitializeComponent();
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
    public void SetValue(LinkLabel iControl, String iColumnName, String? iDefault = "")
    {
      String? fText = null;

      try
      {
        if (iControl != null)
        {
          String fColumnName = iControl.Name;
          switch (this.State)
          {
            case States.None:
            case States.Initialized:
              fText = "";
              break;
            case States.Load:
              if (iDefault?.Trim().ToString() != "")
              {
                fText = iDefault;
              }
              break;
            case States.Reload:
              if (this.DataInfo.Table.Columns.Contains(fColumnName))
              {
                fText = this.DataInfo[fColumnName].ToString();
              }
              break;
            case States.Data:
              if (this.DataInfo.Table.Columns.Contains(fColumnName))
              {
                fText = this.DataInfo[fColumnName].ToString();
              }
              break;
          }

          if (fText != null)
          {
            iControl.Text = fText;
          }
          else
          {
            if (iDefault != null)
            {
              iControl.Text = iDefault;
            }
          }
        }
      }
      catch (Exception ex)
      {
        fText = "Error: " + ex.Message;
      }
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

  }
}
