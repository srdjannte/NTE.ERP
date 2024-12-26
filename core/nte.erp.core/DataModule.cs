using Newtonsoft.Json.Linq;
using nte.erp.core.Import.Response.PurchaseInvoice;
using System.Data;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace nte.erp.core
{
  public class DataModule
  {
    public string FileName = string.Empty;
    public DataSet Data = new DataSet("Data");
    public SourceModule Source = new SourceModule();
    public string InfoUid = string.Empty;

    #region Data Tables
    public DataTable InvoiceImport
    {
      get
      {
        return this.Data.Tables["erp_invoice_in"];
      }
    }
    public DataRow InvoiceImportNewRow
    {
      get
      {
        DataRow fRow = this.Data.Tables["erp_invoice_in"].NewRow();

        fRow["Uid"] = Guid.NewGuid().ToString();
        fRow["InfoUid"] = this.InfoUid;
        fRow["StateUid"] = DBNull.Value;
        fRow["SyncDate"] = DBNull.Value;
        fRow["SyncRevId"] = 0;
        fRow["SyncSessionUid"] = Guid.NewGuid().ToString();

        return fRow;
      }
    }
    public DataTable InvoiceExport
    {
      get
      {
        return this.Data.Tables["erp_invoice_out"];
      }
    }
    public DataTable Statment
    {
      get
      {
        return this.Data.Tables["Statment"];
      }
    }
    public DataTable Document
    {
      get
      {
        return this.Data.Tables["Document"];
      }
    }    
    public DataRow PartyNewRow
    {
      get
      {
        DataRow fRow = this.Data.Tables["erp_party"].NewRow();

        fRow["Uid"] = Guid.NewGuid().ToString();
        fRow["InfoUid"] = this.InfoUid;
        fRow["StateUid"] = DBNull.Value;
        fRow["SyncDate"] = DBNull.Value;
        fRow["SyncRevId"] = 0;
        fRow["SyncSessionUid"] = Guid.NewGuid().ToString();

        return fRow;
      }
    }
    public DataTable Party
    {
      get
      {
        return this.Data.Tables["erp_party"];
      }
    }
    #endregion

    #region Create
    public DataModule()
    {
    }
    public DataModule(SourceModule iSource, string iFileName)
    {
      this.Source = iSource;
      this.FileName = iFileName;
      this.CreateData();
      if (File.Exists(this.FileName))
      {
        this.Data.ReadXml(this.FileName);
      }
    }
    public DataModule(OwnerItem iOwner)
    {
      string fPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NTE ERP\\";
      this.Source = new SourceModule();
      this.InfoUid = iOwner.Uid;
      if (!Directory.Exists(fPath))
      {
        Directory.CreateDirectory(fPath);
      }
      this.FileName = fPath + ((string.IsNullOrEmpty(iOwner.Name.Trim())) ? "NTEERPDATA-" + iOwner.Uid : iOwner.Name) + ".erp";

      if (File.Exists(this.FileName))
      {
        throw new Exception(string.Format("Can not create new company, file exsists {0}!", this.FileName));
      }
      else
      {
        this.CreateData();
        this.Sync(iOwner);
        this.Save();
      }
    }
    private void CreateData()
    {
      this.Data = new DataSet("Data");

      #region Owner
      DataTable fOwner = new DataTable("erp_info");

      fOwner.Columns.Add(this.GetColumn("Id"));
      fOwner.Columns.Add(this.GetColumn("Uid"));
      fOwner.Columns.Add(this.GetColumn("StateUid"));
      fOwner.Columns.Add(this.GetColumn("SyncDate"));
      fOwner.Columns.Add(this.GetColumn("SyncRevId"));
      fOwner.Columns.Add(this.GetColumn("SyncSessionUid"));

      fOwner.Columns.Add(this.GetColumn("ApiKey"));
      fOwner.Columns.Add(this.GetColumn("LicenceType"));
      fOwner.Columns.Add(this.GetColumn("Name"));
      fOwner.Columns.Add(this.GetColumn("ContactName"));
      fOwner.Columns.Add(this.GetColumn("ContactEmail"));
      fOwner.Columns.Add(this.GetColumn("AddressStreetName"));
      fOwner.Columns.Add(this.GetColumn("AddressCityName"));
      fOwner.Columns.Add(this.GetColumn("AddressPostalZone"));
      fOwner.Columns.Add(this.GetColumn("AddressCountryIdentificationCode"));
      fOwner.Columns.Add(this.GetColumn("TaxSchemeId"));
      fOwner.Columns.Add(this.GetColumn("TaxSchemeCompanyId"));
      fOwner.Columns.Add(this.GetColumn("TaxSchemeRegistrationName"));
      fOwner.Columns.Add(this.GetColumn("LegalEntityCompanyId"));
      fOwner.Columns.Add(this.GetColumn("LegalEntityRegistrationName"));
      fOwner.Columns.Add(this.GetColumn("Source"));

      this.Data.Tables.Add(fOwner);
      #endregion

      #region Invoice Import
      DataTable fInvoiceImport = new DataTable("erp_invoice_in");

      fInvoiceImport.Columns.Add(this.GetColumn("Id"));
      fInvoiceImport.Columns.Add(this.GetColumn("Uid"));
      fInvoiceImport.Columns.Add(this.GetColumn("InfoUid"));
      fInvoiceImport.Columns.Add(this.GetColumn("StateUid"));
      fInvoiceImport.Columns.Add(this.GetColumn("SyncDate"));
      fInvoiceImport.Columns.Add(this.GetColumn("SyncRevId"));
      fInvoiceImport.Columns.Add(this.GetColumn("SyncSessionUid"));

      fInvoiceImport.Columns.Add(this.GetColumn("DocumentId", "DocumentId", "System.Int32"));
      fInvoiceImport.Columns.Add(this.GetColumn("CustomizationId"));
      fInvoiceImport.Columns.Add(this.GetColumn("InvoiceId"));
      fInvoiceImport.Columns.Add(this.GetColumn("IssueDate", "", "System.DateTime"));
      fInvoiceImport.Columns.Add(this.GetColumn("DueDate", "", "System.DateTime"));
      fInvoiceImport.Columns.Add(this.GetColumn("TaxPointDate", "", "System.DateTime"));
      fInvoiceImport.Columns.Add(this.GetColumn("InvoiceTypeCode", "", "System.Int32"));
      fInvoiceImport.Columns.Add(this.GetColumn("DocumentCurrencyCode", "", "System.String"));
      fInvoiceImport.Columns.Add(this.GetColumn("InvoicePeriodCode", "", "System.Int32"));
      fInvoiceImport.Columns.Add(this.GetColumn("AccountingSupplierPartyId", "", "System.Int32"));
      fInvoiceImport.Columns.Add(this.GetColumn("AccountingCustomerPartyId", "", "System.Int32"));
      fInvoiceImport.Columns.Add(this.GetColumn("ActualDeliveryDate", "", "System.DateTime"));
      fInvoiceImport.Columns.Add(this.GetColumn("PaymentMeansId", "", "System.String"));
      fInvoiceImport.Columns.Add(this.GetColumn("PaymentMeansCode", "", "System.Int32"));
      fInvoiceImport.Columns.Add(this.GetColumn("PaymentId"));
      fInvoiceImport.Columns.Add(this.GetColumn("PayerFinancialAccountId"));
      fInvoiceImport.Columns.Add(this.GetColumn("PayeeFinancialAccountId"));
      fInvoiceImport.Columns.Add(this.GetColumn("TotalAmount", "", "System.Single"));
      fInvoiceImport.Columns.Add(this.GetColumn("Note"));
      fInvoiceImport.Columns.Add(this.GetColumn("DocumentReferenceId"));
      fInvoiceImport.Columns.Add(this.GetColumn("ContractDocumentReferenceId"));
      fInvoiceImport.Columns.Add(this.GetColumn("OriginatorDocumentReferenceId"));
      fInvoiceImport.Columns.Add(this.GetColumn("OrderReferenceId"));

      this.Data.Tables.Add(fInvoiceImport);
      #endregion

      #region Invoice Export
      DataTable fInvoiceExport = new DataTable("erp_invoice_out");

      fInvoiceExport.Columns.Add(this.GetColumn("Id", "Id", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("Uid", "Uid", "System.String", false, true));
      fInvoiceExport.Columns.Add(this.GetColumn("StateId", "", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("InfoId", "", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("DocumentId", "DocumentId", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("CustomizationId", "CustomizationId"));
      fInvoiceExport.Columns.Add(this.GetColumn("InvoiceId", "InvoiceId", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("IssueDate", "IssueDate", "System.DateTime"));
      fInvoiceExport.Columns.Add(this.GetColumn("DueDate", "DueDate", "System.DateTime"));
      fInvoiceExport.Columns.Add(this.GetColumn("TaxPointDate", "TaxPointDate", "System.DateTime"));
      fInvoiceExport.Columns.Add(this.GetColumn("InvoiceTypeCode", "InvoiceTypeCode", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("DocumentCurrencyCode", "DocumentCurrencyCode", "System.String"));
      fInvoiceExport.Columns.Add(this.GetColumn("InvoicePeriodCode", "InvoicePeriodCode", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("AccountingSupplierPartyId", "AccountingSupplierPartyId", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("AccountingCustomerPartyId", "AccountingCustomerPartyId", "System.Int32"));
      fInvoiceExport.Columns.Add(this.GetColumn("ActualDeliveryDate", "ActualDeliveryDate", "System.DateTime"));
      fInvoiceExport.Columns.Add(this.GetColumn("PaymentMeansId", "PaymentMeansId", "System.String"));
      fInvoiceExport.Columns.Add(this.GetColumn("PaymentMeansCode", "PaymentMeansCode", "System.Int32"));

      this.Data.Tables.Add(fInvoiceExport);
      #endregion

      #region Codebook

      #region Party
      DataTable fParty = new DataTable("erp_party");

      fParty.Columns.Add(this.GetColumn("Id"));
      fParty.Columns.Add(this.GetColumn("Uid"));
      fParty.Columns.Add(this.GetColumn("InfoUid"));
      fParty.Columns.Add(this.GetColumn("StateUid"));
      fParty.Columns.Add(this.GetColumn("SyncDate"));
      fParty.Columns.Add(this.GetColumn("SyncRevId"));
      fParty.Columns.Add(this.GetColumn("SyncSessionUid"));

      //fParty.Columns.Add(this.GetColumn("Id", "Id", "System.Int32"));
      //fParty.Columns.Add(this.GetColumn("Uid", "Uid", "System.String", false, true));
      fParty.Columns.Add(this.GetColumn("EndpointId"));
      fParty.Columns.Add(this.GetColumn("EndpointSchemeId", "EndpointSchemeId", "System.Int32"));
      fParty.Columns.Add(this.GetColumn("IdentificationId"));
      fParty.Columns.Add(this.GetColumn("Name"));
      fParty.Columns.Add(this.GetColumn("AddressStreetName"));
      fParty.Columns.Add(this.GetColumn("AddressCityName"));
      fParty.Columns.Add(this.GetColumn("AddressPostalZone"));
      fParty.Columns.Add(this.GetColumn("AddressCountryIdentificationCode"));
      fParty.Columns.Add(this.GetColumn("TaxSchemeId"));
      fParty.Columns.Add(this.GetColumn("TaxSchemeCompanyId"));
      fParty.Columns.Add(this.GetColumn("TaxSchemeRegistrationName"));
      fParty.Columns.Add(this.GetColumn("LegalEntityCompanyId"));
      fParty.Columns.Add(this.GetColumn("LegalEntityRegistrationName"));
      fParty.Columns.Add(this.GetColumn("ContactName"));
      fParty.Columns.Add(this.GetColumn("ContactEmail"));

      this.Data.Tables.Add(fParty);
      #endregion

      #region UnitMeasure
      DataTable fUnitMeasure = new DataTable("erp_cb_unitmeasure");

      fUnitMeasure.Columns.Add(this.GetColumn("Id", "Id", "System.Int32"));
      fUnitMeasure.Columns.Add(this.GetColumn("Uid", "Uid", "System.String", false, true));
      fUnitMeasure.Columns.Add(this.GetColumn("Code"));
      fUnitMeasure.Columns.Add(this.GetColumn("NameCyr"));
      fUnitMeasure.Columns.Add(this.GetColumn("NameLat"));
      fUnitMeasure.Columns.Add(this.GetColumn("NameEng"));
      fUnitMeasure.Columns.Add(this.GetColumn("SyncDate"));

      this.Data.Tables.Add(fUnitMeasure);
      #endregion

      #region InvoiceTypeCode
      DataTable fInvoiceTypeCode = new DataTable("InvoiceTypeCode");

      fInvoiceTypeCode.Columns.Add(this.GetColumn("Id", "Id", "System.Int32"));
      fInvoiceTypeCode.Columns.Add(this.GetColumn("Uid", "Uid", "System.String", false, true));
      fInvoiceTypeCode.Columns.Add(this.GetColumn("Code"));
      fInvoiceTypeCode.Columns.Add(this.GetColumn("NameCyr"));
      fInvoiceTypeCode.Columns.Add(this.GetColumn("NameLat"));
      fInvoiceTypeCode.Columns.Add(this.GetColumn("NameEng"));
      fInvoiceTypeCode.Columns.Add(this.GetColumn("SyncDate"));

      this.Data.Tables.Add(fInvoiceTypeCode);
      #endregion

      #region InvoiceTaxExemptionReasonList
      DataTable fInvoiceTaxExemptionReasonList = new DataTable("InvoiceTaxExemptionReasonList");

      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Id", "Id", "System.Int32"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Uid", "Uid", "System.String", false, true));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Code"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("NameCyr"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("NameLat"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("NameEng"));

      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("ReasonId"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Key"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Law"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Article"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Paragraph"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Point"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Subpoint"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Text"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("FreeFormNote"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("ActiveFrom"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("ActiveTo"));
      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("Category"));

      fInvoiceTaxExemptionReasonList.Columns.Add(this.GetColumn("SyncDate"));

      this.Data.Tables.Add(fInvoiceTaxExemptionReasonList);
      #endregion

      #region InvoicePeriodCode
      DataTable fInvoicePeriodCode = new DataTable("InvoicePeriodCode");

      fInvoicePeriodCode.Columns.Add(this.GetColumn("Id", "Id", "System.Int32"));
      fInvoicePeriodCode.Columns.Add(this.GetColumn("Uid", "Uid", "System.String", false, true));
      fInvoicePeriodCode.Columns.Add(this.GetColumn("Code"));
      fInvoicePeriodCode.Columns.Add(this.GetColumn("NameCyr"));
      fInvoicePeriodCode.Columns.Add(this.GetColumn("NameLat"));
      fInvoicePeriodCode.Columns.Add(this.GetColumn("NameEng"));
      fInvoicePeriodCode.Columns.Add(this.GetColumn("SyncDate"));

      this.Data.Tables.Add(fInvoicePeriodCode);
      #endregion

      #endregion
    }
    #endregion

    #region Actions
    public void Save()
    {
      this.Data.WriteXml(this.FileName);
    }
    private DataColumn GetColumn(string iName, string iCaption = "", string iType = "System.String", bool iAllowDBNull = true, bool iUnique = false, object iDefaultValue = null)
    {
      DataColumn fCol = new DataColumn();

      fCol.ColumnName = iName;
      fCol.Caption = (iCaption != "") ? iCaption : iName;

      switch (iName)
      {
        case "Id":
          fCol.DataType = System.Type.GetType("System.Int32");
          fCol.AllowDBNull = true;
          break;
        case "Uid":
          fCol.DataType = System.Type.GetType("System.Guid");
          fCol.AllowDBNull = false;
          fCol.Unique = true;
          break;
        case "InfoUid":
          fCol.DataType = System.Type.GetType("System.Guid");
          fCol.AllowDBNull = false;
          fCol.Unique = false;
          break;
        case "StateUid":
          fCol.DataType = System.Type.GetType("System.String");
          fCol.AllowDBNull = true;
          break;
        case "SyncDate":
          fCol.DataType = System.Type.GetType("System.DateTime");
          fCol.AllowDBNull = true;
          break;
        case "SyncRevId":
          fCol.DataType = System.Type.GetType("System.Int32");
          fCol.DefaultValue = 0;
          break;
        case "SyncUserUid":
          fCol.DataType = System.Type.GetType("System.Guid");
          break;
        default:
          fCol.DataType = System.Type.GetType(iType);
          fCol.AllowDBNull = iAllowDBNull;
          fCol.Unique = iUnique;
          if (iDefaultValue != null)
          {
            fCol.DefaultValue = iDefaultValue;
          }
          break;
      }



      return fCol;
    }
    #endregion

    #region Sync
    public bool Sync(OwnerItem iOwner)
    {
      if (this.Data.Tables.Contains("erp_info"))
      {
        bool fNotFound = true;

        foreach (DataRow fOwner in this.Data.Tables["erp_info"].Rows)
        {
          if (fOwner["Uid"].ToString() == iOwner.Uid)
          {
            fOwner["ApiKey"] = iOwner.ApiKey;
            fOwner["LicenceType"] = iOwner.LicenceType;
            fOwner["Name"] = iOwner.Name;
            fOwner["ContactName"] = iOwner.ContactName;
            fOwner["ContactEmail"] = iOwner.ContactEmail;
            fOwner["AddressStreetName"] = iOwner.AddressStreetName;
            fOwner["AddressCityName"] = iOwner.AddressCityName;
            fOwner["AddressPostalZone"] = iOwner.AddressPostalZone;
            fOwner["AddressCountryIdentificationCode"] = iOwner.AddressCountryIdentificationCode;
            fOwner["TaxSchemeId"] = iOwner.TaxSchemeId;
            fOwner["TaxSchemeCompanyId"] = iOwner.TaxSchemeCompanyId;
            fOwner["TaxSchemeRegistrationName"] = iOwner.TaxSchemeRegistrationName;
            fOwner["LegalEntityCompanyId"] = iOwner.Name;
            fOwner["LegalEntityRegistrationName"] = iOwner.LegalEntityRegistrationName;
            fOwner["Source"] = iOwner.Source.AsXML();

            fNotFound = false;
          }
        }

        if (fNotFound)
        {
          DataRow fOwner = this.Data.Tables["erp_info"].NewRow();

          fOwner["Uid"] = iOwner.Uid;
          fOwner["ApiKey"] = iOwner.ApiKey;
          fOwner["LicenceType"] = iOwner.LicenceType;
          fOwner["Name"] = iOwner.Name;
          fOwner["ContactName"] = iOwner.ContactName;
          fOwner["ContactEmail"] = iOwner.ContactEmail;
          fOwner["AddressStreetName"] = iOwner.AddressStreetName;
          fOwner["AddressCityName"] = iOwner.AddressCityName;
          fOwner["AddressPostalZone"] = iOwner.AddressPostalZone;
          fOwner["AddressCountryIdentificationCode"] = iOwner.AddressCountryIdentificationCode;
          fOwner["TaxSchemeId"] = iOwner.TaxSchemeId;
          fOwner["TaxSchemeCompanyId"] = iOwner.TaxSchemeCompanyId;
          fOwner["TaxSchemeRegistrationName"] = iOwner.TaxSchemeRegistrationName;
          fOwner["LegalEntityCompanyId"] = iOwner.Name;
          fOwner["LegalEntityRegistrationName"] = iOwner.LegalEntityRegistrationName;
          fOwner["Source"] = iOwner.Source.AsXML();

          this.Data.Tables["erp_info"].Rows.Add(fOwner);
        }

        return true;
      }

      return false;
    }
    #endregion

    #region XML Object 
    private string GetParent(XElement iNode)
    {
      string fStr = "";

      if (iNode.Parent != null)
      {
        XElement fNode = iNode.Parent;

        while (fNode != null)
        {
          fStr = "/" + fNode.Name.LocalName + fStr;

          fNode = fNode.Parent;
        }
      }

      return fStr;
    }
    private Dictionary<string, object> GetAttributes(Dictionary<string, object>  iDict, XElement iNode, string iKey)
    {

      if (iNode != null)
      {
        foreach (var attribute in iNode.Attributes())
        {
          string value = attribute.Value;
          string fKey = iKey + "/" + attribute.Name;

          iDict.Add(fKey, attribute.Value);          
        }
      }

      return iDict;
    }
    public bool GetXML(string iStrXml, out XDocument oDoc)
    {
      oDoc = null;

      if (!string.IsNullOrEmpty(iStrXml))
      {
        oDoc = XDocument.Parse(iStrXml);

        return true;
      }

      return false;
    }
    public bool GetXML(string iStrXml, out Dictionary<string, object> oDict)
    {
      oDict = new Dictionary<string, object>();

      if (!string.IsNullOrEmpty(iStrXml))
      {
        var fDoc = XDocument.Parse(iStrXml);
        
        var fRes = fDoc.Descendants().Where(p => p.Name.LocalName != "").ToList();

        for (int i = 0; i < fRes.Count; i++)
        {
          if (fRes[i].Nodes().Count() == 1)
          {
            string fParent = GetParent(fRes[i]);
            string fKey = fParent + "/" + fRes[i].Name.LocalName;
            oDict.Add(fKey, fRes[i].Value);
            oDict = this.GetAttributes(oDict, fRes[i], fKey);
          }
        }

        return true;
      }


      return false;
    }
    #endregion
  }
}
