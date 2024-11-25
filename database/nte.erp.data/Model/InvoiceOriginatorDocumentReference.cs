using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceOriginatorDocumentReference")]
  [Index(nameof(InvoiceId), Name = "UNQ_InvoiceOriginatorDocumentReference_InvoiceId", IsUnique = true)]
  public partial class InvoiceOriginatorDocumentReference
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [Required]
    [StringLength(128)]
    public string OriginatorDocumentReferenceId { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceOriginatorDocumentReference")]
    public virtual Invoice Invoice { get; set; }
  }
}
