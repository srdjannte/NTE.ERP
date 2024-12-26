using System.Xml.Serialization;

namespace nte.erp.core.Import.Response.PurchaseInvoice
{
  // using System.Xml.Serialization;
  // XmlSerializer serializer = new XmlSerializer(typeof(DocumentEnvelope));
  // using (StringReader reader = new StringReader(xml))
  // {
  //    var test = (DocumentEnvelope)serializer.Deserialize(reader);
  // }

  //[XmlRoot(ElementName = "DocumentPdf")]
  public class BinaryFile
  {
    [XmlAttribute(AttributeName = "mimeCode")]
    public string MimeCode;

    [XmlText]
    public string Binary;
  }

  [XmlRoot(ElementName = "DocumentHeader")]
  public class DocumentHeader
  {

    [XmlElement(ElementName = "SalesInvoiceId")]
    public int SalesInvoiceId;

    [XmlElement(ElementName = "PurchaseInvoiceId")]
    public int PurchaseInvoiceId;

    [XmlElement(ElementName = "DocumentId")]
    public Guid DocumentId;

    [XmlElement(ElementName = "CreationDate")]
    public DateTime CreationDate;

    [XmlElement(ElementName = "SendingDate")]
    public DateTime SendingDate;

    [XmlElement(ElementName = "DocumentPdf")]
    public BinaryFile BinaryFile;
  }

  [XmlRoot(ElementName = "InvoicePeriod")]
  public class InvoicePeriod
  {

    [XmlElement(ElementName = "DescriptionCode")]
    public int DescriptionCode;
  }

  [XmlRoot(ElementName = "OrderReference")]
  public class OrderReference
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "ContractDocumentReference")]
  public class ContractDocumentReference
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "OriginatorDocumentReference")]
  public class OriginatorDocumentReference
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "Attachment")]
  public class Attachment
  {

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "EmbeddedDocumentBinaryObject")]
    public BinaryFile BinaryFile;
  }

  [XmlRoot(ElementName = "AdditionalDocumentReference")]
  public class AdditionalDocumentReference
  {

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "Attachment")]
    public Attachment Attachment;
  }

  [XmlRoot(ElementName = "EndpointID")]
  public class Endpoint
  {

    [XmlAttribute(AttributeName = "schemeID")]
    public int SchemeId;

    [XmlText]
    public string Id;
  }

  [XmlRoot(ElementName = "PartyIdentification")]
  public class PartyIdentification
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "PartyName")]
  public class PartyName
  {

    [XmlElement(ElementName = "Name")]
    public string Name;
  }

  [XmlRoot(ElementName = "Country")]
  public class Country
  {

    [XmlElement(ElementName = "IdentificationCode")]
    public string IdentificationCode;
  }

  [XmlRoot(ElementName = "PostalAddress")]
  public class PostalAddress
  {
    [XmlElement(ElementName = "StreetName")]
    public string StreetName;

    [XmlElement(ElementName = "CityName")]
    public string CityName;

    [XmlElement(ElementName = "PostalZone")]
    public string PostalZone;

    [XmlElement(ElementName = "Country")]
    public Country Country;
  }

  [XmlRoot(ElementName = "TaxScheme")]
  public class TaxScheme
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "PartyTaxScheme")]
  public class PartyTaxScheme
  {
    [XmlElement(ElementName = "RegistrationName")]
    public string RegistrationName;

    [XmlElement(ElementName = "CompanyID")]
    public string CompanyId;

    [XmlElement(ElementName = "TaxScheme")]
    public TaxScheme TaxScheme;
  }

  [XmlRoot(ElementName = "PartyLegalEntity")]
  public class PartyLegalEntity
  {

    [XmlElement(ElementName = "RegistrationName")]
    public string RegistrationName;

    [XmlElement(ElementName = "CompanyID")]
    public string CompanyId;
  }

  [XmlRoot(ElementName = "Contact")]
  public class Contact
  {

    [XmlElement(ElementName = "Name")]
    public string Name;

    [XmlElement(ElementName = "ElectronicMail")]
    public string Email;
  }

  [XmlRoot(ElementName = "Party")]
  public class Party
  {

    [XmlElement(ElementName = "EndpointID")]
    public Endpoint Endpoint;

    [XmlElement(ElementName = "PartyIdentification")]
    public PartyIdentification PartyIdentification;

    [XmlElement(ElementName = "PartyName")]
    public PartyName PartyName;

    [XmlElement(ElementName = "PostalAddress")]
    public PostalAddress PostalAddress;

    [XmlElement(ElementName = "PartyTaxScheme")]
    public PartyTaxScheme PartyTaxScheme;

    [XmlElement(ElementName = "PartyLegalEntity")]
    public PartyLegalEntity PartyLegalEntity;

    [XmlElement(ElementName = "Contact")]
    public Contact Contact;
  }

  [XmlRoot(ElementName = "AccountingSupplierParty")]
  public class AccountingSupplierParty
  {

    [XmlElement(ElementName = "Party")]
    public Party Party;
  }

  [XmlRoot(ElementName = "AccountingCustomerParty")]
  public class AccountingCustomerParty
  {

    [XmlElement(ElementName = "Party")]
    public Party Party;
  }

  [XmlRoot(ElementName = "Delivery")]
  public class Delivery
  {

    [XmlElement(ElementName = "ActualDeliveryDate")]
    public DateTime ActualDeliveryDate;
  }

  [XmlRoot(ElementName = "PayerFinancialAccount")]
  public class PayerFinancialAccount
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "PayeeFinancialAccount")]
  public class PayeeFinancialAccount
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "PaymentMeans")]
  public class PaymentMeans
  {

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "PaymentMeansCode")]
    public int PaymentMeansCode;

    [XmlElement(ElementName = "PaymentID")]
    public string PaymentId;

    [XmlElement(ElementName = "PayerFinancialAccount")]
    public PayerFinancialAccount PayerFinancialAccount;

    [XmlElement(ElementName = "PayeeFinancialAccount")]
    public PayeeFinancialAccount PayeeFinancialAccount;
  }

  [XmlRoot(ElementName = "TaxAmount")]
  public class TaxAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "TaxableAmount")]
  public class TaxableAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "TaxCategory")]
  public class TaxCategory
  {

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "Percent")]
    public double Percent;

    [XmlElement(ElementName = "TaxExemptionReasonCode")]
    public string TaxExemptionReasonCode;

    [XmlElement(ElementName = "TaxExemptionReason")]
    public string TaxExemptionReason;

    [XmlElement(ElementName = "TaxScheme")]
    public TaxScheme TaxScheme;
  }

  [XmlRoot(ElementName = "TaxSubtotal")]
  public class TaxSubtotal
  {

    [XmlElement(ElementName = "TaxableAmount")]
    public TaxableAmount TaxableAmount;

    [XmlElement(ElementName = "TaxAmount")]
    public TaxAmount TaxAmount;

    [XmlElement(ElementName = "TaxCategory")]
    public TaxCategory TaxCategory;
  }

  [XmlRoot(ElementName = "TaxTotal")]
  public class TaxTotal
  {

    [XmlElement(ElementName = "TaxAmount")]
    public TaxAmount TaxAmount;

    [XmlElement(ElementName = "TaxSubtotal")]
    public List<TaxSubtotal> TaxSubtotal;
  }

  [XmlRoot(ElementName = "LineExtensionAmount")]
  public class LineExtensionAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "TaxExclusiveAmount")]
  public class TaxExclusiveAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "TaxInclusiveAmount")]
  public class TaxInclusiveAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "AllowanceTotalAmount")]
  public class AllowanceTotalAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "PrepaidAmount")]
  public class PrepaidAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "PayableAmount")]
  public class PayableAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "LegalMonetaryTotal")]
  public class LegalMonetaryTotal
  {

    [XmlElement(ElementName = "LineExtensionAmount")]
    public LineExtensionAmount LineExtensionAmount;

    [XmlElement(ElementName = "TaxExclusiveAmount")]
    public TaxExclusiveAmount TaxExclusiveAmount;

    [XmlElement(ElementName = "TaxInclusiveAmount")]
    public TaxInclusiveAmount TaxInclusiveAmount;

    [XmlElement(ElementName = "AllowanceTotalAmount")]
    public AllowanceTotalAmount AllowanceTotalAmount;

    [XmlElement(ElementName = "PrepaidAmount")]
    public PrepaidAmount PrepaidAmount;

    [XmlElement(ElementName = "PayableAmount")]
    public PayableAmount PayableAmount;
  }

  [XmlRoot(ElementName = "InvoicedQuantity")]
  public class InvoicedQuantity
  {

    [XmlAttribute(AttributeName = "unitCode")]
    public string UnitCode;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "SellersItemIdentification")]
  public class SellersItemIdentification
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "ClassifiedTaxCategory")]
  public class ClassifiedTaxCategory
  {

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "Percent")]
    public double Percent;

    [XmlElement(ElementName = "TaxScheme")]
    public TaxScheme TaxScheme;
  }

  [XmlRoot(ElementName = "Item")]
  public class Item
  {

    [XmlElement(ElementName = "Name")]
    public string Name;

    [XmlElement(ElementName = "SellersItemIdentification")]
    public SellersItemIdentification SellersItemIdentification;

    [XmlElement(ElementName = "ClassifiedTaxCategory")]
    public ClassifiedTaxCategory ClassifiedTaxCategory;
  }

  [XmlRoot(ElementName = "PriceAmount")]
  public class PriceAmount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyId;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "Price")]
  public class Price
  {

    [XmlElement(ElementName = "PriceAmount")]
    public PriceAmount PriceAmount;
  }

  [XmlRoot(ElementName = "Amount")]
  public class Amount
  {

    [XmlAttribute(AttributeName = "currencyID")]
    public string CurrencyID;

    [XmlText]
    public double Value;
  }

  [XmlRoot(ElementName = "AllowanceCharge")]
  public class AllowanceCharge
  {

    [XmlElement(ElementName = "ChargeIndicator")]
    public bool ChargeIndicator;

    [XmlElement(ElementName = "MultiplierFactorNumeric")]
    public double MultiplierFactorNumeric;

    [XmlElement(ElementName = "Amount")]
    public Amount Amount;
  }

  [XmlRoot(ElementName = "InvoiceLine")]
  public class InvoiceLine
  {

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "InvoicedQuantity")]
    public InvoicedQuantity InvoicedQuantity;

    [XmlElement(ElementName = "LineExtensionAmount")]
    public LineExtensionAmount LineExtensionAmount;

    [XmlElement(ElementName = "AllowanceCharge")]
    public AllowanceCharge AllowanceCharge;

    [XmlElement(ElementName = "Item")]
    public Item Item;

    [XmlElement(ElementName = "Price")]
    public Price Price;
  }

  [XmlRoot(ElementName = "InvoiceDocumentReference")]
  public class DocumentReference
  {

    [XmlElement(ElementName = "ID")]
    public string Id;
  }

  [XmlRoot(ElementName = "BillingReference")]
  public class BillingReference
  {

    [XmlElement(ElementName = "InvoiceDocumentReference")]
    public DocumentReference DocumentReference;
  }


  [XmlRoot(ElementName = "InvoicedPrepaymentAmmount")]
  public class InvoicedPrepaymentAmmount
  {

    [XmlElement(ElementName = "ID")]
    public string ID;

    [XmlElement(ElementName = "TaxTotal")]
    public TaxTotal TaxTotal;
  }

  [XmlRoot(ElementName = "ReducedTotals")]
  public class ReducedTotals
  {

    [XmlElement(ElementName = "TaxTotal")]
    public TaxTotal TaxTotal;

    [XmlElement(ElementName = "LegalMonetaryTotal")]
    public LegalMonetaryTotal LegalMonetaryTotal;
  }

  [XmlRoot(ElementName = "SrbDtExt")]
  public class SrbDtExt
  {

    [XmlElement(ElementName = "InvoicedPrepaymentAmmount")]
    public List<InvoicedPrepaymentAmmount> InvoicedPrepaymentAmmount;

    [XmlElement(ElementName = "ReducedTotals")]
    public ReducedTotals ReducedTotals;
  }

  [XmlRoot(ElementName = "ExtensionContent")]
  public class ExtensionContent
  {

    [XmlElement(ElementName = "SrbDtExt")]
    public SrbDtExt SrbDtExt;
  }

  [XmlRoot(ElementName = "UBLExtension")]
  public class UBLExtension
  {

    [XmlElement(ElementName = "ExtensionContent")]
    public ExtensionContent ExtensionContent;
  }

  [XmlRoot(ElementName = "UBLExtensions")]
  public class UBLExtensions
  {

    [XmlElement(ElementName = "UBLExtension")]
    public UBLExtension UBLExtension;
  }

  [XmlRoot(ElementName = "Invoice")]
  public class Invoice
  {
    [XmlElement(ElementName = "UBLExtensions")]
    public UBLExtensions UBLExtensions;

    [XmlElement(ElementName = "CustomizationID")]
    public string CustomizationId;

    [XmlElement(ElementName = "ID")]
    public string Id;

    [XmlElement(ElementName = "IssueDate")]
    public DateTime IssueDate;

    [XmlElement(ElementName = "DueDate")]
    public DateTime? DueDate;

    [XmlElement(ElementName = "TaxPointDate")]
    public DateTime? TaxPointDate;

    [XmlElement(ElementName = "InvoiceTypeCode")]
    public int InvoiceTypeCode;

    [XmlElement(ElementName = "Note")]
    public string Note;

    [XmlElement(ElementName = "DocumentCurrencyCode")]
    public string DocumentCurrencyCode;

    [XmlElement(ElementName = "InvoicePeriod")]
    public InvoicePeriod InvoicePeriod;

    [XmlElement(ElementName = "BillingReference")]
    public BillingReference BillingReference;

    [XmlElement(ElementName = "OrderReference")]
    public OrderReference OrderReference;

    [XmlElement(ElementName = "ContractDocumentReference")]
    public ContractDocumentReference ContractDocumentReference;

    [XmlElement(ElementName = "OriginatorDocumentReference")]
    public OriginatorDocumentReference OriginatorDocumentReference;

    [XmlElement(ElementName = "AdditionalDocumentReference")]
    public List<AdditionalDocumentReference> AdditionalDocumentReference;

    [XmlElement(ElementName = "AccountingSupplierParty")]
    public AccountingSupplierParty AccountingSupplierParty;

    [XmlElement(ElementName = "AccountingCustomerParty")]
    public AccountingCustomerParty AccountingCustomerParty;

    [XmlElement(ElementName = "Delivery")]
    public Delivery Delivery;

    [XmlElement(ElementName = "PaymentMeans")]
    public PaymentMeans PaymentMeans;

    [XmlElement(ElementName = "TaxTotal")]
    public TaxTotal TaxTotal;

    [XmlElement(ElementName = "LegalMonetaryTotal")]
    public LegalMonetaryTotal LegalMonetaryTotal;

    [XmlElement("InvoiceLine")]
    public List<InvoiceLine> InvoiceLine;
  }

  [XmlRoot(ElementName = "DocumentBody")]
  public class DocumentBody
  {
    [XmlElement(ElementName = "Invoice")]
    public Invoice Invoice;
  }

  [XmlRoot(ElementName = "DocumentEnvelope")]
  public class DocumentEnvelope
  {
    [XmlElement(ElementName = "DocumentHeader")]
    public DocumentHeader DocumentHeader;

    [XmlElement(ElementName = "DocumentBody")]
    public DocumentBody DocumentBody;

    //public string XmlDocument;
  }
}
