using nte.erp.core.Import;

namespace nte.erp.services.invoices.Forms.Editor
{
  public partial class ControlImportGeneral : UserControl
  {
    private ImportItem _Import = null;
    public ControlImportGeneral()
    {
      InitializeComponent();
    }

    public ImportItem Import
    {
      get
      {
        return this._Import;
      }
      set
      {
        this._Import = value;
        this.Action_Refresh();
      }
    }

    public void Action_Refresh()
    {
      this.ExportName.Text = this._Import.Name;
      this.ExportDescription.Text = this._Import.Description;
      this.ExportKind.Text = "Import";
      this.ExportFileNameLabel.Visible = (!string.IsNullOrEmpty(this._Import.FileName));
      this.ExportFileName.Text = this._Import.FileName;
      this.ExportFileName.Visible = (!string.IsNullOrEmpty(this._Import.FileName));
      this.ExportCreatedText.Text = this._Import.CreateBy.ToString() + " At " + this._Import.CreateAt.ToString();
      this.ExportChangeText.Text = this._Import.ChangeBy.ToString() + " On " + this._Import.ChangeOn.ToString() + " At " + this._Import.ChangeAt.ToString() + " Version " + this._Import.ChangeRev.ToString();
    }
  }
}
