using nte.erp.core;
using nte.erp.core.Export;
using nte.erp.core.Import;
using nte.erp.services.invoices.Classes;
using nte.erp.services.invoices.Properties;
using System.Data;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]
  public partial class FormEditor : Form
  {
    public string FileName = string.Empty;
    public bool IsChanged = false;
    public bool MyChange = false;
    private ExportTestData ExportTestData = new ExportTestData();
    private ImportItem? Import = null;
    private ExportItem? Export = null;
    private ExportSourceMap? SelectExportMap = null;
    public FormEditor()
    {
      InitializeComponent();
      this.Action_Refresh();
    }
    public FormEditor(string iFileName)
    {
      InitializeComponent();
      if (File.Exists(iFileName))
      {
        if (Utils.LoadExport(iFileName, out ExportItem fExportTmp))
        {
          this.Wait();
          fExportTmp.LoadAt = DateTime.Now;
          this.FileName = iFileName;
          this.Import = null;
          this.Export = fExportTmp;
          Utils.Config.SetRecent(this.FileName);
          this.Wait(true);
        }
      }
      this.Action_Refresh();
    }

    #region Actions
    private void Action_Refresh()
    {
      this.MyChange = true;

      if (this.Export is null && this.Import is null)
      {
        this.Text = "Editor";
        this.Tabs.TabPages.Clear();
        this.Tabs.TabPages.Add(this.tpHome);

        this.GetRecent(0, this.HomeFileRecent0);
        this.GetRecent(1, this.HomeFileRecent1);
        this.GetRecent(2, this.HomeFileRecent2);
        this.GetRecent(3, this.HomeFileRecent3);
        this.GetRecent(4, this.HomeFileRecent4);
      }

      if (this.Export is not null)
      {
        #region General
        if (this.Export.Name == "Export Untitled")
        {
          this.Text = String.Format("New Export - Editor");
        }
        else
        {
          this.Text = String.Format("{0} Export - Editor", this.Export.Name);
        }
        if (this.IsChanged)
        {
          this.Text = "*" + this.Text;
        }
        this.ExportName.Text = this.Export.Name;
        this.ExportDescription.Text = this.Export.Description;
        this.ExportKind.Text = "Export";
        this.ExportFileNameLabel.Visible = (!string.IsNullOrEmpty(this.FileName));
        this.ExportFileName.Text = this.FileName;
        this.ExportFileName.Visible = (!string.IsNullOrEmpty(this.FileName));
        this.ExportCreatedText.Text = this.Export.CreateBy.ToString() + " At " + this.Export.CreateAt.ToString();
        this.ExportChangeText.Text = this.Export.ChangeBy.ToString() + " On " + this.Export.ChangeOn.ToString() + " At " + this.Export.ChangeAt.ToString() + " Version " + this.Export.ChangeRev.ToString();
        #endregion

        #region Source
        this.ExportSourceName.Text = this.Export.Source.Name;
        this.ExportSourceKind.Text = this.Export.Source.Kind.ToString();
        this.ExportSourceTestFileName.Text = this.Export.Source.TestFileName;
        this.ExportSourceConnectionStr.Text = this.Export.Source.ConnectionStr;
        this.ExportSourceListQuery.Text = this.Export.Source.ListQuery;
        this.ExportSourceMainQuery.Text = this.Export.Source.MainQuery.Replace("\n", Environment.NewLine);

        this.Action_RefreshControl(this.ExportSourceMaps);
        #endregion

        #region Send To
        this.ExportSendName.Text = this.Export.Send.Name;
        this.ExportSendProvider.Text = this.Export.Send.Provider.ToString();
        this.ExportSendFileLocation.Text = this.Export.Send.FileLocation;
        this.ExportSendMRURI.Text = this.Export.Send.MRURI;
        this.ExportSendMRUsername.Text = this.Export.Send.MRUsername;
        this.ExportSendMRPassword.Text = this.Export.Send.MRPassword;
        this.ExportSendMRCompanyID.Text = this.Export.Send.MRCompanyID;
        this.ExportSendMRSoftwareID.Text = this.Export.Send.MRSoftwareID;
        #endregion

        this.Tabs.TabPages.Clear();
        this.Tabs.TabPages.Add(this.tpExportGeneral);
        this.Tabs.TabPages.Add(this.tpExportSource);
        this.Tabs.TabPages.Add(this.tpExportShema);
        this.Tabs.TabPages.Add(this.tpExportSend);
      }

      if (this.Import is not null)
      {
        //this.controlImportGeneral1.Import = this.Import;

        this.Tabs.TabPages.Clear();
        this.Tabs.TabPages.Add(this.tpImportGeneral);
        this.Tabs.TabPages.Add(this.tpImportSource);
        this.Tabs.TabPages.Add(this.tpImportTarget);
        this.Tabs.TabPages.Add(this.tpImportResult);
      }

      this.MyChange = false;
    }
    private void Action_Refresh(bool iSilente)
    {
      if (this.Export is not null)
      {
        if (this.Export.Name == "Export Untitled")
        {
          this.Text = String.Format("New Export - Editor");
        }
        else
        {
          this.Text = String.Format("{0} Export - Editor", this.Export.Name);
        }
        if (this.IsChanged)
        {
          this.Text = "*" + this.Text;
        }

        this.ExportCreatedText.Text = this.Export.CreateBy.ToString() + " At " + this.Export.CreateAt.ToString();
        this.ExportChangeText.Text = this.Export.ChangeBy.ToString() + " On " + this.Export.ChangeOn.ToString() + " At " + this.Export.ChangeAt.ToString() + " Version " + this.Export.ChangeRev.ToString();
        this.ExportFileNameLabel.Visible = (!string.IsNullOrEmpty(this.FileName));
        this.ExportFileName.Text = this.FileName;
        this.ExportFileName.Visible = (!string.IsNullOrEmpty(this.FileName));

        if (!iSilente)
        {
          this.ExportName.Text = this.Export.Name;
          this.ExportDescription.Text = this.Export.Description;
          this.Action_RefreshControl(this.ExportSourceMaps);
        }
      }
    }
    private void Action_RefreshControl(Control sender)
    {
      if (sender == this.ExportSourceMaps && this.Export is not null)
      {
        this.ExportSourceMaps.BeginUpdate();
        this.ExportSourceMaps.Items.Clear();
        foreach (ExportSourceMap fMap in this.Export.Maps)
        {
          ListViewItem fItem = new ListViewItem();
          fItem.Tag = fMap;
          fItem.Text = fMap.Name;
          fItem.SubItems.Add(fMap.Filter);
          fItem.SubItems.Add(fMap.Query);
          this.ExportSourceMaps.Items.Add(fItem);
        }
        this.ExportSourceMaps.EndUpdate();
      }

      if (sender == this.ExportShemaStrip && this.Export is not null)
      {
        for (int i = this.ExportShemaTable.DropDownItems.Count - 1; 1 < i; i--)
        {
          this.ExportShemaTable.DropDownItems.RemoveAt(i);
        }
        foreach (ExportSourceMap fMap in this.Export.Maps)
        {
          ToolStripMenuItem fItem = new ToolStripMenuItem();
          fItem.Text = fMap.Name;
          fItem.Tag = fMap;
          fItem.Click += ExportShemaTable_Click;
          this.ExportShemaTable.DropDownItems.Add(fItem);
        }
      }

      if (sender == this.tpExportSend)
      {
        #region Source
        this.ExportSourceName.Text = this.Export.Source.Name;
        this.ExportSourceKind.Text = this.Export.Source.Kind.ToString();
        this.ExportSourceTestFileName.Text = this.Export.Source.TestFileName;
        this.ExportSourceConnectionStr.Text = this.Export.Source.ConnectionStr;
        this.ExportSourceListQuery.Text = this.Export.Source.ListQuery;
        this.ExportSourceMainQuery.Text = this.Export.Source.MainQuery.Replace("\n", Environment.NewLine);
        #endregion
      }
    }
    private void Action_RefreshShema(ExportSourceMap? iMap = null)
    {
      this.MyChange = true;
      if (iMap is not null)
      {
        this.SelectExportMap = iMap;
      }
      if (this.SelectExportMap is null)
      {
        if (this.Export is not null && 0 == this.Export.Maps.Count)
        {
          ExportSourceMap fMaster = new ExportSourceMap();
          fMaster.Name = "Master";
          this.Export.Maps.Add(fMaster);
        }
        if (this.Export is not null && 0 < this.Export.Maps.Count)
        {
          this.SelectExportMap = this.Export.Maps[0];
        }
      }
      if (this.SelectExportMap is not null)
      {
        this.ExportShemaTable.Text = this.SelectExportMap.Name;
        this.ExportShemaMainTemplate.Text = this.SelectExportMap.Shema.TemplateMain;
        this.ExportShemaFields.AutoGenerateColumns = false;
        this.SelectExportMap.Shema.TableLoad();
        this.ExportShemaFields.DataSource = this.SelectExportMap.Shema.TableFields;
      }
      this.MyChange = false;
    }
    private void Action_Click(object sender, EventArgs e)
    {
      try
      {
        #region File Menu
        if (sender == this.MenuFile)
        {
          this.MenuFileSave.Enabled = !(this.Export == null && this.Import == null);
          this.MenuFileSaveAs.Enabled = !(this.Export == null && this.Import == null);
        }

        if (sender == this.MenuFileNewExport || sender == this.HomeFileNewExport)
        {
          this.FileName = string.Empty;
          this.ExportTestData = new ExportTestData();
          this.Import = null;
          this.Export = new ExportItem("Export Untitled");
          this.IsChanged = true;
          this.Action_Refresh();
        }

        if (sender == this.MenuFileNewInport || sender == this.HomeFileNewInport)
        {
          this.FileName = string.Empty;
          this.ExportTestData = new ExportTestData();
          this.Import = new ImportItem("Import Untitled");
          this.Export = null;
          this.Action_Refresh();
        }

        if (sender == this.MenuFileOpen || sender == this.HomeFileOpen)
        {
          if (this.openFileDialog.ShowDialog() == DialogResult.OK)
          {
            if (Utils.LoadFile(this.openFileDialog.FileName, out this.Export, out this.Import))
            {
              this.Wait();
              this.FileName = this.openFileDialog.FileName;
              if (this.Export is not null)
              {
                Utils.LoadTestData(this.Export, out this.ExportTestData);
              }
              else
              {
                this.ExportTestData = new ExportTestData();
              }

              Utils.Config.SetRecent(this.FileName);
              this.Action_Refresh();
              this.Wait(true);
            }
            /*ExportItem fExportTmp = new ExportItem();
            if (Utils.LoadExport(this.openFileDialog.FileName, out fExportTmp))
            {
              this.Wait();
              fExportTmp.LoadAt = DateTime.Now;
              this.FileName = this.openFileDialog.FileName;
              this.Import = null;
              this.Export = fExportTmp;
              Utils.LoadTestData(this.Export, out this.ExportTestData);
              Utils.Config.SetRecent(this.FileName);
              this.Action_Refresh();
              this.Wait(true);
            }*/
          }
        }

        if (sender == this.MenuFileSave || sender == this.MenuFileSaveAs)
        {
          if (this.Export is not null)
          {
            if (string.IsNullOrEmpty(this.FileName) || sender == this.MenuFileSaveAs)
            {
              this.saveFileDialog.FileName = string.IsNullOrEmpty(this.FileName) ? this.ExportName.Text : this.FileName;
              if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
              {
                this.Wait();
                this.Action_Update(true);
                Utils.SaveExport(this.Export, this.saveFileDialog.FileName);
                this.IsChanged = false;
                this.FileName = this.saveFileDialog.FileName;
                Utils.Config.SetRecent(this.FileName);
                this.Action_Refresh(true);
                this.Wait(true);
              }
            }
            else
            {
              this.Action_Update(true);
              Utils.SaveExport(this.Export, this.FileName);
              this.IsChanged = false;
              this.Action_Refresh(true);
            }
          }
        }

        if (sender == this.MenuClose)
        {
          this.Close();
        }
        #endregion

        #region Export

        #region Source
        if (sender == this.ExportSourceTestFileNameOpen && this.Export is not null)
        {
          if (this.openFileDialog.ShowDialog() == DialogResult.OK)
          {
            this.ExportSourceTestFileName.Text = this.openFileDialog.FileName;
          }
        }
        if (sender == this.ExportSourceConnectionStrTest && this.Export is not null)
        {
          this.Export.Source.ConnectionStr = this.ExportSourceConnectionStr.Text;
          this.Export.Source.MainQuery = this.ExportSourceMainQuery.Text;

          using (FormEditorSourceTest fForm = new FormEditorSourceTest(this.Export))
          {
            fForm.ShowDialog();
            Utils.LoadTestData(this.Export, out this.ExportTestData.Data);
          }
        }
        if (sender == this.ExportSourceMainQueryTest && this.Export is not null)
        {
          this.Export.Source.ConnectionStr = this.ExportSourceConnectionStr.Text;
          this.Export.Source.MainQuery = this.ExportSourceMainQuery.Text;

          using (FormEditorSourceTest fForm = new FormEditorSourceTest(this.Export, true))
          {
            if (fForm.ShowDialog() == DialogResult.OK)
            {
              Utils.LoadTestData(this.Export, out this.ExportTestData);
            }
          }
        }
        if (sender == this.ExportSourceMapsOpenStrip && this.Export is not null)
        {
          if ((0 < this.ExportSourceMaps.SelectedItems.Count) && (this.ExportSourceMaps.SelectedItems[0].Tag != null) && (this.ExportSourceMaps.SelectedItems[0].Tag is ExportSourceMap))
          {
            ExportSourceMap fMap = this.ExportSourceMaps.SelectedItems[0].Tag as ExportSourceMap;
            this.Action_RefreshShema(fMap);
          }
        }
        if (sender == this.ExportSourceMapsAddStrip && this.Export is not null)
        {
          using (FormEditorExportSourceMap fMapForm = new FormEditorExportSourceMap(this.ExportTestData.Data))
          {
            if (fMapForm.ShowDialog() == DialogResult.OK)
            {
              this.Export.Maps.Add(fMapForm.Map);
              this.SetChange();
              this.Action_RefreshControl(this.ExportSourceMaps);
            }
          }
        }
        if (sender == this.ExportSourceMapsChangeStrip && this.Export is not null)
        {
          if ((0 < this.ExportSourceMaps.SelectedItems.Count) && (this.ExportSourceMaps.SelectedItems[0].Tag != null) && (this.ExportSourceMaps.SelectedItems[0].Tag is ExportSourceMap))
          {
            using (FormEditorExportSourceMap fMapForm = new FormEditorExportSourceMap(this.ExportSourceMaps.SelectedItems[0].Tag as ExportSourceMap, this.ExportTestData.Data))
            {
              if (fMapForm.ShowDialog() == DialogResult.OK)
              {
                for (int i = 0; i < this.Export.Maps.Count; i++)
                {
                  if (this.Export.Maps[i].Name == fMapForm.Map.Name)
                  {
                    this.Export.Maps[i] = fMapForm.Map;
                  }
                }
                this.ExportSourceMaps.SelectedItems[0].Tag = fMapForm.Map;
                this.ExportSourceMaps.SelectedItems[0].Text = fMapForm.Map.Name;
                this.ExportSourceMaps.SelectedItems[0].SubItems[1].Text = fMapForm.Map.Filter;
                this.ExportSourceMaps.SelectedItems[0].SubItems[2].Text = fMapForm.Map.Query;
                this.SetChange();
              }
            }
          }
        }
        if (sender == this.ExportSourceMapsRemoveStrip && this.Export is not null)
        {
          if (0 < this.ExportSourceMaps.SelectedItems.Count)
          {
            if ((this.ExportSourceMaps.SelectedItems[0].Tag is not null) && (this.ExportSourceMaps.SelectedItems[0].Tag is ExportSourceMap))
            {
              ExportSourceMap fMap = (this.ExportSourceMaps.SelectedItems[0].Tag as ExportSourceMap);
              if (fMap != null && fMap.Name != "Master")
              {
                this.Export.Maps.Remove(fMap);
                this.SetChange();
                this.Action_RefreshControl(this.ExportSourceMaps);
              }
            }
          }
        }
        if (sender == this.ExportSourceManage)
        {
          this.Action_Update();
          using (FormEditorSourceManage fForm = new FormEditorSourceManage(this.Export.Source))
          {
            if (fForm.ShowDialog(this) == DialogResult.OK)
            {
              this.SetChange();
              this.Action_RefreshControl(this.tpExportSend);
            }
          }
        }
        #endregion

        #region Transform/Shema
        if (sender == this.ExportShemaProccessorDynamicFields)
        {
          this.ExportShemaProccessor.Text = this.ExportShemaProccessorDynamicFields.Text;
          if (this.SelectExportMap is not null)
          {
            this.SelectExportMap.Shema.Proccessor = this.SelectExportMap.Shema.GetProccessor(this.ExportShemaProccessor.Text);
          }
        }
        if (sender == this.ExportShemaProccessorDynamic)
        {
          this.ExportShemaProccessor.Text = this.ExportShemaProccessorDynamic.Text;
          if (this.SelectExportMap is not null)
          {
            this.SelectExportMap.Shema.Proccessor = this.SelectExportMap.Shema.GetProccessor(this.ExportShemaProccessor.Text);
          }
        }
        if (sender == this.ExportShemaProccessorFields)
        {
          this.ExportShemaProccessor.Text = this.ExportShemaProccessorFields.Text;
          if (this.SelectExportMap is not null)
          {
            this.SelectExportMap.Shema.Proccessor = this.SelectExportMap.Shema.GetProccessor(this.ExportShemaProccessor.Text);
          }
        }
        if (sender == this.ExportShemaRefresh && this.Export is not null && this.SelectExportMap is not null)
        {
          this.Export.Source.Update(this.ExportSourceName.Text, this.ExportSourceKind.Text, this.ExportSourceTestFileName.Text, "15", this.ExportSourceConnectionStr.Text, this.ExportSourceListQuery.Text, this.ExportSourceMainQuery.Text);
          this.SelectExportMap.Shema.UpdateFields();
          using (FormEditorTransformRefresh fRefresh = new FormEditorTransformRefresh(this.Export, this.SelectExportMap))
          {
            if (fRefresh.ShowDialog(this) == DialogResult.OK)
            {
              this.IsChanged = true;
            }
          }
        }
        if (sender == this.ExportShemaFieldAdd && this.Export is not null && this.SelectExportMap is not null)
        {
          DataRow fField = this.SelectExportMap.Shema.TableFields.NewRow();

          fField["Name"] = string.Empty;
          fField["SourceName"] = string.Empty;
          fField["ConvertTo"] = "Implicit";
          fField["ConvertError"] = "Stop";
          fField["IfEmpty"] = "Ignore";
          fField["DefaultValue"] = string.Empty;

          this.SelectExportMap.Shema.TableFields.Rows.Add(fField);
          this.SetChange();
        }
        if (sender == this.ExportShemaFieldDelete && this.Export is not null && this.SelectExportMap is not null)
        {
          if (this.ExportShemaFields.SelectedCells.Count > 0)
          {
            int fRowIndex = this.ExportShemaFields.SelectedCells[0].RowIndex;
            this.ExportShemaFields.Rows.RemoveAt(fRowIndex);
            this.SelectExportMap.Shema.UpdateFields();
            this.SetChange();
          }
        }
        if (sender == this.ExportShemaFieldDeleteAll && this.Export is not null && this.SelectExportMap is not null)
        {
          this.SelectExportMap.Shema.Fields.Clear();
          this.SelectExportMap.Shema.TableFields.Rows.Clear();
          this.SetChange();
        }
        if ((sender == this.ExportShemaTest || sender == this.ExportShemaTemplatesMainTest) && this.Export is not null)
        {
          DataSet fTestData = new DataSet();
          string fFileTestXml = Path.GetTempPath() + "nteracun-export-test.xml";
          if (File.Exists(fFileTestXml))
          {
            fTestData.ReadXml(fFileTestXml);

            using (ShemaModule fConvert = new ShemaModule())
            {
              if (fConvert.LoadData(fTestData, this.Export, out string fError))
              {
                string fTempViewFile = Path.GetTempFileName() + ".xml";
                File.WriteAllText(fTempViewFile, fConvert.Body);
                Process.Start(new ProcessStartInfo(fTempViewFile) { UseShellExecute = true });
              }
            }
          }
        }
        if (sender == this.ExportShemaTestRefreshData && this.Export is not null)
        {

        }
        #endregion

        #region Transform/Template   
        if ((sender == this.ExportShemaTable) && (this.Export is not null))
        {
          this.Action_RefreshControl(this.ExportShemaStrip);
        }
        if (sender == this.ExportShemaTemplatesMainViewXML && this.Export is not null && this.SelectExportMap is not null)
        {
          string fTempViewFile = Path.GetTempFileName() + ".xml";
          File.WriteAllText(fTempViewFile, this.ExportShemaMainTemplate.Text);
          Process.Start(new ProcessStartInfo(fTempViewFile) { UseShellExecute = true });
        }
        if (sender == this.ExportShemaTemplatesMainLoad && this.Export is not null && this.SelectExportMap is not null)
        {
          if (this.openTemplateDialog.ShowDialog() == DialogResult.OK)
          {
            this.ExportShemaMainTemplate.Text = File.ReadAllText(this.openTemplateDialog.FileName);
            this.SelectExportMap.Shema.TemplateMain = this.ExportShemaMainTemplate.Text;
            this.SetChange();
          }
        }
        if (sender == this.ExportShemaTemplatesMainDefault && this.Export is not null && this.SelectExportMap is not null)
        {
          this.ExportShemaMainTemplate.Text = Resources.TemplateMain;
          this.SelectExportMap.Shema.TemplateMain = this.ExportShemaMainTemplate.Text;
          this.SetChange();
        }
        if (sender == this.ExportShemaTemplatesItemsDefault && this.Export is not null && this.SelectExportMap is not null)
        {
          this.ExportShemaMainTemplate.Text = Resources.TemplateItems;
          this.SelectExportMap.Shema.TemplateMain = this.ExportShemaMainTemplate.Text;
          this.SetChange();
        }
        if (sender == this.ExportShemaTemplatesTaxesDefault && this.Export is not null && this.SelectExportMap is not null)
        {
          this.ExportShemaMainTemplate.Text = Resources.TemplateTaxes;
          this.SelectExportMap.Shema.TemplateMain = this.ExportShemaMainTemplate.Text;
          this.SetChange();
        }
        /*if (sender == this.ExportShemaPreviewRefresh)
        {
          if (this.Export != null)
          {
            //this.ItemWorker.ReportProgress(25, "Connecting to source....");
            string fError;
            using (SourceDB fDB = new SourceDB())
            {
              //this.ItemWorker.ReportProgress(25, string.Format("Loading from {0}...", this.ExportItem.Source.Name));
              if (this.Export != null && fDB.LoadData(this.Export.Source.TestID, this.Export.Source, out fError))
              {
                //this.ItemWorker.ReportProgress(50, "Transforming....");
                using (ConvertXml fConvert = new ConvertXml())
                {
                  if (fConvert.LoadData(fDB.DataSet, this.Export.Maps[0].Shema, out fError))
                  {
                    string fFileTmp = Path.GetTempFileName();
                    File.WriteAllText(fFileTmp, fConvert.Body);

                    //webView21.EnsureCoreWebView2Async();
                    //this.ItemWorker.ReportProgress(75, string.Format("Sending to {0}....", this.ExportItem.Send.Name));
                    //webView21.CoreWebView2.Navigate(fFileTmp);
                  }
                }
              }
            }
          }
        }*/
        #endregion

        #region Send
        if (sender == this.ExportSendManage)
        {
          using (FormEditorSendManage fForm = new FormEditorSendManage())
          {
            if (fForm.ShowDialog(this) == DialogResult.OK)
            {

            }
          }
        }
        if (sender == this.SendMRTestFile)
        {
          if (this.openFileDialog.ShowDialog() == DialogResult.OK)
          {
            if (!this.SendMRTestWorker.IsBusy)
            {
              this.Wait();
              this.SendMRTestFile.Enabled = false;
              this.SendMRTestID.Enabled = false;
              this.SendMRLog.Clear();

              Utils.IsDebug = this.SendMRTestDebug.Checked;
              Utils.ReportWorker = (Utils.IsDebug) ? this.SendMRTestWorker : null;

              this.SendMRTestWorker.RunWorkerAsync(this.openFileDialog.FileName);
            }
          }
        }
        if (sender == this.SendMRTestID)
        {
          if (!this.SendMRTestWorker.IsBusy)
          {
            this.Wait();
            this.SendMRTestFile.Enabled = false;
            this.SendMRTestID.Enabled = false;
            this.SendMRLog.Clear();

            Utils.IsDebug = this.SendMRTestDebug.Checked;
            Utils.ReportWorker = (Utils.IsDebug) ? this.SendMRTestWorker : null;

            this.SendMRTestWorker.RunWorkerAsync();
          }
        }
        #endregion

        #endregion
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void Action_DoubleClick(object sender, EventArgs e)
    {
      #region Source
      if ((0 < this.ExportSourceMaps.SelectedItems.Count) && (this.ExportSourceMaps.SelectedItems[0].Tag != null) && (this.ExportSourceMaps.SelectedItems[0].Tag is ExportSourceMap) && (this.Export is not null))
      {
        using (FormEditorExportSourceMap fMapForm = new FormEditorExportSourceMap(this.ExportSourceMaps.SelectedItems[0].Tag as ExportSourceMap, this.ExportTestData.Data))
        {
          if (fMapForm.ShowDialog() == DialogResult.OK)
          {
            for (int i = 0; i < this.Export.Maps.Count; i++)
            {
              if (this.Export.Maps[i].Name == fMapForm.Map.Name)
              {
                this.Export.Maps[i] = fMapForm.Map;
              }
            }
            this.ExportSourceMaps.SelectedItems[0].Tag = fMapForm.Map;
            this.ExportSourceMaps.SelectedItems[0].Text = fMapForm.Map.Name;
            this.ExportSourceMaps.SelectedItems[0].SubItems[1].Text = fMapForm.Map.Filter;
            this.ExportSourceMaps.SelectedItems[0].SubItems[2].Text = fMapForm.Map.Query;
          }
        }
      }
      #endregion
    }
    private void Action_ClickRecent(object sender, EventArgs e)
    {
      if ((sender is not null) && (sender is LinkLabel) && ((sender as LinkLabel).Tag is not null))
      {
        string fFileName = (sender as LinkLabel).Tag.ToString();
        if (File.Exists(fFileName))
        {
          if (Utils.LoadFile(fFileName, out this.Export, out this.Import))
          {
            this.FileName = fFileName;
            Utils.Config.SetRecent(this.FileName);

            if (this.Export is not null)
            {
              Utils.LoadTestData(this.Export, out this.ExportTestData);
            }
            else
            {
              this.ExportTestData = new ExportTestData();
            }
            this.IsChanged = false;
            this.Action_Refresh();
          }
        }
        else
        {
          MessageBox.Show(string.Format("File {0} do not exists!", fFileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
    private void Action_Update(bool iForSave = false)
    {
      if (this.Export is not null)
      {
        this.Export.Update(this.ExportName.Text, this.ExportDescription.Text);
        this.Export.Source.Update(this.ExportSourceName.Text, this.ExportSourceKind.Text,
          this.ExportSourceTestFileName.Text,
          "15", this.ExportSourceConnectionStr.Text, this.ExportSourceListQuery.Text, this.ExportSourceMainQuery.Text
        );
        if (this.SelectExportMap is not null)
        {
          this.SelectExportMap.Shema.Update(this.SelectExportMap.Name, this.ExportShemaProccessor.Text, this.ExportShemaMainTemplate.Text);
          this.SelectExportMap.Shema.UpdateFields();
        }
        this.Export.Send.Update(this.ExportSendName.Text, this.ExportSendProvider.Text,
          this.ExportSendFileLocation.Text,
          this.ExportSendSEFURI.Text, this.ExportSendSEFApiKey.Text,
          this.ExportSendMRURI.Text, this.ExportSendMRUsername.Text, this.ExportSendMRPassword.Text, this.ExportSendMRCompanyID.Text, this.ExportSendMRSoftwareID.Text
        );

        if (iForSave)
        {
          this.Export.UpdateSave();
        }
      }
    }
    private void ExportShemaTable_Click(object sender, EventArgs e)
    {
      if (sender != null && sender is ToolStripMenuItem && (sender as ToolStripMenuItem).Tag is not null)
      {
        if (this.SelectExportMap is not null)
        {
          this.SelectExportMap.Shema.Update(this.SelectExportMap.Name, this.ExportShemaProccessor.Text, this.ExportShemaMainTemplate.Text);
          this.SelectExportMap.Shema.UpdateFields();
        }
        this.Action_RefreshShema((sender as ToolStripMenuItem).Tag as ExportSourceMap);
      }
      if (sender != null && sender is ToolStripMenuItem && (sender as ToolStripMenuItem).Text == "(change)")
      {
        if (this.Export is not null && this.SelectExportMap is not null)
        {
          //this.Action_RefreshShema(this.Export.Maps[0]);
          using (FormEditorExportSourceMap fMapForm = new FormEditorExportSourceMap(this.SelectExportMap, this.ExportTestData.Data))
          {
            if (fMapForm.ShowDialog() == DialogResult.OK)
            {
              this.SelectExportMap = fMapForm.Map;
            }
          }
        }
      }
    }
    #endregion

    #region Functions
    private void SetChange(int iInc = 0)
    {
      if (!this.MyChange)
      {
        this.IsChanged = true;

        if (!this.Text.StartsWith("*"))
        {
          this.Text = "*" + this.Text;
        }
      }
    }
    private void Wait(bool iStop = false)
    {
      this.Cursor = (iStop) ? Cursors.Default : Cursors.WaitCursor;
      this.Refresh();
      Application.DoEvents();
    }
    private void GetRecent(int iIndex, LinkLabel iLabel)
    {
      if (iLabel is not null)
      {
        if (0 <= iIndex && iIndex < Utils.Config.Recent.Count)
        {
          iLabel.Text = string.Format("{0} | {1}", Path.GetFileNameWithoutExtension(Utils.Config.Recent[iIndex]), Utils.Config.Recent[iIndex]);
          iLabel.Tag = Utils.Config.Recent[iIndex];
        }
        else
        {
          iLabel.Text = string.Empty;
          iLabel.Tag = null;
        }
      }
    }
    #endregion

    #region Events
    private void ExportSendProvider_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.ExportSendProvider.Text)
      {
        case "File":
          this.SendToFilePanel.Visible = true;
          this.SendToSEFPanel.Visible = false;
          this.SendToMRPanel.Visible = false;
          break;
        case "SEF":
          this.SendToFilePanel.Visible = false;
          this.SendToSEFPanel.Visible = true;
          this.SendToMRPanel.Visible = false;
          break;
        case "MojeRacun":
          this.SendToFilePanel.Visible = false;
          this.SendToSEFPanel.Visible = false;
          this.SendToMRPanel.Visible = true;
          break;
        default:
          this.SendToFilePanel.Visible = false;
          this.SendToSEFPanel.Visible = false;
          this.SendToMRPanel.Visible = false;
          break;
      }
    }
    private void ExportSourceKind_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (this.ExportSourceKind.Text)
      {
        case "Test":
          this.SourceKindTest.Visible = true;
          this.SourceKindMsSql.Visible = false;
          this.ExportSourceMapsPanel.Visible = true;
          break;
        case "MsSql":
          this.SourceKindTest.Visible = false;
          this.SourceKindMsSql.Visible = true;
          this.ExportSourceMapsPanel.Visible = true;
          break;
        default:
          this.SourceKindTest.Visible = false;
          this.SourceKindMsSql.Visible = false;
          this.ExportSourceMapsPanel.Visible = false;
          break;
      }
    }
    private void Tabs_Selecting(object sender, TabControlCancelEventArgs e)
    {
      if ((e.TabPage is not null) && (e.TabPage == this.tpExportShema))
      {
        this.Action_RefreshShema();
      }
      if (e.TabPage is not null && e.TabPage == this.tpExportSend && this.Export is not null)
      {
        this.SendMRTestID.Visible = !string.IsNullOrEmpty(this.Export.Source.TestID);
      }
    }
    private void ExportSourceMapsMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
      bool fHasSel = this.ExportSourceMaps.SelectedItems.Count > 0;

      this.ExportSourceMapsOpenStrip.Enabled = fHasSel;
      this.ExportSourceMapsChangeStrip.Enabled = fHasSel;
      if (fHasSel)
      {
        this.ExportSourceMapsRemoveStrip.Enabled = (this.ExportSourceMaps.SelectedItems[0].Text != "Master");
      }
      else
      {
        this.ExportSourceMapsRemoveStrip.Enabled = fHasSel;
      }

    }
    private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        if (this.IsChanged)
        {
          DialogResult fRespons = MessageBox.Show("Save Changes?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
          switch (fRespons)
          {
            case DialogResult.Yes:
              if (this.Export is not null)
              {
                if (!File.Exists(this.FileName))
                {
                  this.saveFileDialog.FileName = string.IsNullOrEmpty(this.FileName) ? this.ExportName.Text : this.FileName;
                  if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                  {
                    this.FileName = this.saveFileDialog.FileName;
                  }
                  else
                  {
                    e.Cancel = true;

                    return;
                  }
                }
                this.Action_Update(true);
                Utils.SaveExport(this.Export, this.FileName);
                this.IsChanged = false;
              }
              break;
            case DialogResult.Cancel:
              e.Cancel = true;
              break;
            case DialogResult.No:
              break;
          }
        }
      }
    }
    private void ExportData_Changed(object sender, EventArgs e)
    {
      if (sender == this.ExportShemaMainTemplate)
      {
        if ((this.SelectExportMap is not null) && (!this.MyChange))
        {
          this.SelectExportMap.Shema.TemplateMain = this.ExportShemaMainTemplate.Text;
        }
      }

      this.SetChange();
    }
    #endregion Events

    #region Workers
    private void SendMRTestWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      if (this.Export is not null)
      {
        this.SendMRTestWorker.ReportProgress(0, "Starting...");
        DataSet fData = null;
        string fDataStr = string.Empty;

        if (e.Argument is not null)
        {
          string fFileName = e.Argument.ToString();
          this.SendMRTestWorker.ReportProgress(0, string.Format("Loading from {0}...", fFileName));
          fData = new DataSet();
          fData.ReadXml(fFileName);
          this.SendMRTestWorker.ReportProgress(1, "DONE");
        }
        else
        {
          if (string.IsNullOrEmpty(this.Export.Source.TestID))
          {
            this.SendMRTestWorker.ReportProgress(0, "Error: NO TEST ID!");
          }
          else
          {
            this.SendMRTestWorker.ReportProgress(0, string.Format("Loading Test ID: {0}...", this.Export.Source.TestID));
            using (SourceModule fSource = new SourceModule())
            {
              if (fSource.LoadData(this.Export.Source.TestID, this.Export, out string oError))
              {
                fData = fSource.DataSet;
                this.SendMRTestWorker.ReportProgress(1, "DONE");
              }
              else
              {
                this.SendMRTestWorker.ReportProgress(1, string.Format("Error: {0}", oError));
              }
            }
          }
        }

        this.SendMRTestWorker.ReportProgress(0, "Transforming...");
        if (fData is not null)
        {
          using (ShemaModule fConvert = new ShemaModule())
          {
            if (fConvert.LoadData(fData, this.Export, out string oError))
            {
              fDataStr = fConvert.Body;
              string fTmpFile = Path.GetTempFileName().Replace(".tmp", ".xml");
              File.WriteAllText(fTmpFile, fDataStr);
              this.SendMRTestWorker.ReportProgress(1, string.Format("DONE size {0} {1}", fDataStr.Length, fTmpFile));
            }
            else
            {
              this.SendMRTestWorker.ReportProgress(1, string.Format("Error: {0}", oError));
            }
          }
        }
        else
        {
          this.SendMRTestWorker.ReportProgress(1, "SKIPPING No Data!");
        }

        this.SendMRTestWorker.ReportProgress(0, string.Format("Sending to {0}...", this.Export.Send.Name));
        if (!string.IsNullOrEmpty(fDataStr))
        {
          using (SendModule fSend = new SendModule())
          {
            SendResponse fResponse = fSend.SendData(this.Export.Source.TestID, fDataStr, this.Export);
            this.SendMRTestWorker.ReportProgress(1, fResponse);
            e.Result = fResponse.Status;
          }
        }
        else
        {
          this.SendMRTestWorker.ReportProgress(1, "SKIPPING No Data!");
        }

      }
    }
    private void SendMRTestWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      if (e.ProgressPercentage > 0)
      {
      }
      if (e.ProgressPercentage == 0 || Utils.IsDebug)
      {
        if (!string.IsNullOrEmpty(this.SendMRLog.Text))
        {
          this.SendMRLog.Text += Environment.NewLine;
        }
      }
      if (e.UserState is not null && e.UserState is string)
      {
        this.SendMRLog.Text += e.UserState.ToString();
      }
      if (e.UserState is not null && e.UserState is SendResponse)
      {
        SendResponse fRes = (e.UserState as SendResponse);
        if (fRes.Status)
        {
          this.SendMRLog.Text += "DONE " + fRes.PlainText.ToString();
        }
        else
        {
          this.SendMRLog.Text += "ERROR " + fRes.Error + Environment.NewLine + fRes.PlainText.ToString();
        }
      }
    }
    private void SendMRTestWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      Utils.ReportWorker = null;
      this.SendMRTestFile.Enabled = true;
      this.SendMRTestID.Enabled = true;
      if (e.Error is not null)
      {
        this.SendMRLog.Text += Environment.NewLine + e.Error.Message;
      }

      if (e.Result is not null && e.Result is bool && (bool)e.Result)
      {
        this.SendMRLog.Text += Environment.NewLine + "Finished SUCCESS";
      }
      else
      {
        this.SendMRLog.Text += Environment.NewLine + "Finished FAILED!";
      }
      this.Wait(true);
    }

    #endregion Workers
  }
}
