using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nte.erp.client
{
  public partial class FormTest : Form
  {
    XDocument xmlObj = null;
    public FormTest()
    {
      InitializeComponent();
    }
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
    private void Action_Click(object sender, EventArgs e)
    {
      try
      {

        if (sender == this.button1)
        {
          Exception oEx;
          Utils.Data = new core.DataModule();
          if (Utils.Data.GetXML(File.ReadAllText(@"c:\documents\FU-19.xml"), out xmlObj))
          {

          }
        }

        if (sender == this.button2)
        {
          if (xmlObj == null)
          {
            Utils.Data = new core.DataModule();
            if (Utils.Data.GetXML(File.ReadAllText(@"c:\documents\FU-19.xml"), out xmlObj))
            {

            }
          }

          if (this.xmlObj.DocumentType != null)
          {
            string fType = this.xmlObj.DocumentType.ToString();
          }


          var res1 = this.xmlObj.Descendants().Where(p => p.Name.LocalName != "").ToList();

          var res2 = this.xmlObj.XPathEvaluate("/emails/emailAddress").ToString();

          string fRess = string.Empty;

          Dictionary<string, object> fValues = new Dictionary<string, object>();

          for (int i = 0; i < res1.Count; i++)
          {
            if (res1[i].Nodes().Count() == 1)
            {
              //fValues.Add(res1[i]., res1[i].Value);
              fRess += String.Format("{0}\t{1}/{2}={3}", i, GetParent(res1[i]), res1[i].Name.LocalName, res1[i].Value) + Environment.NewLine;
            }
          }

          XNode fNode = this.xmlObj.Root.FirstNode;

          string fStr = fNode.NodeType.ToString();
          /*foreach (XmlNode node in this.xmlObj.Root.Nodes)
          {

          }

          var reasons = this.xmlObj.Descendants("Reason").ToList();
          foreach (var reason in reasons)
          {
            Console.WriteLine(reason.Value);
          }

          foreach (var itemElement in this.xmlObj.Element("env:DocumentEnvelope").Elements("env:DocumentHeader"))
          {
            var properties = itemElement.Elements("env:SalesInvoiceId").ToList();
          }
          */
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
