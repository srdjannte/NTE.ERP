using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace eFaktureSynchronizer.Data.Model
{
  public partial class InvoiceAdditionalDocumentReference
  {
    [NotMapped]
    public string Name { get; set; }
  }
}
