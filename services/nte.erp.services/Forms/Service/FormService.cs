using nte.erp.core.Export;
using nte.erp.services.invoices.Classes;
using System.Runtime.Versioning;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]

  public partial class FormService : Form
  {
    private ExportItem? ExportItem = null;
    private string ExportFileDefault = "default-export.xml";
    private string ExportFile = string.Empty;

    public FormService(string[] args)
    {
      InitializeComponent();
      this.ExportFile = this.ExportFileDefault;
    }
    private void Action_Click(object sender, EventArgs e)
    {
      #region File Menu
      if (sender == this.MenuFile)
      {
      }
      if (sender == this.MenuFileOpen)
      {
        if (this.openFileDialog.ShowDialog() == DialogResult.OK)
        {
          ExportItem fExportTmp = new ExportItem();
          if (Utils.LoadExport(this.openFileDialog.FileName, out fExportTmp))
          {
            //this.Wait();
            fExportTmp.LoadAt = DateTime.Now;
            this.ExportFile = this.openFileDialog.FileName;
            //this.Import = null;
            this.ExportItem = fExportTmp;
            //this.SaveRecent(this.FileName);
            //this.Action_Refresh();
            //this.Wait(true);
          }
        }
      }
      if (sender == this.MenuFileEditor || sender == this.MenuEditorStrip)
      {
        new FormEditor().ShowDialog();
      }
      if (sender == this.MenuClose)
      {
        this.Close();
      }
      #endregion
      #region File Menu
      if (sender == this.MenuOptionsDebug)
      {

      }
      #endregion
    }
  }
}