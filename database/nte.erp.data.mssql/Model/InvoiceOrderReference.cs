using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceOrderReference")]
  [Index(nameof(InvoiceId), Name = "UNQ_InvoiceOrderReference_InvoiceId", IsUnique = true)]
  public partial class InvoiceOrderReference
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [Required]
    [StringLength(512)]
    public string OrderReferenceId { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceOrderReference")]
    public virtual Invoice Invoice { get; set; }
  }
}
