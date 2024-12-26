namespace nte.erp.core.Invoice
{
  public class InvoiceBase
  {
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public string CustomizationId { get; set; }
    public string InvoiceId { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? TaxPointDate { get; set; }
    public int InvoiceTypeCode { get; set; }
    public string DocumentCurrencyCode { get; set; }
    public int InvoicePeriodCode { get; set; }
    public int AccountingSupplierPartyId { get; set; }
    public int AccountingCustomerPartyId { get; set; }
    public DateTime? ActualDeliveryDate { get; set; }
    public string PaymentMeansId { get; set; }
    public int PaymentMeansCode { get; set; }
    public string PaymentId { get; set; }
    public string PayerFinancialAccountId { get; set; }
    public string PayeeFinancialAccountId { get; set; }
    public decimal TotalAmount { get; set; }
    public string OrderReferenceId { get; set; }
    public string DocumentReferenceId { get; set; }
    public string ContractDocumentReferenceId { get; set; }
    public string OriginatorDocumentReferenceId { get; set; }
    public string Note { get; set; }
  }
}
/*

  <idfakture>18240</idfakture>
  <InvoiceID>RN-1590/2024</InvoiceID>
  <InvoiceIssueDate>2024-11-20T00:00:00+01:00</InvoiceIssueDate>
  <konacna>0</konacna>
  <DueDate>2024-09-13T00:00:00+02:00</DueDate>
  <InvoiceTypeCode>380</InvoiceTypeCode>
  <TimeNote>07:20:00</TimeNote>
  <OperaterNote>Vesna PavloviÄ‡</OperaterNote>
  <ResponiblePersonNote>Vesna PavloviÄ‡</ResponiblePersonNote>
  <DocumentNote></DocumentNote>
  <DocumentCurrencyCode>RSD</DocumentCurrencyCode>
  <StartDate>2024-09-01</StartDate>
  <Endate>2024-09-12T00:00:00+02:00</Endate>
  <DescriptionCode>35</DescriptionCode>
  <DispetchDocumentReferenceID />
  <OriginatorDocumentReferenceID />
  <ContractDocumentReferenceID>263/24</ContractDocumentReferenceID>
  <AdditionalDocumentReferenceID>RN-1590-2024</AdditionalDocumentReferenceID>
  <FilePath>\\192.168.12.13\nte\Komecijala\PDF\Faktura_RN-1590-2024_1.pdf</FilePath>
  <FilePath2>\\192.168.12.13\nte\Komecijala\PDF\Faktura_RN-1590-2024_2.pdf</FilePath2>

  <PartySchmeID>9948</PartySchmeID>
  <PartyEndPiont>103205500</PartyEndPiont>
  <PartyidentificatioID>JBKJS:72645</PartyidentificatioID>
  <PartyName>PRO TENT D.O.O. OBRENOVAC</PartyName>
  <PostalAdressStreatAdress>Savska 24, UÅ¡Ä‡e</PostalAdressStreatAdress>
  <PostalAdressCityName>Obrenovac</PostalAdressCityName>
  <PostalAdressZone>11500</PostalAdressZone>
  <PostalAdressLine>Savska 24, UÅ¡Ä‡e,11500 Obrenovac</PostalAdressLine>

  <CoyntryIdentificationCode>RS</CoyntryIdentificationCode>

  <PartyTaxSchemeCompanyID>RS103205500</PartyTaxSchemeCompanyID>
  <PartyTaxSchemeID>VAT</PartyTaxSchemeID>
  <PartylegalEntityName>PRO TENT D.O.O. OBRENOVAC</PartylegalEntityName>
  <PartylegalEntityCmpanyid>17522124</PartylegalEntityCmpanyid>
  <PartylegalEntityForm />

  <ContactName>Vesna PavloviÄ‡</ContactName>
  <Contacttel>0112054800 </Contacttel>
  <ContactEmail>ulaznefakture@protent.rs</ContactEmail>
  <CustomerPartyEndPiont>104123739</CustomerPartyEndPiont>
  <CustomerPartyName>IMD METAL CO DOO BEOGRAD</CustomerPartyName>
  <CustomerPostalAdressStreatAdress>Koste Nadja 34 A - lokal 6</CustomerPostalAdressStreatAdress>
  <CustomerPostalAdressCityName>Beograd - Zvezdara</CustomerPostalAdressCityName>
  <CustomerPostalAdressZone>11160</CustomerPostalAdressZone>
  <CustomerPostalAdressLine>Koste Nadja 34 A - lokal 6,11160 Beograd - Zvezdara</CustomerPostalAdressLine>
  <CustomerCoyntryIdentificationCode>RS</CustomerCoyntryIdentificationCode>
  <CustomerPartyTaxSchemeCompanyID>RS104123739</CustomerPartyTaxSchemeCompanyID>
  <CustomerPartyTaxSchemeID>VAT</CustomerPartyTaxSchemeID>
  <CustomerPartylegalEntityName>IMD METAL CO DOO BEOGRAD</CustomerPartylegalEntityName>
  <CustomerPartylegalEntityCmpanyid>20095334</CustomerPartylegalEntityCmpanyid>
  <CustomerPartylegalEntityForm />
  <CustomerContactName />
  <CustomerContacttel>011/3435-170</CustomerContacttel>
  <CustomerContactEmail>imdmetalco@yahoo.co.uk</CustomerContactEmail>

  <Diliverydate>2024-09-12T00:00:00+02:00</Diliverydate>
  <DiliveryStreatName />
  <DiliveryCityName />
  <DiliveryPostalZone>11160</DiliveryPostalZone>

  <PaymentMeansCode>42</PaymentMeansCode>
  <PaymentMeansID>RN-1590/2024</PaymentMeansID>
  <PaymeeFinancialAccountID>160-0000000551416-66</PaymeeFinancialAccountID>
  <PaymentTermsNote />

  <TaxTotalAmount>700.00</TaxTotalAmount>
  <TaxSubTotaltaxableAmount>3500.00</TaxSubTotaltaxableAmount>
  <TaxSubTotalAmount>700.00</TaxSubTotalAmount>
  <TaxCategotyID>S</TaxCategotyID>
  <TaxCategotypervent>20</TaxCategotypervent>
  <TaxExemptionReason />

  <LineExtencionalAmount>3500.00</LineExtencionalAmount>

  <TaxExclusiveAmount>3500.00</TaxExclusiveAmount>
  <TaxInclusiveAmount>4200.00</TaxInclusiveAmount>

  <CharrgeTotalAmount>0</CharrgeTotalAmount>

  <PaybleAmount>4200.00</PaybleAmount>

  <TaxSchemeID>VAT</TaxSchemeID>

  <ClasifiedTaxExemptionReason>0</ClasifiedTaxExemptionReason>

  <RegistertoCRF>0</RegistertoCRF>

 */