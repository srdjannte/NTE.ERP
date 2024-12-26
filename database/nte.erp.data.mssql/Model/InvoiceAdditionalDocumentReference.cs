using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceAdditionalDocumentReference")]
  public partial class InvoiceAdditionalDocumentReference
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    public int FileId { get; set; }

    [ForeignKey(nameof(FileId))]
    [InverseProperty("InvoiceAdditionalDocumentReferences")]
    public virtual File File { get; set; }
    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceAdditionalDocumentReferences")]
    public virtual Invoice Invoice { get; set; }
  }
}
