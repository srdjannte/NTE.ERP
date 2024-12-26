using nte.erp.client.Common;

namespace nte.erp.client.Statements
{
  public partial class ControlList : ControlBase
  {
    public ControlList()
    {
      InitializeComponent();
      this.ListGrid.AutoGenerateColumns = false;
      this.ListGrid.DataSource = Utils.Data.Party;
    }
  }
}
