namespace nte.erp.core.Import.Response.PurchaseInvoice
{
  public class PurchaseInvoiceResponse
  {
    public int InvoiceId { get; set; }
    public Guid GlobUniqId { get; set; }
    public string Status { get; set; }
    public string Comment { get; set; }
    public string CirStatus { get; set; }
    public string CirInvoiceId { get; set; }
    public int Version { get; set; }
    public string LastModifiedUtc { get; set; }
    public decimal CirSettledAmount { get; set; }
    public string VatNumberFactoringCompany { get; set; }
    public string FactoringContractNumber { get; set; }
    public string CancelComment { get; set; }
    public string StornoComment { get; set; }
  }
}