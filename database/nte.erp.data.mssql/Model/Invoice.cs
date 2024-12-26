using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

#nullable disable

namespace InvoiceDB.Data.Model
{
  [Serializable]
  [XmlRoot("Invoice")]
  [Table("Invoice")]
  public partial class Invoice
  {
    public Invoice()
    {
      InvoiceAdditionalDocumentReferences = new HashSet<InvoiceAdditionalDocumentReference>();
      InvoiceLines = new HashSet<InvoiceLine>();
      InvoiceTaxSubtotals = new HashSet<InvoiceTaxSubtotal>();
    }

    [Key]
    public int Id { get; set; }
    public int DocumentId { get; set; }
    [StringLength(128)]
    public string CustomizationId { get; set; }
    [Required]
    [StringLength(128)]
    public string InvoiceId { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime IssueDate { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? TaxPointDate { get; set; }
    public int InvoiceTypeCode { get; set; }
    [Required]
    [StringLength(3)]
    public string DocumentCurrencyCode { get; set; }
    public int InvoicePeriodCode { get; set; }
    public int AccountingSupplierPartyId { get; set; }
    public int AccountingCustomerPartyId { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime? ActualDeliveryDate { get; set; }
    [StringLength(64)]
    public string PaymentMeansId { get; set; }
    public int PaymentMeansCode { get; set; }
    [StringLength(64)]
    public string PaymentId { get; set; }
    [StringLength(256)]
    public string PayerFinancialAccountId { get; set; }
    [Required]
    [StringLength(256)]
    public string PayeeFinancialAccountId { get; set; }
    [Column(TypeName = "decimal(19, 2)")]
    public decimal TotalAmount { get; set; }
    [StringLength(512)]
    public string OrderReferenceId { get; set; }
    [StringLength(128)]
    public string DocumentReferenceId { get; set; }
    [StringLength(1024)]
    public string ContractDocumentReferenceId { get; set; }
    [StringLength(128)]
    public string OriginatorDocumentReferenceId { get; set; }
    public string Note { get; set; }
    [XmlIgnore]
    [ForeignKey(nameof(AccountingCustomerPartyId))]
    [InverseProperty(nameof(Party.InvoiceAccountingCustomerParties))]
    public virtual Party AccountingCustomerParty { get; set; }
    [XmlIgnore]
    [ForeignKey(nameof(AccountingSupplierPartyId))]
    [InverseProperty(nameof(Party.InvoiceAccountingSupplierParties))]
    public virtual Party AccountingSupplierParty { get; set; }
    [XmlIgnore]
    [ForeignKey(nameof(DocumentId))]
    [InverseProperty(nameof(Invoice))]
    public virtual Document Document { get; set; }
    [XmlIgnore]
    [InverseProperty(nameof(InvoiceAdditionalDocumentReference.Invoice))]
    public virtual ICollection<InvoiceAdditionalDocumentReference> InvoiceAdditionalDocumentReferences { get; set; }
    [XmlIgnore]
    [InverseProperty(nameof(Invoice))]
    public virtual InvoiceLegalMonetaryTotal InvoiceLegalMonetaryTotal { get; set; }
    [XmlIgnore]
    [InverseProperty(nameof(InvoiceLine.Invoice))]
    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
    [XmlIgnore]
    [InverseProperty(nameof(InvoiceTaxSubtotal.Invoice))]
    public virtual ICollection<InvoiceTaxSubtotal> InvoiceTaxSubtotals { get; set; }

    public virtual List<InvoiceTaxSubtotal> InvoiceTaxSubtotals1 { 
      get {
        List<InvoiceTaxSubtotal> fResult = new List<InvoiceTaxSubtotal> ();

        foreach(InvoiceTaxSubtotal fItem in this.InvoiceTaxSubtotals)
        {
          fResult.Add(fItem);
        }

        return fResult;
      } 
    }
  }
}
