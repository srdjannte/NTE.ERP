using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("InvoiceTypeCode")]
  [Index(nameof(Code), Name = "UQ__InvoiceT__A25C5AA7CCD1CB10", IsUnique = true)]
  public partial class InvoiceTypeCode
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
    [StringLength(32)]
    public string NameEng { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime SyncDate { get; set; }
  }
}
