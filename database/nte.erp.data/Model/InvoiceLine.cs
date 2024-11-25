using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceLine")]
  public partial class InvoiceLine
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [StringLength(32)]
    public string LineId { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal InvoicedQuantity { get; set; }
    [StringLength(32)]
    public string InvoicedQuantityUnitCode { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal LineExtensionAmount { get; set; }
    public bool AllowanceChargeIndicator { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal AllowanceChargeMultiplierFactorNumeric { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal AllowanceChargeAmount { get; set; }
    [StringLength(2048)]
    public string Name { get; set; }
    [StringLength(512)]
    public string SellersItemIdentification { get; set; }
    [StringLength(6)]
    public string ClassifiedTaxCategory { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal ClassifiedTaxCategoryPercent { get; set; }
    [StringLength(6)]
    public string ClassifiedTaxCategoryTaxScheme { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal PriceAmount { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceLines")]
    public virtual Invoice Invoice { get; set; }
  }
}
