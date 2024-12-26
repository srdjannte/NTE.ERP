using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace nte.erp.core.Invoice
{
  [Serializable]
  [XmlRoot("InvoiceImport")]
  [Table("InvoiceImport")]
  public partial class InvoiceImport : InvoiceBase
  {
    public InvoiceImport()
    {
    }
    //[Key]
    //public int Id { get; set; }
    public int MyId { get; set; }
    [StringLength(128)]
    public string InvoiceId { get; set; }
    /*[ForeignKey(nameof(AccountingCustomerPartyId))]
    [InverseProperty(nameof(Party.InvoiceAccountingCustomerParties))]
    public virtual Party AccountingCustomerParty;
    [ForeignKey(nameof(AccountingSupplierPartyId))]
    [InverseProperty(nameof(Party.InvoiceAccountingSupplierParties))]
    public virtual Party AccountingSupplierParty;
    [ForeignKey(nameof(DocumentId))]
    [InverseProperty(nameof(Invoice))]
    public virtual Document Document;
    [InverseProperty(nameof(InvoiceAdditionalDocumentReference.Invoice))]
    public virtual ICollection<InvoiceAdditionalDocumentReference> InvoiceAdditionalDocumentReferences;
    [InverseProperty(nameof(Invoice))]
    public virtual InvoiceLegalMonetaryTotal InvoiceLegalMonetaryTotal;
    [InverseProperty(nameof(InvoiceLine.Invoice))]
    public virtual ICollection<InvoiceLine> InvoiceLines;
    [InverseProperty(nameof(InvoiceTaxSubtotal.Invoice))]
    public virtual ICollection<InvoiceTaxSubtotal> InvoiceTaxSubtotals;*/

  }
}
