using nte.erp.core;
using nte.erp.core.Export;
using nte.erp.services.invoices.Classes;
using System.ComponentModel;
using System.Runtime.Versioning;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]
  public partial class FormEditorSourceTest : Form
  {
    private ExportItem Export;
    public ExportTestData TestData = new ExportTestData();
    private bool IsTest = false;
    public FormEditorSourceTest(ExportItem iExportItem, bool iTest = false)
    {
      InitializeComponent();
      this.Export = iExportItem;
      this.TestID.Text = this.Export.Source.TestID;
      if (iTest)
      {
        this.IsTest = true;
        this.TestQueries.Checked = true;
      }
      else
      {
        this.IsTest = false;
        this.TestQueries.Checked = false;
      }
      this.LinkSourceSaveTestFile.Visible = false;
      this.ExportNameLabel.Visible = this.TestQueries.Checked;
      this.TestID.Visible = this.TestQueries.Checked;
    }

    #region Actions
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.LinkSourceSaveTestFile)
      {
        if (this.SaveFileTestDialog.ShowDialog() == DialogResult.OK)
        {
          string fFileTestXml = Path.GetTempPath() + "nteracun-export-test.xml";
          File.Copy(fFileTestXml, this.SaveFileTestDialog.FileName);
        }
      }
      if (sender == this.doTest)
      {
        if (!this.TestWorker.IsBusy)
        {
          this.doTest.Enabled = false;
          this.Cursor = Cursors.WaitCursor;
          if (this.TestQueries.Checked && this.TestID.Text != "")
          {
            this.Export.Source.TestID = this.TestID.Text;
            this.TestWorker.RunWorkerAsync(this.Export.Source.TestID);
          }
          else
          {
            this.TestWorker.RunWorkerAsync();
          }
        }
      }
      if (sender == this.doCancel)
      {
        this.Close();
      }
    }
    #endregion

    #region Worker
    private void TestWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      string fID = (e != null && e.Argument != null) ? e.Argument.ToString().Trim() : string.Empty;
      Utils.ReportWorker = (BackgroundWorker)sender;

      using (SourceModule fSource = new SourceModule())
      {
        if (fSource.LoadData(this.Export.Source.TestID, this.Export, out string oError))
        {
          this.TestData = new ExportTestData();
          this.TestData.Data = fSource.DataSet.Copy();
          Utils.SaveTestData(this.Export, this.TestData);
        }
        else
        {
          this.TestWorker.ReportProgress(-1, oError);
          throw new Exception(oError);
        }
      }
    }
    private void TestWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      if (e.UserState != null)
      {
        this.TestLog.Text = e.UserState.ToString();
      }
    }
    private void TestWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      Utils.ReportWorker = null;
      this.doTest.Enabled = true;
      this.Cursor = Cursors.Default;
      if (e.Error == null)
      {
        this.TestLog.Text = "Connection Success";
        if (this.TestQueries.Checked)
        {
          this.LinkSourceSaveTestFile.Visible = true;
        }
        if (this.IsTest)
        {
          this.DialogResult = DialogResult.OK;
        }
      }
      else
      {
        this.LinkSourceSaveTestFile.Visible = false;
        this.TestLog.Text = "Error: " + e.Error.Message;
      }
    }
    #endregion

    private void TestQueries_CheckedChanged(object sender, EventArgs e)
    {
      this.ExportNameLabel.Visible = this.TestQueries.Checked;
      this.TestID.Visible = this.TestQueries.Checked;
    }
  }
}
