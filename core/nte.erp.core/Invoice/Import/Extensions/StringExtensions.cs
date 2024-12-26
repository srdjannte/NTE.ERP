using System.Text;
using System.Text.RegularExpressions;

namespace nte.erp.core.Import.Extensions
{
  public static class StringExtensions
  {
    public static StringBuilder RemoveBetween(this StringBuilder sb, string begin, string end)
    {
      Regex regex = new Regex(string.Format(@"{0}.*?{1}", begin, end));
      var str = regex.Replace(sb.ToString(), begin.Trim() + end.Trim());
      return sb.Clear().Append(str);
    }

    public static string Mask(this string source, int start, int maskLength)
    {
      return source.Mask(start, maskLength, '*');
    }

    public static string Mask(this string source, int start, int maskLength, char maskCharacter)
    {
      if (start > source.Length - 1)
      {
        throw new ArgumentException("Start position is greater than string length");
      }

      if (maskLength > source.Length)
      {
        throw new ArgumentException("Mask length is greater than string length");
      }

      if (start + maskLength > source.Length)
      {
        throw new ArgumentException("Start position and mask length imply more characters than are present");
      }

      string mask = new string(maskCharacter, maskLength);
      string unMaskStart = source.Substring(0, start);
      string unMaskEnd = source.Substring(start + maskLength, source.Length - maskLength);

      return unMaskStart + mask + unMaskEnd;
    }
  }
}
