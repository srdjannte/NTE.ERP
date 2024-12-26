namespace nte.erp.core.Import.Request.PurchaseInvoice
{
  public class AcceptOrRejectPurchaseInvoiceRequest
  {
    public int InvoiceId { get; set; }
    public bool Accepted { get; set; }
    public string Comment { get; set; }
  }
}
