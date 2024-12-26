using nte.erp.client.Common;
using System.Data;

namespace nte.erp.client.Invoices.Import
{
  public partial class ControlDetail : ControlBase
  {

    public ControlDetail()
    {
      InitializeComponent();
      this.Desing_Init();
      this.Refresh_Action();
    }

    #region Design
    private void Desing_Init()
    {
      Utils.Styles.SetBody(this.MainTabControl);
      Utils.Styles.SetInputLabel(this.SupplierPartyLabel, this.SupplierPartyMBLabel, this.SupplierPartyPIBLabel, this.SupplierPartyAddress, this.SupplierPartyPaymentTypeLabel, this.SupplierPartyPaymentBankLabel);
      //Utils.Styles.SetInputLabel(this.SupplierPartyContact);
      Utils.Styles.SetInputLabel(this.CustomerPartyLabel, this.CustomerPartyPIBLabel, this.CustomerPartyMBLabel);
      Utils.Styles.SetInputLabel(this.IssueDateLabel, this.DueDateLabel, this.TaxDateLabel);
    }
    #endregion

    public void SetRow(DataRow iRow)
    {
      this.DataInfo = iRow;

      this.SetValue(this.SupplierPartyName, "AccountingSupplierPartyId");
      this.SetValue(this.SupplierPartyPIB, "AccountingSupplierPartyId");
      this.SetValue(this.SupplierPartyMB, "SupplierPartyMB");
      /*
      InvoiceIDLeft
      InvoiceID

      SupplierPartyName
      SupplierPartyPIB
      SupplierPartyMB
      SupplierPartyAddress
      SupplierPartyContact
      SupplierPartyPaymentType
      SupplierPartyPaymentBank

      CustomerPartyName
      CustomerPartyPIB
      CustomerPartyMB
      IssueDate
      DueDate
      TaxDate

      LineExtensionAmount
      TaxAmount
      PayableAmount
      */
    }

    private void Refresh_Action()
    {
      if (this.DataInfo != null)
      {
        switch (Utils.GetAsString(this.DataInfo, "StateUid").ToLower())
        {
          case "new":
            break;
          default:
            break;
        }
      }
      else
      {

      }
    }
  }
}
