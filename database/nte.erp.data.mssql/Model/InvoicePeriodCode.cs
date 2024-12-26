using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoicePeriodCode")]
  [Index(nameof(Code), Name = "UQ__InvoiceP__A25C5AA7A2F7EC2F", IsUnique = true)]
  public partial class InvoicePeriodCode
  {
    [Key]
    public int Id { get; set; }
    public int Code { get; set; }
    [Required]
    [StringLength(32)]
    public string NameCyr { get; set; }
    [Required]
    [StringLength(32)]
    public string NameLat { get; set; }
    [Required]
    [StringLength(64)]
    public string NameEng { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime SyncDate { get; set; }
  }
}
