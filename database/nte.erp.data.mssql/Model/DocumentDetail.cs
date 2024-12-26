using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("DocumentDetail")]
  public partial class DocumentDetail
  {
    [Key]
    public int Id { get; set; }
    public int DocumentId { get; set; }
    [Required]
    [StringLength(32)]
    public string PurchaseInvoiceStatus { get; set; }
    [StringLength(32)]
    public string CirInvoiceId { get; set; }
    [Required]
    [StringLength(32)]
    public string CirInvoiceStatus { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal CirSettledAmount { get; set; }
    [StringLength(32)]
    public string VatNumberFactoringCompany { get; set; }
    [StringLength(64)]
    public string FactoringContractNumber { get; set; }
    [StringLength(1024)]
    public string Comment { get; set; }
    [StringLength(1024)]
    public string CancelComment { get; set; }
    [StringLength(1024)]
    public string StornoComment { get; set; }
    public int Version { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime LastModifiedUtc { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime SyncDate { get; set; }

    [ForeignKey(nameof(DocumentId))]
    [InverseProperty(nameof(DocumentDetail))]
    public virtual Document Document { get; set; }
  }
}
