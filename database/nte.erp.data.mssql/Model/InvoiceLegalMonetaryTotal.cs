using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceLegalMonetaryTotal")]
  public partial class InvoiceLegalMonetaryTotal
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal LineExtensionAmount { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal TaxExclusiveAmount { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal TaxInclusiveAmount { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal AllowanceTotalAmount { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal PrepaidAmount { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal PayableAmount { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty(nameof(InvoiceLegalMonetaryTotal))]
    public virtual Invoice Invoice { get; set; }
  }
}
