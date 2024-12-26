using nte.erp.core.Import.Extensions;
using System.Data;

namespace nte.erp.client.Invoices.Import
{
  public partial class FormDown : Form
  {
    private DataRow FileRow = null;
    public FormDown()
    {
      InitializeComponent();
      Utils.Styles.SetBody(this.PanelBody);
      Utils.Styles.SetCmd(this.PanelCmd);
      this.Action_Refresh();
    }

    private void Action_Refresh()
    {
      this.doProvider.Visible = !string.IsNullOrEmpty(Utils.Config.Owner.Destination.Provider.ToString());
      string fProvider = Utils.Config.Owner.Destination.Provider.ToString();
      this.doProvider.Text = fProvider;
      this.doProvider.Visible = (fProvider != "Skip");
    }
    private string GetValue(Dictionary<string, object> iDict, string iNodePath)
    {
      if (iDict != null && iDict.ContainsKey(iNodePath))
      {
        return iDict[iNodePath].ToString();
      }

      return "";
    }
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doFile && this.FileDialog.ShowDialog() == DialogResult.OK)
      {
        this.doSave.Enabled = false;
        string fFileData = File.ReadAllText(this.FileDialog.FileName);
        DataRow fRow = Utils.Data.InvoiceImportNewRow;

        try
        {
          if (Utils.Data.GetXML(fFileData, out Dictionary<string, object> oDict))
          {
            fRow["CustomizationId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/CustomizationID");
            fRow["InvoiceId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/ID");
            fRow["IssueDate"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/IssueDate");
            fRow["DueDate"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["TaxPointDate"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            /*fRow["InvoiceTypeCode"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/InvoiceTypeCode");
            fRow["DocumentCurrencyCode"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DocumentCurrencyCode");
            fRow["InvoicePeriodCode"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/InvoicePeriod/DescriptionCode");
            fRow["AccountingSupplierPartyId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["AccountingCustomerPartyId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["ActualDeliveryDate"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["PaymentMeansId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["PaymentMeansCode"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["PaymentId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["PayerFinancialAccountId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["PayeeFinancialAccountId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["TotalAmount"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["Note"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["DocumentReferenceId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["ContractDocumentReferenceId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["OriginatorDocumentReferenceId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            fRow["OrderReferenceId"] = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");*/

            fRow["StateUid"] = "Load";

            this.InvoiceID.Text = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/ID");
            this.DueDate.Text = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/DueDate");
            this.PayableAmount.Text = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/LegalMonetaryTotal/PayableAmount");
            this.PartyName.Text = GetValue(oDict, "/DocumentEnvelope/DocumentBody/Invoice/AccountingSupplierParty/Party/PartyName");

            this.doSave.Enabled = true;
            this.FileRow = fRow;
          }
        }
        catch (Exception ex)
        {

        }

        // Utils.Data.InvoiceImport.Rows.Add(fRow);
        // Utils.Data.Save();

        #region Old Code
        /*
        if (this.FileDialog.ShowDialog() == DialogResult.OK)
        {
          string fFileTmp = this.FileDialog.FileName;
          string fFileData = File.ReadAllText(fFileTmp);

          nte.erp.core.Import.ImportModule importModule = new core.Import.ImportModule();
          //nte.erp.core.Import.Response.PurchaseInvoice.Invoice fDoc = importModule.GetPurchaseInvoiceXml(fFileData);
          nte.erp.core.Import.Response.PurchaseInvoice.DocumentEnvelope fDoc = importModule.GetPurchaseInvoiceXml1(fFileData);

          string fStr = fDoc.DocumentBody.Invoice.DueDate.ToString();

          DataRow fRow = Utils.Data.InvoiceImportNewRow;


          try
          {
            //fRow["DocumentId"] = (fDoc.DocumentBody.Invoice.ContractDocumentReference != null) ? fDoc.DocumentBody.Invoice.ContractDocumentReference.Id : "";
            fRow["CustomizationId"] = fDoc.DocumentBody.Invoice.CustomizationId;
            fRow["InvoiceId"] = fDoc.DocumentBody.Invoice.Id;
            fRow["IssueDate"] = fDoc.DocumentBody.Invoice.IssueDate;
            fRow["DueDate"] = fDoc.DocumentBody.Invoice.DueDate;
            fRow["TaxPointDate"] = fDoc.DocumentBody.Invoice.DueDate;
            fRow["InvoiceTypeCode"] = fDoc.DocumentBody.Invoice.InvoiceTypeCode;
            fRow["DocumentCurrencyCode"] = fDoc.DocumentBody.Invoice.DocumentCurrencyCode;
            fRow["InvoicePeriodCode"] = fDoc.DocumentBody.Invoice.InvoicePeriod.DescriptionCode;
            fRow["AccountingSupplierPartyId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["AccountingCustomerPartyId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["ActualDeliveryDate"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["PaymentMeansId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["PaymentMeansCode"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["PaymentId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["PayerFinancialAccountId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["PayeeFinancialAccountId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["TotalAmount"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["Note"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["DocumentReferenceId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["ContractDocumentReferenceId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["OriginatorDocumentReferenceId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
            fRow["OrderReferenceId"] = fDoc.DocumentBody.Invoice.DueDate.ToString();
          }
          catch (Exception ex)
          {

          }

          fRow["StateUid"] = "Active";
          Utils.Data.InvoiceImport.Rows.Add(fRow);
          Utils.Data.Save();
        }
        */
        #endregion
      }

      if (sender == this.doProvider)
      {
        this.Close();
      }

      if (sender == this.doSave)
      {
        Utils.Data.InvoiceImport.Rows.Add(this.FileRow);
        Utils.Data.Save();

        this.DialogResult = DialogResult.OK;
      }


      if (sender == this.doClose)
      {
        this.DialogResult = DialogResult.Cancel;
      }


    }
  }
}
