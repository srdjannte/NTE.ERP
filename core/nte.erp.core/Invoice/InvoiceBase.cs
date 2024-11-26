namespace nte.erp.core.Invoice
{
  public class InvoiceBase
  {
    public int Id;
    public int DocumentId;
    public string CustomizationId;
    public string InvoiceId;
    public DateTime IssueDate;
    public DateTime? DueDate;
    public DateTime? TaxPointDate;
    public int InvoiceTypeCode;
    public string DocumentCurrencyCode;
    public int InvoicePeriodCode;
    public int AccountingSupplierPartyId;
    public int AccountingCustomerPartyId;
    public DateTime? ActualDeliveryDate;
    public string PaymentMeansId;
    public int PaymentMeansCode;
    public string PaymentId;
    public string PayerFinancialAccountId;
    public string PayeeFinancialAccountId;
    public decimal TotalAmount;
    public string OrderReferenceId;
    public string DocumentReferenceId;
    public string ContractDocumentReferenceId;
    public string OriginatorDocumentReferenceId;
    public string Note;
  }
}
