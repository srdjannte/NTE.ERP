using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceContractDocumentReference")]
  [Index(nameof(InvoiceId), Name = "UNQ_InvoiceContractDocumentReference_InvoiceId", IsUnique = true)]
  public partial class InvoiceContractDocumentReference
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [Required]
    [StringLength(256)]
    public string ContractDocumentReferenceId { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceContractDocumentReference")]
    public virtual Invoice Invoice { get; set; }
  }
}
