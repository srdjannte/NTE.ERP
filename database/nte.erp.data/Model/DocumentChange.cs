using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("DocumentChange")]
  public partial class DocumentChange
  {
    [Key]
    public int Id { get; set; }
    public int EventId { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime EventDate { get; set; }
    public int PurchaseInvoiceId { get; set; }
    [StringLength(32)]
    public string CirInvoiceId { get; set; }
    [Required]
    [StringLength(32)]
    public string PurchaseInvoiceStatus { get; set; }
    [StringLength(128)]
    public string SubscriptionKey { get; set; }
    [StringLength(1024)]
    public string Comment { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime SyncDate { get; set; }
  }
}
