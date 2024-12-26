using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("DocumentPdf")]
  public partial class DocumentPdf
  {
    [Key]
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public int FileId { get; set; }

    [ForeignKey(nameof(DocumentId))]
    [InverseProperty("DocumentPdfs")]
    public virtual Document Document { get; set; }
    [ForeignKey(nameof(FileId))]
    [InverseProperty("DocumentPdfs")]
    public virtual File File { get; set; }
  }
}
