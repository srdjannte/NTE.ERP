using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceDocumentReference")]
  public partial class InvoiceDocumentReference
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [Required]
    [StringLength(128)]
    public string DocumentReferenceId { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceDocumentReferences")]
    public virtual Invoice Invoice { get; set; }
  }
}
