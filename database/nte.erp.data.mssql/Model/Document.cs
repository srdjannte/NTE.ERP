using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("Document")]
  public partial class Document
  {
    public Document()
    {
    }

    [Key]
    public int Id { get; set; }
    public int SalesInvoiceId { get; set; }
    public int PurchaseInvoiceId { get; set; }
    public Guid DocumentId { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime SendingDate { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime SyncDate { get; set; }
    public int? FileId { get; set; }
    [Required]
    public bool? IsActive { get; set; }

    [ForeignKey(nameof(FileId))]
    [InverseProperty("Documents")]
    public virtual File File { get; set; }
    [InverseProperty(nameof(Document))]
    public virtual DocumentDetail DocumentDetail { get; set; }
    [InverseProperty(nameof(Document))]
    public virtual Invoice Invoice { get; set; }
  }
}
