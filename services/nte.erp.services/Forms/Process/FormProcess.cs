using nte.erp.core.Export;
using nte.erp.core;
using nte.erp.services.invoices.Classes;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Xml.Serialization;
using static nte.erp.services.invoices.Classes.Utils;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]
  public partial class FormProcess : Form
  {
    private string ID = string.Empty;
    private List<string> Params = new List<string>();
    private ExportItem? ExportItem = null;
    private SendResponse ExportResponse = null;
    private string ExportFile = string.Empty;
    private string ExportFileDefault = "default-export.xml";
    private int CloseTTL = 15;
    public FormProcess(string[] iArgs)
    {
      InitializeComponent();
      this.Action_Load(iArgs);
      this.Action_Refresh();
      this.Action_Start();
    }

    #region Actions
    private void Action_Click(object sender, EventArgs e)
    {
      if (sender == this.doManualExec)
      {
        if (this.ManualID.Text.Trim() != "")
        {
          this.ID = this.ManualID.Text;
          this.Action_Start();
        }
        else
        {
          MessageBox.Show("Enter ID to process");
        }
      }
      if (sender == this.doOpenFile)
      {
        if ((this.OpenXmlDalog.ShowDialog() == DialogResult.OK) && (MessageBox.Show(string.Format("Set {0} as default [{1}]?", this.OpenXmlDalog.FileName, this.ExportFileDefault), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
        {
          File.Copy(this.OpenXmlDalog.FileName, this.ExportFileDefault, true);
          this.ExportFile = this.ExportFileDefault;
          if (File.Exists(this.ExportFile) && Utils.LoadExport(this.ExportFile, out this.ExportItem))
          {
            this.ItemMessage.Text = string.Empty;
            this.doItemConfig.Text = this.ExportItem.Name;
            this.doConfig.ImageKey = "gear";
          }
        }
      }
      if (sender == this.doItemConfig)
      {
        if (File.Exists(this.ExportFile))
        {
          using (FormEditor fEditor = new FormEditor(this.ExportFile))
          {
            fEditor.ShowDialog(this);
            Utils.LoadExport(this.ExportFile, out this.ExportItem);
          }
        }
        else
        {
          if (MessageBox.Show(string.Format("File {0} do not exists!\n\r\n\rOpen File Dialog?", this.ExportFile), "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
          {
            this.Action_Click(this.doOpenFile, null);
          }
        }
      }
      if (sender == this.doConfig)
      {
        this.doConfig.ContextMenuStrip.Show(this.doConfig, 0, this.doConfig.Height + 1);
      }
      if (sender == this.doService)
      {
        using (FormService fService = new FormService([]))
        {
          fService.ShowDialog(this);
        }
      }
      if (sender == this.doEditor)
      {
        using (FormEditor fEditor = new FormEditor())
        {
          fEditor.ShowDialog(this);
          if (!string.IsNullOrEmpty(fEditor.FileName))
          {
            if ((this.ExportFile.EndsWith(this.ExportFileDefault)) && (fEditor.FileName != this.ExportFileDefault))
            {
              if (MessageBox.Show(string.Format("Set {0} as default [{1}]?", fEditor.FileName, this.ExportFileDefault), "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                File.Copy(fEditor.FileName, this.ExportFileDefault, true);
                this.ExportFile = this.ExportFileDefault;
              }
            }
            if (File.Exists(this.ExportFile) && Utils.LoadExport(this.ExportFile, out this.ExportItem))
            {
              this.ItemMessage.Text = string.Empty;
              this.doItemConfig.Text = this.ExportItem.Name;
              this.doConfig.ImageKey = "gear";
            }
          }
        }
      }
      if (sender == this.doRepeat)
      {
        this.doRepeat.Visible = false;
        this.Action_Start();
      }
      if (sender == this.doStop)
      {
        this.CloseTimer.Enabled = false;
        this.doClose.Text = "Close";
        this.CloseTTL = 15;
        this.doStop.Visible = false;
      }
      if (sender == this.doClose)
      {
        this.Close();
      }
      if (sender == this.NTELink)
      {
        Process.Start(new ProcessStartInfo("http://www.nte.rs") { UseShellExecute = true });
        //System.Diagnostics.Process.Start("http://www.nte.rs");
      }
    }
    private void Action_Load(string[] iArgs)
    {
      this.ExportFile = this.ExportFileDefault;
      foreach (string arg in iArgs)
      {
        switch (arg.Trim().ToLower())
        {
          case "debug":
            Utils.IsDebug = true;
            break;
          case "silente":
            Utils.IsSilente = true;
            break;
          case "process":
            break;
          default:
            string fFileCheck = (arg.ToLower().EndsWith(".xml")) ? arg : arg + ".xml";
            if (File.Exists(fFileCheck))
            {
              this.ExportFile = fFileCheck;
            }
            else
            {
              if (!string.IsNullOrEmpty(arg.Trim()))
              {
                this.ID = arg;
              }
            }
            break;
        }
      }
      if (File.Exists(this.ExportFile))
      {
        Utils.LoadExport(this.ExportFile, out this.ExportItem);
      }
    }
    private void Action_Refresh()
    {
      if (this.ExportItem != null)
      {
        this.ItemMessage.Text = string.Empty;
        this.doItemConfig.Text = this.ExportItem.Name;
        this.doConfig.ImageKey = "gear";
        this.ItemProgress.Value = this.ItemProgress.Minimum;
        this.doStop.Visible = false;
        if (string.IsNullOrEmpty(this.ID))
        {
          this.ItemTitle.Text = "No ID!";
          if (string.IsNullOrEmpty(this.ID.Trim()))
          {
            this.ManualID.Visible = true;
            this.doManualExec.Visible = true;
            this.ItemProgress.Visible = false;
          }
        }
        else
        {
          this.ItemTitle.Text = "Loading " + this.ID;
          this.ManualID.Visible = false;
          this.doManualExec.Visible = false;
          this.ItemProgress.Visible = true;
        }
      }
      else
      {
        this.ItemTitle.Text = "Not Configuration!";
        this.ItemMessage.Text = string.Empty;
        this.doItemConfig.Text = "none";
        this.doConfig.ImageKey = "gear_information";
        this.ItemProgress.Value = this.ItemProgress.Minimum;
        this.doStop.Visible = false;
        this.ManualID.Visible = false;
        this.doManualExec.Visible = false;
        this.ItemProgress.Visible = true;
      }
    }
    private void Action_Start()
    {
      if ((this.ExportItem != null) && !string.IsNullOrEmpty(this.ID))
      {
        if (this.ItemWorker.IsBusy)
        {
          this.Message("Alredy working");
        }
        else
        {
          this.Cursor = Cursors.AppStarting;
          this.ItemProgress.Value = this.ItemProgress.Minimum;
          this.doRepeat.Visible = false;
          this.doStop.Visible = false;
          this.ItemTitle.Text = "Processing " + this.ID;
          this.Message("Started...");
          this.doClose.Text = "cancel";
          this.ItemWorker.RunWorkerAsync();
        }
      }
    }
    #endregion

    #region Workers
    private void ItemWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      string fError = string.Empty;

      if (this.ExportItem != null)
      {
        this.ItemWorker.ReportProgress(25, "Connecting to source....");
        using (SourceModule fDB = new SourceModule())
        {
          this.ItemWorker.ReportProgress(25, string.Format("Loading from {0}...", this.ExportItem.Source.Name));
          if (this.ExportItem != null && fDB.LoadData(this.ID, this.ExportItem, out fError))
          {
            this.ItemWorker.ReportProgress(50, "Transforming....");
            using (ShemaModule fConvert = new ShemaModule())
            {
              if (fConvert.LoadData(fDB.DataSet, this.ExportItem.Maps[0].Shema, out fError))
              {
                this.ItemWorker.ReportProgress(75, string.Format("Sending to {0}....", this.ExportItem.Send.Name));
                using (SendModule fWeb = new SendModule())
                {
                  this.ExportResponse = fWeb.SendData(this.ID, fConvert.Body, this.ExportItem);
                  this.ItemWorker.ReportProgress(100, "Processing Response...");
                  e.Result = true;
                }
              }
            }
          }
        }
      }
      else
      {
        fError = "Error: No Export Item";
      }

      if (!string.IsNullOrEmpty(fError))
      {
        this.ItemWorker.ReportProgress(100, fError);
        e.Result = false;
      }
      else
      {
        e.Result = true;
      }
    }
    private void ItemWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      if (e.ProgressPercentage > 0)
      {
        this.ItemProgress.Value = e.ProgressPercentage;
      }
      if (e.UserState != null && e.UserState is string)
      {
        this.Message(e.UserState.ToString());
      }
    }
    private void ItemWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      this.Cursor = Cursors.Default;
      this.doClose.Text = "Close";
      this.ItemTitle.Text = (Convert.ToBoolean(e.Result)) ? "Finished " + this.ID : "Error " + this.ID;

      if (this.ExportResponse != null)
      {
        if (this.ExportResponse.Status)
        {
          this.Message("OK");
          if (Utils.IsSilente)
          {
            this.doClose.Text = string.Format("Close [{0}]", this.CloseTTL);
            this.doStop.Visible = true;
            this.CloseTimer.Enabled = true;
          }
          else
          {
            this.doClose.Text = "Close";
          }
        }
        else
        {
          this.doStop.Visible = false;
          this.CloseTimer.Enabled = false;
          this.doRepeat.Visible = true;
          this.Message(this.ExportResponse.Error);
        }
      }
    }
    #endregion Workers

    #region Events
    private void Message(string iMsg)
    {
      Utils.Msgs.Add(new MsgItem(iMsg));
      this.ItemMessage.Text = iMsg;
      this.ItemMessage.Refresh();
    }
    private void CloseTimer_Tick(object sender, EventArgs e)
    {
      this.CloseTTL--;
      if (this.CloseTTL < 1)
      {
        this.CloseTimer.Enabled = false;
        this.Close();
      }
      else
      {
        if (!this.doStop.Visible)
        {
          this.doStop.Visible = true;
        }
        this.doClose.Text = string.Format("Close [{0}]", this.CloseTTL);
      }
    }
    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      InvoiceDB.Data.Model.Invoice fInvoice = new InvoiceDB.Data.Model.Invoice();
      fInvoice.InvoiceId = "100";// this.ManualID.Text;

      fInvoice.OrderReferenceId = "1";

      XmlSerializer x = new XmlSerializer(fInvoice.GetType());
      string fFileXml = fInvoice.InvoiceId + ".xml";

      using (FileStream fs = new FileStream(fFileXml, FileMode.Create))
      {
        x.Serialize(fs, fInvoice);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      using (FileStream fs = new FileStream("100.xml", FileMode.Open))
      {
        XmlSerializer _xSer = new XmlSerializer(typeof(InvoiceDB.Data.Model.Invoice));

        var fObj = _xSer.Deserialize(fs);

        if ((fObj is not null) && (fObj is InvoiceDB.Data.Model.Invoice))
        {
          InvoiceDB.Data.Model.Invoice oItem = (fObj as InvoiceDB.Data.Model.Invoice);
          if (oItem != null)
          {

          }
        }
      }
    }
  }
}
