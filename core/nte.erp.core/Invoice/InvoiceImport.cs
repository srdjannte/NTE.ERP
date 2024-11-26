namespace nte.erp.core.Invoice
{
  public class InvoiceImport : InvoiceBase
  {
    public InvoiceImport()
    {
    }

    /*[ForeignKey(nameof(AccountingCustomerPartyId))]
    [InverseProperty(nameof(Party.InvoiceAccountingCustomerParties))]
    public virtual Party AccountingCustomerParty;
    [ForeignKey(nameof(AccountingSupplierPartyId))]
    [InverseProperty(nameof(Party.InvoiceAccountingSupplierParties))]
    public virtual Party AccountingSupplierParty;
    [ForeignKey(nameof(DocumentId))]
    [InverseProperty(nameof(Invoice))]
    public virtual Document Document;
    [InverseProperty(nameof(InvoiceAdditionalDocumentReference.Invoice))]
    public virtual ICollection<InvoiceAdditionalDocumentReference> InvoiceAdditionalDocumentReferences;
    [InverseProperty(nameof(Invoice))]
    public virtual InvoiceLegalMonetaryTotal InvoiceLegalMonetaryTotal;
    [InverseProperty(nameof(InvoiceLine.Invoice))]
    public virtual ICollection<InvoiceLine> InvoiceLines;
    [InverseProperty(nameof(InvoiceTaxSubtotal.Invoice))]
    public virtual ICollection<InvoiceTaxSubtotal> InvoiceTaxSubtotals;*/

  }
}
