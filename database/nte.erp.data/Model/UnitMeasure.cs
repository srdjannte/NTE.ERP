using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("UnitMeasure")]
  [Index(nameof(Code), Name = "UQ__UnitMeas__A25C5AA708E61356", IsUnique = true)]
  public partial class UnitMeasure
  {
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(3)]
    public string Code { get; set; }
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
