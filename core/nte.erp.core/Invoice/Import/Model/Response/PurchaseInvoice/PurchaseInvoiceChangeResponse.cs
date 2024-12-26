namespace nte.erp.core.Import.Response.PurchaseInvoice
{
  public class PurchaseInvoiceChangeResponse
  {
    public int EventId { get; set; }
    public string Date { get; set; }
    public string NewInvoiceStatus { get; set; }
    public int PurchaseInvoiceId { get; set; }
    public string Comment { get; set; }
    public string CirInvoiceId { get; set; }
    public string SubscriptionKey { get; set; }
  }
}
