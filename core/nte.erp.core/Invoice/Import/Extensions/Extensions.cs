using System.Runtime.Serialization.Formatters.Binary;

namespace nte.erp.core.Import.Extensions
{
  public static class Extensions
  {
    public static T DeepClone<T>(this T obj)
    {
      using (var ms = new MemoryStream())
      {
#pragma warning disable SYSLIB0011
        var formatter = new BinaryFormatter();
        formatter.Serialize(ms, obj);
        ms.Position = 0;

        return (T)formatter.Deserialize(ms);
#pragma warning restore SYSLIB0011
      }
    }
  }
}
