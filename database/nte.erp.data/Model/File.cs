using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("File")]
  public partial class File
  {
    public File()
    {
      Documents = new HashSet<Document>();
      InvoiceAdditionalDocumentReferences = new HashSet<InvoiceAdditionalDocumentReference>();
    }

    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(1024)]
    public string Name { get; set; }
    [StringLength(1024)]
    public string Path { get; set; }
    [Required]
    [StringLength(32)]
    public string MimeCode { get; set; }
    public byte[] BinaryDoc { get; set; }

    [InverseProperty(nameof(Document.File))]
    public virtual ICollection<Document> Documents { get; set; }
    [InverseProperty(nameof(InvoiceAdditionalDocumentReference.File))]
    public virtual ICollection<InvoiceAdditionalDocumentReference> InvoiceAdditionalDocumentReferences { get; set; }
  }
}
