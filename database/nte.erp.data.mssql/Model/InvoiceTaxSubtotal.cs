using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Serializable]
  [XmlRoot("InvoiceTaxSubtotal")]
  [Table("InvoiceTaxSubtotal")]
  public partial class InvoiceTaxSubtotal
  {
    [Key]
    public int Id { get; set; }
    public int InvoiceId { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal SubtotalAmount { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal SubtotalTaxableAmount { get; set; }
    [Required]
    [StringLength(2)]
    public string SubtotalTaxCategory { get; set; }
    [StringLength(32)]
    public string SubtotalTaxCategoryTaxExemptionReasonCode { get; set; }
    [StringLength(1024)]
    public string SubtotalTaxCategoryTaxExemptionReason { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal SubtotalTaxCategoryPercent { get; set; }
    [Required]
    [StringLength(3)]
    public string SubtotalTaxCategoryTaxScheme { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [InverseProperty("InvoiceTaxSubtotals")]
    public virtual Invoice Invoice { get; set; }
  }
}
