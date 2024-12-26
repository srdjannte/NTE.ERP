using nte.erp.client.Common;
using System.Data;

namespace nte.erp.client.Invoices.Import
{
  public partial class ControlList : ControlBase
  {
    public ControlList()
    {
      InitializeComponent();

      this.Action_Load();
      this.ListGrid.AutoGenerateColumns = false;
      this.ListGrid.DataSource = Utils.Data.InvoiceImport;      
    }

    #region Actions
    private void Action_Load()
    {      
      foreach (ToolStripItem fMenu in this.ListMenu.Items)
      {
        this.MenuItems.Add(fMenu);
        if (fMenu is ToolStripMenuItem)
        {
          //this.MenuItems.Add(fMenu);
        }
      }
    }

    private void Action_New(bool iDialog = false)
    {
      DataRow fRow = Utils.Data.InvoiceImportNewRow;
      if (iDialog)
      {
        fRow["StateUid"] = "New";
        FormDetail fInvoiceImportDetail = new FormDetail(fRow);
        fInvoiceImportDetail.Show(this);
      }
      else
      {
        fRow["StateUid"] = "New";
        Utils.Data.InvoiceImport.Rows.Add(fRow);
        Utils.Data.Save();
      }
    }
    private void Action_Edit(DataRow iRow, bool iReadOnly = false)
    {
      //Invoices.Import.FormDetail fInvoiceImportDetail = new Invoices.Import.FormDetail(fRow);
      //fInvoiceImportDetail.Show(this);
    }
    private void Action_Down()
    {
      using (FormDown fFormInvoiceImportDown = new FormDown())
      {
        fFormInvoiceImportDown.ShowDialog(this);
      }
    }
    private void Action_Click(object sender, EventArgs e)
    {
      if ((sender != null) && (sender is ToolStripButton) && ((sender as ToolStripButton)?.Tag != null))
      {
        string fAction = (sender as ToolStripButton).Tag.ToString();

        switch (fAction)
        {
          case "New":
            this.Action_New(true);
            break;
          case "Down":
            this.Action_Down();
            break;
        }
      }
      if (sender == this.ItemOpen)
      {
        this.Action_New(true);
      }
      if (sender == this.ItemNew)
      {
        this.Action_New(true);
      }
      if (sender == this.ItemAdd)
      {
        this.Action_New(false);
      }
      if (sender == this.ItemDelete)
      {
        if (0 < this.ListGrid.SelectedCells.Count)
        {
          int fIndex = this.ListGrid.SelectedCells[0].RowIndex;

          Utils.Data.InvoiceImport.Rows[fIndex].Delete();
          Utils.Data.Save();
        }
      }
      if (sender == this.ItemDown)
      {
        this.Action_Down();
      }
    }
    #endregion
  }
}
