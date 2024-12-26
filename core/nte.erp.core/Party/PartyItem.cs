using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace nte.erp.core
{
  [Serializable]
  [XmlRoot("Party")]
  [Table("Party")]
  public partial class PartyItem
  {
    public PartyItem()
    {

    }

    [Key]
    public int Id;
    [Required]
    [StringLength(32)]
    public string EndpointId;
    public int EndpointSchemeId;
    [StringLength(128)]
    public string IdentificationId;
    [StringLength(256)]
    public string Name;
    [StringLength(256)]
    public string AddressStreetName;
    [StringLength(128)]
    public string AddressCityName;
    [StringLength(128)]
    public string AddressPostalZone;
    [StringLength(32)]
    public string AddressCountryIdentificationCode;
    [StringLength(32)]
    public string TaxSchemeId;
    [StringLength(128)]
    public string TaxSchemeCompanyId;
    [StringLength(128)]
    public string TaxSchemeRegistrationName;
    [StringLength(32)]
    public string LegalEntityCompanyId;
    [StringLength(256)]
    public string LegalEntityRegistrationName;
    [StringLength(128)]
    public string ContactName;
    [StringLength(128)]
    public string ContactEmail;
  }

}
