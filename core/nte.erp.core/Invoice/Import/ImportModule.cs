using AutoMapper;
using nte.erp.core.Import.Extensions;
using nte.erp.core.Import.Response.PurchaseInvoice;
using System.Data;
using System.Reflection.Metadata;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace nte.erp.core.Import
{
  public class ImportModule
  {
    private readonly IMapper _mapper;

    public ImportModule()
    {

    }

    public DocumentEnvelope GetPurchaseInvoiceXml1(string iStrXml)
    {
      var obj = new DocumentEnvelope();

      if (!string.IsNullOrEmpty(iStrXml))
      {
        var xmlDocument = new StringBuilder(iStrXml);

        try
        {
          XDocument doc = xmlDocument.SanitizeXml();

          XmlSerializer serializer = new XmlSerializer(typeof(DocumentEnvelope));
          using (StringReader reader = new StringReader(doc.ToString()))
          {
            obj = (DocumentEnvelope)serializer.Deserialize(reader);
          }
        }
        catch (Exception ex)
        {
          string errorMessage = ex.Message;
        }
      }


      return obj;
    }

    public DataRow GetPurchaseInvoiceXml(string iStrXml)
    {
      XmlDocument xmldoc = new XmlDocument();
      XmlNodeList xmlnode;

      xmldoc.LoadXml(iStrXml);
      xmlnode = xmldoc.GetElementsByTagName("Units");
      //xmldoc.get

      for (int i = 0; i < xmlnode.Count; i++)
      {
        //string str = string.Format("ID: {0}\r\nName:{0}", xmlnode[i].ChildNodes.Item(0).InnerText, xmlnode[i].ChildNodes.Item(1).InnerText);
      }

      return null;
    }

  }
}
