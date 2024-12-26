using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceTaxExemptionReasonList")]
  [Index(nameof(ReasonId), Name = "UQ__InvoiceT__A4F8C0E6FD289329", IsUnique = true)]
  public partial class InvoiceTaxExemptionReasonList
  {
    [Key]
    public int Id { get; set; }
    public int ReasonId { get; set; }
    [Required]
    [StringLength(32)]
    public string Key { get; set; }
    [Required]
    [StringLength(128)]
    public string Law { get; set; }
    [Required]
    [StringLength(4)]
    public string Article { get; set; }
    [StringLength(4)]
    public string Paragraph { get; set; }
    [StringLength(4)]
    public string Point { get; set; }
    [StringLength(4)]
    public string Subpoint { get; set; }
    [Required]
    [StringLength(1024)]
    public string Text { get; set; }
    [StringLength(1024)]
    public string FreeFormNote { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime ActiveFrom { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? ActiveTo { get; set; }
    [StringLength(2)]
    public string Category { get; set; }
  }
}
