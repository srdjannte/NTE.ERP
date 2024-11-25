using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Table("Party")]
  public partial class Party
  {
    public Party()
    {
      InvoiceAccountingCustomerParties = new HashSet<Invoice>();
      InvoiceAccountingSupplierParties = new HashSet<Invoice>();
    }

    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(32)]
    public string EndpointId { get; set; }
    public int EndpointSchemeId { get; set; }
    [StringLength(128)]
    public string IdentificationId { get; set; }
    [StringLength(256)]
    public string Name { get; set; }
    [StringLength(256)]
    public string AddressStreetName { get; set; }
    [StringLength(128)]
    public string AddressCityName { get; set; }
    [StringLength(128)]
    public string AddressPostalZone { get; set; }
    [StringLength(32)]
    public string AddressCountryIdentificationCode { get; set; }
    [StringLength(32)]
    public string TaxSchemeId { get; set; }
    [StringLength(128)]
    public string TaxSchemeCompanyId { get; set; }
    [StringLength(128)]
    public string TaxSchemeRegistrationName { get; set; }
    [StringLength(32)]
    public string LegalEntityCompanyId { get; set; }
    [StringLength(256)]
    public string LegalEntityRegistrationName { get; set; }
    [StringLength(128)]
    public string ContactName { get; set; }
    [StringLength(128)]
    public string ContactEmail { get; set; }

    [InverseProperty(nameof(Invoice.AccountingCustomerParty))]
    public virtual ICollection<Invoice> InvoiceAccountingCustomerParties { get; set; }
    [InverseProperty(nameof(Invoice.AccountingSupplierParty))]
    public virtual ICollection<Invoice> InvoiceAccountingSupplierParties { get; set; }
  }
}
