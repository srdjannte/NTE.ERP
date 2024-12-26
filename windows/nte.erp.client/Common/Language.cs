using System.Data;

namespace nte.erp.client.Common
{
  public class Language
  {
    public String LangFile = "lang.xml";
    public String LangCode = "EN";

    private DataTable LangTB = null;
    private String LangFormName;
    private List<LanguageItem> LangFormControls;

    public Language(String iLangFile = "lang.xml")
    {
      try
      {
        string fEDir = Path.GetDirectoryName(Application.ExecutablePath);
        this.LangFile = fEDir + "\\" + iLangFile;

        string fCData = Application.CommonAppDataPath;
        string fNewFile = fCData + "\\" + iLangFile;
        if (File.Exists(fNewFile))
        {
          this.LangFile = fNewFile;
        }
      }
      catch (Exception ex)
      {
        Utils.SetException(ex);
      }
    }

    private bool TryFind(String iControlName, String iPropName, out DataRowView oRow)
    {
      oRow = null;
      DataView dv = new DataView(this.LangTB);
      dv.RowFilter = String.Format("(FormName = '{0}') AND (ControlName='{1}') AND (ControlProp='{2}')", this.LangFormName, iControlName, iPropName);
      if (0 < dv.Count)
      {
        if ((Convert.ToBoolean(dv[0]["LangTran"] != DBNull.Value) && (Convert.ToBoolean(dv[0]["LangTran"]))))
        {
          oRow = dv[0];
          return true;
        }
      }

      return false;
    }

    private bool ControlExists(String iControlName, String iPropName)
    {
      DataView dv = new DataView(this.LangTB);
      dv.RowFilter = String.Format("(FormName = '{0}') AND (ControlName='{1}') AND (ControlProp='{2}')", this.LangFormName, iControlName, iPropName);
      if (0 < dv.Count)
      {
        return true;
      }

      return false;
    }

    private void GetControlItem(ToolStripItem iControl)
    {
      if ((iControl is ToolStripMenuItem) && (0 < (iControl as ToolStripMenuItem).DropDownItems.Count))
      {
        foreach (ToolStripItem fCtrl in (iControl as ToolStripMenuItem).DropDownItems)
        {
          DataRowView fRow;
          if (this.TryFind(fCtrl.Name, "Text", out fRow))
          {
            if (Convert.ToBoolean(fRow["LangTran"]))
            {
              fCtrl.Text = Convert.ToString(fRow["LangText"]);
            }
          }
          else
          {
            LanguageItem fItem = new LanguageItem(fCtrl, "Text", this.LangFormName, this.LangCode);
            this.LangFormControls.Add(fItem);
          }
          this.GetControlItem(fCtrl);
        }
      }
    }

    private void GetControls(System.Windows.Forms.Control container)
    {
      foreach (System.Windows.Forms.Control c in container.Controls)
      {
        GetControls(c);

        Boolean CtnKnow = false;

        if (c is MenuStrip)
        {
          foreach (System.Windows.Forms.ToolStripMenuItem c1 in (c as MenuStrip).Items)
          {
            DataRowView fRow;
            if (this.TryFind(c1.Name, "Text", out fRow))
            {
              if (Convert.ToBoolean(fRow["LangTran"]))
              {
                c1.Text = Convert.ToString(fRow["LangText"]);
              }
            }
            else
            {
              LanguageItem fItem = new LanguageItem(c1, "Text", this.LangFormName, this.LangCode);
              this.LangFormControls.Add(fItem);
            }
            this.GetControlItem(c1);
          }

          CtnKnow = true;
        }

        if (c is ToolStrip)
        {
          foreach (System.Windows.Forms.ToolStripItem c1 in (c as ToolStrip).Items)
          {
            DataRowView fRow;
            if (this.TryFind(c1.Name, "Text", out fRow))
            {
              if (Convert.ToBoolean(fRow["LangTran"]))
              {
                c1.Text = Convert.ToString(fRow["LangText"]);
              }
            }
            else
            {
              LanguageItem fItem = new LanguageItem(c1, "Text", this.LangFormName, this.LangCode);
              this.LangFormControls.Add(fItem);
            }
          }

          CtnKnow = true;
        }

        if (!CtnKnow)
        {
          DataRowView fRow;
          if (this.TryFind(c.Name, "Text", out fRow))
          {
            if (Convert.ToBoolean(fRow["LangTran"]))
            {
              c.Text = Convert.ToString(fRow["LangText"]);
            }
          }
          else
          {
            LanguageItem fItem = new LanguageItem(c, "Text", this.LangFormName, this.LangCode);
            this.LangFormControls.Add(fItem);
          }
        }
      }
    }

    public String Translate(Form iForm, String iWord)
    {
      if (File.Exists(this.LangFile))
      {
        this.LangFormName = iForm.Name;
        this.LangFormControls = new List<LanguageItem>();
        this.LangTB = Utils.GetTableFromString(File.ReadAllText(this.LangFile, System.Text.Encoding.UTF8), 0);
        if (0 < this.LangTB.Rows.Count)
        {
          //DataRowView fRow;
          //if (this.TryFind(iForm.Name, "Word", iWord, out fRow))
          //{
          //  if (Convert.ToBoolean(fRow["LangTran"]))
          //  {
          //    iForm.Text = Convert.ToString(fRow["LangText"]);
          //  }
          //}
        }
      }

      return iWord;
    }

    public void Translate(Form iForm)
    {
      if (!File.Exists(this.LangFile))
      {
        return;
      }

      this.LangFormName = iForm.Name;
      this.LangFormControls = new List<LanguageItem>();
      this.LangTB = Utils.GetTableFromString(File.ReadAllText(this.LangFile, System.Text.Encoding.UTF8), 0);

      if (this.LangTB != null && 0 < this.LangTB.Rows.Count)
      {
        DataRowView fRow;
        if (this.TryFind(iForm.Name, "Text", out fRow))
        {
          if (Convert.ToBoolean(fRow["LangTran"]))
          {
            iForm.Text = Convert.ToString(fRow["LangText"]);
          }
        }

        this.GetControls(iForm);
        this.LangFormControls = new List<LanguageItem>();
        this.LangTB = null;
      }
    }

    public void SetLanguage(Form iForm, Boolean iReload = false)
    {
      String fLangFile = this.LangFile;// "lang.xml";
      this.LangFormName = iForm.Name;
      this.LangFormControls = new List<LanguageItem>();

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

        iReload = true;
      }

      if (iReload)
      {
        if (File.Exists(fLangFile))
        {
          this.LangTB = Utils.GetTableFromString(File.ReadAllText(fLangFile, System.Text.Encoding.UTF8), 0);
        }
      }

      this.GetControls(iForm);

      if (this.LangTB != null && !this.ControlExists(iForm.Name, "Text"))
      {
        DataRow fRow = this.LangTB.NewRow();

        fRow["FormName"] = iForm.Name;
        fRow["ControlName"] = iForm.Name;
        fRow["ControlType"] = iForm.GetType().ToString();
        fRow["ControlProp"] = "Text";
        fRow["ControlText"] = iForm.Text;
        fRow["LangCode"] = "";
        fRow["LangTran"] = false;
        fRow["LangText"] = "";

        this.LangTB.Rows.Add(fRow);
      }

      if (0 < this.LangFormControls.Count)
      {
        foreach (LanguageItem fItem in this.LangFormControls)
        {
          if (!this.ControlExists(fItem.ControlName, fItem.ControlProp))
          {
            DataRow fRow = this.LangTB.NewRow();

            fRow["FormName"] = fItem.FormName;
            fRow["ControlName"] = fItem.ControlName;
            fRow["ControlType"] = fItem.ControlType;
            fRow["ControlProp"] = fItem.ControlProp;
            fRow["ControlText"] = fItem.ControlText;
            fRow["LangCode"] = fItem.LangCode;
            fRow["LangTran"] = fItem.LangTran;
            fRow["LangText"] = fItem.LangText;

            this.LangTB.Rows.Add(fRow);
          }
        }

        File.WriteAllText(fLangFile, Utils.GetStringFromTable(this.LangTB), System.Text.Encoding.UTF8);
        this.LangFormControls = new List<LanguageItem>();
      }
    }

    #region Item
    public class LanguageItem
    {
      public string FormName { get; set; }
      public string ControlName { get; set; }
      public string ControlType { get; set; }
      public string ControlProp { get; set; }
      public string ControlText { get; set; }
      public string LangCode { get; set; }
      public bool LangTran { get; set; }
      public string LangText { get; set; }
      public LanguageItem(System.Windows.Forms.Control iControl, String iProp, String iFormName, String iLangType)
      {
        /*if (c is TextBox) this.LangFormControls.Add(c);
				if (c is Label) this.LangFormControls.Add(c);
				if (c is ToolStripButton) this.LangFormControls.Add(c);
				if (c is ToolStripMenuItem) this.LangFormControls.Add(c);*/

        this.FormName = iFormName;
        this.ControlName = iControl.Name;
        this.ControlType = iControl.GetType().ToString();
        this.ControlProp = iProp;
        this.ControlText = iControl.Text;
        this.LangCode = iLangType;
        this.LangText = iControl.Text;
      }

      public LanguageItem(System.Windows.Forms.ToolStripItem iControl, String iProp, String iFormName, String iLangType)
      {
        /*if (c is TextBox) this.LangFormControls.Add(c);
				if (c is Label) this.LangFormControls.Add(c);
				if (c is ToolStripButton) this.LangFormControls.Add(c);
				if (c is ToolStripMenuItem) this.LangFormControls.Add(c);*/

        this.FormName = iFormName;
        this.ControlName = iControl.Name;
        this.ControlType = iControl.GetType().ToString();
        this.ControlProp = iProp;
        this.ControlText = iControl.Text;
        this.LangCode = iLangType;
        this.LangText = iControl.Text;
      }

      public LanguageItem(System.Windows.Forms.ToolStripMenuItem iControl, String iProp, String iFormName, String iLangType)
      {
        this.FormName = iFormName;
        this.ControlName = iControl.Name;
        this.ControlType = iControl.GetType().ToString();
        this.ControlProp = iProp;
        switch (this.ControlProp)
        {
          case "Text": this.ControlText = iControl.Text; break;
          case "ToolTipText": this.ControlText = iControl.ToolTipText; break;
        }
        this.LangCode = iLangType;
        this.LangText = iControl.Text;
      }
    }
    #endregion
  }
}
