using System.Text;
using System.Xml.Linq;

namespace nte.erp.core.Import.Extensions
{
  public static class XMLDocumnetExtension
  {
    public static XDocument SanitizeXml(this StringBuilder sb)
    {
      sb = sb.Replace("<env:", "<");
      sb = sb.Replace("</env:", "</");
      sb = sb.Replace("<cbc:", "<");
      sb = sb.Replace("</cbc:", "</");
      sb = sb.Replace("<cac:", "<");
      sb = sb.Replace("</cac:", "</");
      sb = sb.Replace("<cec:", "<");
      sb = sb.Replace("</cec:", "</");
      sb = sb.Replace("<sbt:", "<");
      sb = sb.Replace("</sbt:", "</");
      sb = sb.Replace("<xsd:", "<");
      sb = sb.Replace("</xsd:", "</");

      sb = sb.Replace("CreditNote", "Invoice");
      sb = sb.Replace("CreditedQuantity", "InvoicedQuantity");

      sb = sb.RemoveBetween("<DocumentEnvelope ", ">");
      sb = sb.RemoveBetween("<Invoice ", ">");
      sb = sb.RemoveBetween("<Invoice>", "<InvoicedPrepaymentAmmount>");

      XDocument doc = XDocument.Parse(sb.ToString());

      doc.Root.RemoveEmptyChildren();

      return doc;
    }

    static void RemoveEmptyChildren(this XElement element)
    {
      element.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
    }

    static void RemoveEmptyChildren(this XElement element, XName name = null)
    {
      var children = name != null ? element.Descendants(name) : element.Descendants();
      foreach (var child in children.SelectMany(child => child.Elements()).ToArray())
      {
        if (child.IsEmpty || string.IsNullOrWhiteSpace(child.Value))
          child.Remove();
      }
    }
  }
}
