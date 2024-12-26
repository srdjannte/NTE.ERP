using nte.erp.client.Common;
using System.Data;

namespace nte.erp.client.Invoices.Import
{
  public partial class FormDetail : FormBase
  {
    public FormDetail()
    {
      InitializeComponent();
    }
    public FormDetail(DataRow iRow)
    {
      InitializeComponent();
      Utils.Styles.SetBody(this.PanelBody);
      Utils.Styles.SetCmd(this.PanelCmd);
      this.PanelBody.SetRow(iRow);
    }

    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doClose)
      {
        //this.PanelBody.isChanged();
        this.Close();
      }
    }
  }
}
