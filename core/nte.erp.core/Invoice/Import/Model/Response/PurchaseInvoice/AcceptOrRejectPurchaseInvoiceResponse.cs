namespace nte.erp.core.Import.Response.PurchaseInvoice
{
  public class AcceptOrRejectPurchaseInvoiceResponse
  {
    public string Message { get; set; }
    public string HttpStatus { get; set; }
    public bool Success { get; set; }
    public InvoiceObject Invoice { get; set; }
  }

  public class InvoiceObject
  {
    public string InvoiceNumber { get; set; }
    public string Status { get; set; }
  }
}
