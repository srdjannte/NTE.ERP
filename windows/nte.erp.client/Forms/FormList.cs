using nte.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static nte.core.ControlGrid;
using static nte.core.GlobalServer;

namespace nte.forms.Forms
{
  public partial class FormList : Form
  {
    private DataSet Data = null;
    private int RefreshCount = 0;
    private int RefreshLastIndex = 0;

    #region Constructor

    public FormList(nte.core.MenuItem.Item iMenu, FormItem iForm)
    {
      InitializeComponent();

      if (Global.StartTypeIsMDI)
      {
        this.MainMenuStrip = null;
        this.MainMenu.Visible = false;
        this.MainToolPin.Visible = false;
        this.MainMenuPin.Visible = false;
      }
      else
      {
        this.MainMenuStrip = this.MainMenu;
        this.MainMenu.Visible = true;
      }

      Global.Language.Translate(this);
      this.MenuItem = iMenu;
      this.Frm = iForm;
      //this.Frm.Session = iMenu.Session;
      this.Text = iMenu.Caption;

      this.ListGrid.CellOpen += new EventHandler(this.ListGrid_CellOpen);
      this.ListGrid.CellAction += new EventActionHandler(this.ListGrid_CellAction);
      this.ListGrid.SelectionChanged += new EventHandler(this.ListGrid_SelectionChanged);
      this.ListGrid.StatChanged += new EventHandler(this.ListGrid_StatChanged);
      this.ListGrid.FilterEvent += this.ListGrid_FilterEvent;
      this.ListGrid.FilterColumnEvent += this.ListGrid_FilterColumnEvent;

      if ((this.Frm != null) && (this.Frm.Session != null) && (this.Frm.Session.Server != null) && this.Frm.Session.Server.IsActive)
      {
        this.Frm.Session.Server.ReciveChanged += Server_ReciveChanged;
        this.MainToolUsers.Visible = true;
      }
      else
      {
        this.MainToolUsers.Visible = false;
      }

      this.EventSend(this.Frm, "Open");

      this.onCapsNumChanged += System_onCapsNumChanged;
      this.doDesign();
      this.RefreshData();
    }

    private void Server_ReciveChanged(object sender, ReciveArgs e)
    {
      if ((e.FormUID == this.Frm.UID) && (e.InfoUID == this.Frm.Session.Identity.InfoUID) && (e.IdentityUID != this.Frm.Session.Identity.UID))
      {
        switch (e.EventName.ToLower())
        {
          case "open":
            Boolean fAdd = true;

            for (int i = this.MainTool.Items.Count - 1; 0 <= i; i--)
              try
              {
                if ((this.MainTool.Items[i].Tag != null) && (this.MainTool.Items[i].Tag is IdentityItem))
                {
                  if ((this.MainTool.Items[i].Tag as IdentityItem).UID == e.IdentityUID)
                  {
                    fAdd = false;
                    break;
                  }
                }
              }
              catch { }

            if (fAdd)
            {
              IdentityItem fUser = this.Frm.Session.GetIdentity(e.IdentityUID);
              ToolStripButton fUsr = new ToolStripButton();
              fUsr.Text = fUser.Caption;
              fUsr.Tag = fUser;
              fUsr.DisplayStyle = ToolStripItemDisplayStyle.Text;
              fUsr.BackColor = Color.Aqua;
              this.MainTool.Items.Add(fUsr);
              this.Identities.Add(fUser.UID, fUser);
            }
            break;
          case "close":
            for (int i = this.MainTool.Items.Count - 1; 0 <= i; i--)
            {
              try
              {
                if ((this.MainTool.Items[i].Tag != null) && (this.MainTool.Items[i].Tag is IdentityItem))
                {
                  if ((this.MainTool.Items[i].Tag as IdentityItem).UID == e.IdentityUID)
                  {
                    this.MainTool.Items.Remove(this.MainTool.Items[i]);
                    this.Identities.Remove((this.MainTool.Items[i].Tag as IdentityItem).UID);
                  }
                }
              }
              catch { }
            }
            break;
          case "focus":
            try
            {
              this.ListGrid.SetFocusIdentety(e.IdentityUID, "focus");
            }
            catch { }
            break;
        }
      }
    }

    private void doDesign()
    {
      this.StartPosition = FormStartPosition.CenterParent;
      this.System_onCapsNumChanged(null, null);
      if (this.Frm != null)
      {
        Boolean fPaging = this.Frm.Service.HasLimit();

        this.MainToolPageSep.Visible = fPaging;
        this.MainToolPagePrev.Visible = fPaging;
        this.MainToolPageNmb.Visible = fPaging;
        this.MainToolPageNext.Visible = fPaging;

        this.MainMenuAdd.Visible = this.Frm.ListAdd;
        this.MainMenuS0.Visible = this.Frm.ListAdd;

        this.MainMenuExcelOpen.Visible = this.Frm.ListExcel;
        this.MainMenuImport.Visible = this.Frm.ListImport;
        this.MainMenuExport.Visible = this.Frm.ListExport;
        this.MainMenuS2.Visible = this.Frm.ListImport || this.Frm.ListExport || this.Frm.ListExcel;

        this.ListGrid.RowChange = this.Frm.ListChange;
        this.ListGrid.RowDelete = this.Frm.ListDelete;

        //this.MainMenuInport.Visible = this.Form.ListAdd;

        this.MainMenuAdd.Visible = this.Frm.ListAdd;
        this.MainToolDataAdd.Visible = this.Frm.ListAdd;
      }

      if (this.Frm != null)
      {
        this.ListGrid.SetForm(this.Frm);
        this.FilterList.Set(this.Frm);

        this.MainToolFilterView.Checked = (0 < this.Frm.GetFilterMandatoryTable().Rows.Count);
        this.FilterSplitContainer.Panel1Collapsed = !this.MainToolFilterView.Checked;
      }
    }

    private void System_onCapsNumChanged(object sender, EventArgs e)
    {
      this.StatusCapsLock.ForeColor = Global.CapsLockColor;
      this.StatusNumLock.ForeColor = Global.NumLockColor;
    }

    #endregion Constructor

    #region Events

    private bool ShowDetail(Boolean iIsNew)
    {
      this.Cursor = Cursors.AppStarting;

      DataRow fRow = null;
      if (!iIsNew)
      {
        fRow = this.ListGrid.GetSelRow();
      }
      else
      {
        fRow = this.ListGrid.GetNewRow();
      }

      switch (this.Frm.DetailView)
      {
        case "Simple":
          FormDetailSimple fFormDetailSimple = new FormDetailSimple();

          fFormDetailSimple.SetRow(fRow, this.Frm);
          Global.AddForm(fFormDetailSimple);
          if (this.Frm.DetailModal)
          {
            if (fFormDetailSimple.ShowDialog(this) == DialogResult.OK)
            {
              this.RefreshData();
            }
          }
          else
          {
            fFormDetailSimple.Show(this);
          }
          break;
        case "Custom":
          FormDetailComplex fFormDetailComplex = new FormDetailComplex();

          this.Frm.GetDefaults(Global.FolderData);
          fFormDetailComplex.SetRow(fRow, this.Frm, iIsNew);
          Global.AddForm(fFormDetailComplex);
          if (this.Frm.DetailModal)
          {
            if (fFormDetailComplex.ShowDialog(this) == DialogResult.OK)
            {
              this.RefreshData();
            }
          }
          else
          {
            fFormDetailComplex.Show(this);
          }
          break;
      }
      var timer = new Timer();
      timer.Interval = 800;
      timer.Tick += Action_Tick;
      timer.Start();

      return true;
    }

    private void ListGrid_SelectionChanged(object sender, EventArgs e)
    {
      this.MainStatusLabel.Text = this.ListGrid.GetSelFieldValueText();
      this.MainStatusState.Text = this.ListGrid.GetSelPosText();

      if (this.ListGrid.GetSelRow() != null)
      {
        this.EventSend(this.Frm, "Focus", Utils.GetRowAsMD5(this.ListGrid.GetSelRow()), this.ListGrid.GetSelColName());
      }
    }

    private void ListGrid_StatChanged(object sender, EventArgs e)
    {
      this.MainStatusStat.Text = this.ListGrid.GetStatText;
    }

    private void ListGrid_FilterEvent(object sender, FilterEventArgs e)
    {
      if (e != null)
      {
        this.FilterList.SetFilterAdd(new FilterItem(e.Fld, e.Value, "AND", e.Sign));

        if (this.FilterSplitContainer.Panel1Collapsed)
        {
          this.FilterSplitContainer.Panel1Collapsed = false;
          this.MainToolFilterView.Checked = !this.FilterSplitContainer.Panel1Collapsed;
        }

        if (Properties.Settings.Default.FindActive)
        {
          this.RefreshData();
        }
      }
    }

    private void ListGrid_FilterColumnEvent(object sender, FilterEventArgs e)
    {
      if ((e != null) && (e.Fld != null))
      {
        this.FindField.Text = e.Fld.Caption;
        this.FindField.Tag = e.Fld.Name;
        this.Action_Click(this.MainToolFilter, null);
      }
    }

    private void ListGrid_Action(object sender, EventArgs e)
    {
      if ((sender != null) && (sender is ToolStripMenuItem) && ((sender as ToolStripMenuItem).Tag != null) && ((sender as ToolStripMenuItem).Tag is ActionItem))
      {
        ActionItem fAction = ((sender as ToolStripMenuItem).Tag as ActionItem);
        if (!String.IsNullOrEmpty(fAction.MsgAsk))
        {
          String fMsgAsk = fAction.MsgAsk;

          foreach (KeyValuePair<string, object> fParam in this.FilterList.GetFilterParam())
          {
            fMsgAsk = fMsgAsk.Replace("{" + fParam.Key + "}", fParam.Value.ToString());
          }

          if (!Global.MsgShow(this, fMsgAsk, MessageBoxIcon.Question))
          {
            return;
          }
        }

        Dictionary<string, object> fParams = fParams = this.FilterList.GetFilterParam(); //Utils.GetAsParams(fAction.DataItem);
        fParams.Add("FormUID", this.UID);
        fParams.Add("GlobalUID", Global.GlobalUID);
        fParams = this.MenuItem.Session.GetParamSession(fParams);

        DatabaseItem.Result fResult = null;
        switch (fAction.ActionSql)
        {
          case "Insert":
            fResult = this.Frm.Service.GetResult(SqlAction.Insert, fParams);
            break;
          case "Update":
            fResult = fResult = this.Frm.Service.GetResult(SqlAction.Update, fParams);
            break;
          case "Delete":
            fResult = this.Frm.Service.GetResult(SqlAction.Delete, fParams);
            break;
          case "List":
            break;
          case "Detail":
            break;
          default:
            break;
        }

        if (fResult != null)
        {
          if (fResult.Status)
          {
            this.RefreshData();
            Global.MsgShow(this, fAction.MsgSuccess);
          }
          else
          {
            Global.MsgShow(this, fResult.Error.Message);
          }
        }
      }
    }

    private void ListGrid_CellAction(object sender, EventActionArgs e)
    {
      if ((e != null) && (e.Action != null))
      {
        if ((!String.IsNullOrEmpty(e.Action.MsgAsk)) && (!Global.MsgShow(this, e.Action.MsgAsk, MessageBoxIcon.Question)))
        {
          return;
        }
        Dictionary<string, object> fParams = Utils.GetAsParams(e.Action.DataItem);
        fParams = this.MenuItem.Session.GetParamSession(fParams);
        DatabaseItem.Result fResult = null;
        switch (e.Action.ActionSql)
        {
          case "Insert":
            fResult = this.Frm.Service.GetResult(SqlAction.Insert, fParams);
            break;
          case "Update":
            fResult = this.Frm.Service.GetResult(SqlAction.Update, fParams);
            break;
          case "Delete":
            fResult = this.Frm.Service.GetResult(SqlAction.Delete, fParams);
            break;
          case "List":
            break;
          case "Detail":
            break;
          default:
            break;
        }

        if (fResult != null)
        {
          if (fResult.Status)
          {
            this.RefreshData();
            Global.MsgShow(this, e.Action.MsgSuccess);
          }
          else
          {
            Global.MsgShow(this, fResult.Error.Message);
          }
        }
      }
    }

    private void ListGrid_CellOpen(object sender, EventArgs e)
    {
      this.Cursor = Cursors.AppStarting;
      switch (this.Frm.DetailView)
      {
        case "Simple":
          FormDetailSimple fFormDetailSimple = new FormDetailSimple();

          fFormDetailSimple.SetRow(this.ListGrid.GetSelRow(), this.Frm);
          Global.AddForm(fFormDetailSimple);
          if (this.Frm.DetailModal)
          {
            fFormDetailSimple.ShowDialog(this);
          }
          else
          {
            fFormDetailSimple.Show(this);
          }
          break;
        case "Custom":
          FormDetailComplex fFormDetailComplex = new FormDetailComplex();

          fFormDetailComplex.SetRow(this.ListGrid.GetSelRow(), this.Frm);
          Global.AddForm(fFormDetailComplex);
          if (this.Frm.DetailModal)
          {
            if (fFormDetailComplex.ShowDialog(this) == DialogResult.OK)
            {
              this.RefreshData();
            }
          }
          else
          {
            fFormDetailComplex.Show(this);
          }
          break;
      }
      var timer = new Timer();
      timer.Interval = 1200;
      timer.Tick += Action_Tick;
      timer.Start();
    }

    private void Action_Tick(object sender, EventArgs e)
    {
      this.Cursor = Cursors.Default;
      (sender as Timer).Stop();
      (sender as Timer).Dispose();
    }

    private void FormList_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.EventSend(this.Frm, "Close");
      if (Global.StartTypeIsMDI)
      {
        Global.RemoveForm(this);
      }
    }

    private void FindText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        this.Action_Click(this.MainToolFilter, e);
      }
    }

    private void FormList_Enter(object sender, EventArgs e)
    {
      if (Global.StartTypeIsMDI)
      {
        Global.FocusForm(this);
      }
    }

    private void FormList_Leave(object sender, EventArgs e)
    {
      if (Global.StartTypeIsMDI)
      {
        Global.FocusForm(this, false);
      }
    }

    #endregion Events

    #region Refresh

    private List<FilterItem> FilterLocal = null;
    private List<FilterItem> FilterServer = null;
    private Dictionary<string, object> FilterParam = null;

    private void RefreshData()
    {
      if (!this.MainBW.IsBusy)
      {
        this.FilterServer = this.FilterList.GetFilterServer();
        this.FilterParam = this.FilterList.GetFilterParam();
        this.FilterLocal = this.FilterList.GetFilterLocal();

        this.RefreshLastIndex = this.ListGrid.GetSelRowIndex();
        this.MainBW.RunWorkerAsync();
      }
      else
      {
        this.MainStatusLabel.Text = "Refresh working...";
        this.MainStatusState.Text = "Refreshing";
        ToolTip tt = new ToolTip();
        tt.Show("Refreshing 1 sec...", this.ListGrid, 1200);
      }
    }

    private void FilterDataLocal()
    {
      if (!this.FilterList.IsFilterParamSame())
      {
        this.RefreshData();
      }

      if (String.IsNullOrEmpty(this.FindText.Text))
      {
        this.ListGrid.ClearFind();
      }
      else
      {
        this.ListGrid.SetFind(this.FindText.Text, this.FindField.Tag);
      }
    }

    private void MainBW_DoWork(object sender, DoWorkEventArgs e)
    {
      this.RefreshCount++;
      this.MainBW.ReportProgress(0);

      if (this.Frm == null)
      {
        this.Frm = new FormItem(this.MenuItem.FormId, this.MenuItem.Session);
      }

      if (this.Frm != null && this.Frm.Service != null)
      {
        this.MainBW.ReportProgress(1);
        Dictionary<string, object> dict = this.MenuItem.Session.GetParamSession(this.FilterParam);
        dict.Add("FormUID", this.UID);
        dict.Add("GlobalUID", Global.GlobalUID);
        DatabaseItem.Result fResultTemp = this.Frm.Service.GetResult(SqlAction.Query, dict);
        if (fResultTemp.Status)
        {
          this.Data = fResultTemp.Data.Copy();
          this.MainBW.ReportProgress(2);
        }
        else
        {
          e.Result = fResultTemp.Error;
        }
      }
      else
      {
        //e.Result = fResult.Error;
        //MessageBox.Show(fResult.Error.Message);
      }
    }

    private void MainBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      switch (e.ProgressPercentage)
      {
        case 0:
          this.MainStatusLabel.Text = "Full data refresh started...";
          this.MainStatusState.Text = "Refreshing";
          this.MainToolRefresh.Image = Properties.Resources.loading;
          this.Cursor = System.Windows.Forms.Cursors.AppStarting;
          break;
        case 1:
          this.ListGrid.SetForm(this.Frm);
          this.FilterList.Set(this.Frm);
          this.FilterServer = this.FilterList.GetFilterServer();
          this.FilterParam = this.FilterList.GetFilterParam();
          this.FilterLocal = this.FilterList.GetFilterLocal();
          break;
        case 2:
          this.ListGrid.SetData(this.Data, this.FilterLocal);
          this.ListGrid.SetSelRowIndex(this.RefreshLastIndex);

          break;
      }
    }

    private void MainBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.MainStatusLabel.Text = "";
      this.MainStatusState.Text = "";
      this.MainToolRefresh.Image = Properties.Resources.refresh;
      this.Cursor = System.Windows.Forms.Cursors.Default;

      if (e.Result is Exception)
      {
        MessageBox.Show((e.Result as Exception).Message);
      }
      else
      {
        if (this.Frm.Service.HasLimit())
        {
          this.MainToolPagePrev.Enabled = (this.MainToolPageNmb.Text != "1");
          //this.MainToolPageNmb.Visible = fPaging;
          this.MainToolPageNext.Enabled = (10000 < this.ListGrid.GetRowsCount());
        }
      }
      //this.MainStatusStat.Text = String.Format("Count: {0}", this.Data.Tables[0].Rows.Count);
    }

    #endregion Refresh

    #region Actions

    private void Action_Click(object sender, EventArgs e)
    {
      #region Standard

      if (sender == this.MenuClose)
      {
        this.Close();
      }

      if ((sender == this.MainToolRefresh) || (sender == this.MainMenuRefresh) || (sender == this.FilterRefereshButton))
      {
        ToolTip tt = new ToolTip();
        tt.Show("Refreshing...", this.ListGrid, 1200);

        this.RefreshData();
      }

      if (sender == this.MainToolView || sender == this.MainToolViewManage)
      {
        using (FormFilter fFilter = new FormFilter(this.Frm, this.ListGrid, this.MainToolView.Text))
        {
          fFilter.StartPosition = FormStartPosition.CenterParent;
          if (fFilter.ShowDialog(this) == DialogResult.OK)
          {
            //this.Form = 
          }
        }
      }

      if (sender == this.MainMenuFilter)
      {
        this.SetFilterShowHide(true);
      }

      if (sender == this.MainManuColumnsShow)
      {
        using (FormListColumns fListColumns = new FormListColumns(this.Frm, this.ListGrid, this.MainToolView.Text))
        {
          if (fListColumns.ShowDialog(this) == DialogResult.OK)
          {
            this.ListGrid.SetColumns(fListColumns.ColumnsVisible);
          }
        }
      }

      #endregion Standard

      #region Filter & FilterLocal

      if (sender == this.MainToolFilter)
      {
        this.FilterDataLocal();
      }

      if (sender == this.FindText)
      {
        if (Properties.Settings.Default.FindActive)
        {
          if ((!String.IsNullOrEmpty(this.FindText.Text)) && (2 < this.FindText.Text.Length))
          {
            this.FilterDataLocal();
          }
          else
          {
            this.ListGrid.ClearFind();
          }
        }
      }

      if (sender == this.MainToolViewDefault)
      {
        MessageBox.Show("Default View Show!");
      }

      #endregion

      #region Menu List

      if (sender == this.MainMenuData)
      {
        for (int i = this.MainMenuData.DropDownItems.Count - 1; 0 <= i; i--)
        {
          if ((this.MainMenuData.DropDownItems[i].Tag != null) && (this.MainMenuData.DropDownItems[i].Tag is ActionItem))
          {
            this.MainMenuData.DropDownItems.RemoveAt(i);
          }
        }

        foreach (ActionItem fActionItem in this.Frm.GetListActions())
        {
          if (!fActionItem.ActionRow)
          {
            ToolStripMenuItem fMenuItem = new ToolStripMenuItem();
            fMenuItem.Text = fActionItem.Caption;
            fMenuItem.Tag = fActionItem;
            fMenuItem.Click += ListGrid_Action;
            this.MainMenuData.DropDownItems.Insert(0, fMenuItem);
          }
        }
      }

      #endregion

      if (sender == this.MainToolFilterView)
      {
        this.SetFilterShowHide(this.FilterSplitContainer.Panel1Collapsed);
      }

      if (sender == this.FilterClearButton)
      {
        this.FilterList.SetClear();
        if (Properties.Settings.Default.FindActive)
        {
          this.RefreshData();
        }
      }

      if (sender == this.MainToolFilterPaste)
      {
        this.FindText.Text = Clipboard.GetText();
        this.FindText.Focus();
        this.ListGrid.SetFind(this.FindText.Text);
      }

      if (sender == this.MainToolFilterClear)
      {
        this.FindText.Text = "";
        this.FindText.Focus();
        this.ListGrid.ClearFind();
      }

      if (sender == this.FindStripMenu)
      {
        this.FindText.Focus();
        this.FindText.SelectAll();
      }

      if (sender == this.MainToolFilterActive)
      {
        this.MainToolFilterActive.Checked = !this.MainToolFilterActive.Checked;
        Properties.Settings.Default.FindActive = this.MainToolFilterActive.Checked;
        Properties.Settings.Default.Save();
      }

      if (sender == this.StatusbarMenu)
      {
        this.StatusBar.Visible = !this.StatusBar.Visible;
      }

      if ((sender == this.MainToolPin) || (sender == this.MainMenuPin))
      {
        this.TopMost = !this.TopMost;
        this.MainMenuPin.Checked = this.TopMost;
        this.MainToolPin.Checked = this.TopMost;
      }

      if (sender == this.MainMenuView)
      {
        this.StatusbarMenu.Checked = this.StatusBar.Visible;
        this.MainMenuPin.Checked = this.TopMost;
        this.MainToolPin.Checked = this.TopMost;
      }

      if (sender == this.MenuHelp)
      {
        Global.HelpShow(this);
      }

      if (sender == this.MainMenuAdd)
      {
        this.ShowDetail(true);
      }

      if (sender == this.MainToolDataAdd)
      {
        this.ShowDetail(true);
      }

      if (sender == this.MainMenuEditor)
      {
        nte.editor.FormFormList fTest = new nte.editor.FormFormList(this.Frm.Id, Global.SessionDefault);
        if (fTest.ShowDialog(this) == DialogResult.OK)
        {
          this.Frm = new FormItem(this.Frm.Id, Global.SessionDefault);
          this.RefreshData();
          this.doDesign();
        }
      }

      #region Inport/Export

      if (sender == this.MainMenuImport)
      {
        using (FormListInport fInport = new FormListInport(this, this.Data.Tables[0], this.ListGrid))
        {
          fInport.ShowInport();
        }
      }

      if (sender == this.MainMenuExport)
      {
        using (FormListExport fExport = new FormListExport(this, this.Data.Tables[0], this.ListGrid))
        {
          fExport.ShowExport();
        }
      }

      if ((sender == this.MainMenuExcelOpen) || (sender == this.MainToolExcel))
      {
        try
        {
          Utils.SetEnable(false, this.MainMenuExcelOpen, this.MainToolExcel);

          using (FormListExport fExport = new FormListExport(this, this.Data.Tables[0], this.ListGrid))
          {

            //String fFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + this.Text + ".xls";
            String fFileName = Path.GetTempFileName() + ".xls";
            if (fExport.Export(fFileName, true))
            {
              Process.Start(fFileName);
            }
          }
        }
        catch (Exception ex)
        {
          Global.ShowEx(ex);
        }
        finally
        {
          Utils.SetEnable(true, this.MainMenuExcelOpen, this.MainToolExcel);
        }
      }

      #endregion Inport/Export

      #region Stat

      if (sender == this.MainStatusStatCopy)
      {
        this.StatusbarMenu.Checked = this.StatusBar.Visible;
        Clipboard.SetText(this.MainStatusStat.Text);
      }

      #endregion
    }

    private void MainStatusStat_Click(object sender, EventArgs e)
    {
      this.MainStatusStat.Tag = this.ListGrid.SetStatType((sender as ToolStripMenuItem).Tag);
    }

    private void MainStatusStat_ButtonClick(object sender, EventArgs e)
    {
      if ((sender is ToolStripMenuItem) && ((sender as ToolStripMenuItem).Tag != null))
      {
        this.MainStatusStat.Tag = this.ListGrid.SetStatType((sender as ToolStripMenuItem).Tag);
      }
    }

    private void MainToolFilter_DropDownOpening(object sender, EventArgs e)
    {
      this.MainToolFilterActive.Checked = Properties.Settings.Default.FindActive;
    }

    private void FindField_DropDownOpening(object sender, EventArgs e)
    {
      if (this.FindField.DropDownItems.Count == 2)
      {
        foreach (FieldItem fField in this.Frm.GetColumns())
        {
          ToolStripMenuItem fMenu = new ToolStripMenuItem();

          fMenu.Text = fField.Caption;
          fMenu.Tag = fField.Name;
          fMenu.Checked = (fMenu.Text == this.FindField.Text);
          fMenu.Click += FindFieldMenu_Click;

          this.FindField.DropDownItems.Add(fMenu);
        }
      }
      else
      {
        foreach (ToolStripItem fItem in this.FindField.DropDownItems)
        {
          if (fItem is ToolStripMenuItem)
          {
            (fItem as ToolStripMenuItem).Checked = (fItem.Text == this.FindField.Text);
          }
        }
      }
    }

    private void FindFieldMenu_Click(object sender, EventArgs e)
    {
      if ((sender != null) && (sender is ToolStripMenuItem) && ((sender as ToolStripMenuItem).Tag != null))
      {
        this.FindField.Text = (sender as ToolStripMenuItem).Text;
        this.FindField.Tag = (sender as ToolStripMenuItem).Tag.ToString();
        this.FindText.Focus();
        this.Action_Click(this.MainToolFilter, null);
      }
    }

    private void SetFilterShowHide(Boolean iVisible)
    {
      this.FilterSplitContainer.Panel1Collapsed = !iVisible;
      this.SetFilterShowHide();
    }

    private void SetFilterShowHide()
    {
      this.MainToolFilterView.Checked = !this.FilterSplitContainer.Panel1Collapsed;
    }

    #endregion Actions

  }
}
