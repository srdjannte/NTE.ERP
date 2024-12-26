using nte.erp.core.Export;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace nte.erp.core
{
  [Serializable]
  [XmlRoot("Owner")]
  [Table("Owner")]
  public partial class OwnerItem
  {
    public enum States { Empty, OnBoard, Active, Deleted };
    public enum Licences { Local, Cloud, OnPremise };

    public OwnerItem()
    {

    }
    public States State = States.Empty;
    public string ApiKey = string.Empty;

    [Key]
    public int Id;
    [Key]
    public string Uid;
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
    [StringLength(128)]
    public string LicenceType = "Local";
    public Licences Licence = Licences.Local;
    public string OnPremiseURL;
    [StringLength(128)]
    public SourceModule Source = new SourceModule();
    public ExportSend Destination = new ExportSend();
    public string DataFile = string.Empty;
  }

}
