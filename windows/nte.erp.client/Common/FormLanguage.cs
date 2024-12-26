using System.Data;

namespace nte.erp.client.Common
{
  public partial class FormLanguage : Form
  {
    public String LangFile = "lang.xml";
    public String FormName = "unknown";
    private DataTable LangTB = null;
    private DataTable dtLanguage = new DataTable();
    private DataSet Lang = new DataSet();

    public FormLanguage()
    {
      InitializeComponent();
      dtLanguage = new DataTable();
      dtLanguage.TableName = "Language";
      dtLanguage.Columns.Add("FormName", typeof(string));
      dtLanguage.Columns.Add("ControlName", typeof(string));
      dtLanguage.Columns.Add("ControlType", typeof(string));
      dtLanguage.Columns.Add("ControlProp", typeof(string));
      dtLanguage.Columns.Add("ControlText", typeof(string));
      dtLanguage.Columns.Add("LangCode", typeof(string));
      dtLanguage.Columns.Add("LangTran", typeof(bool));
      dtLanguage.Columns.Add("LangText", typeof(string));

      this.Lang.Tables.Add(dtLanguage);
    }

    public void SetFormName(String iFormName)
    {
      this.FormName = iFormName;
    }

    public void SetShow()
    {

      if (this.LangTB == null)
      {
        this.LangTB = new DataTable();
        this.LangTB.TableName = "Language";
        this.LangTB.Columns.Add("FormName", typeof(string));
        this.LangTB.Columns.Add("ControlName", typeof(string));
        this.LangTB.Columns.Add("ControlType", typeof(string));
        this.LangTB.Columns.Add("ControlProp", typeof(string));
        this.LangTB.Columns.Add("ControlText", typeof(string));
        this.LangTB.Columns.Add("LangCode", typeof(string));
        this.LangTB.Columns.Add("LangTran", typeof(bool));
        this.LangTB.Columns.Add("LangText", typeof(string));
      }

      if (File.Exists(this.LangFile))
      {
        this.Lang.ReadXml(this.LangFile);
        this.FormNameSelected.Text = this.FormName;
        this.FormNameSelected.Enabled = false;

        if (!String.IsNullOrEmpty(this.FormName))
        {
          this.Lang.Tables[0].DefaultView.RowFilter = string.Format("FormName LIKE '{0}%'", this.FormName);
          this.LangGrid.DataMember = "";
          this.LangGrid.DataSource = this.Lang.Tables[0];
        }
      }

      this.ShowDialog();
    }

    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doSave)
      {
        if (File.Exists(this.LangFile))
        {
          this.Lang.WriteXml(this.LangFile);
        }
        else
        {
          this.Lang.WriteXml(this.LangFile);
        }
      }
    }
  }
}
