namespace nte.erp.core.Import.Request.PurchaseInvoice
{
  public class AcceptOrRejectPurchaseInvoiceCirRequest
  {
    public string CirInvoiceId { get; set; }
    public bool Accepted { get; set; }
    public string Comment { get; set; }
  }
}
