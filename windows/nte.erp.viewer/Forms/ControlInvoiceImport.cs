using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceDB.Data.Model;

namespace nte.erp.viewer
{
  public partial class ControlInvoiceImport : ControlBase
  {
    public ControlInvoiceImport()
    {
      InitializeComponent();
      
      List<Invoice> fInvoices = new List<Invoice>();

      for(int i = 0; i < 5; i++)
      {
        Invoice fInvoice = new Invoice();
        fInvoice.InvoiceId = (10000+i).ToString();
        fInvoices.Add(fInvoice);
      }

      this.ListGrid.DataSource = fInvoices;
    }
  }
}
