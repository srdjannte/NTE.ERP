using nte.erp.services.invoices.Classes;
using System.Runtime.Versioning;

namespace nte.erp.services.invoices
{
  [SupportedOSPlatform("windows")]
  internal static class Program
  {
    private enum StartType { Process, Service, Editor };
    [STAThread]
    static void Main(string[] args)
    {
      StartType fStartType = StartType.Process;

      if (0 < args.Length)
      {
        switch (args[0].ToString().Trim().ToLower())
        {
          case "e":
          case "editor":
            fStartType = StartType.Editor;
            break;
          case "s":
          case "service":
            fStartType = StartType.Service;
            break;
          case "p":
          default:
            fStartType = StartType.Process;
            break;
        }
      }

      Utils.LoadConfig();
      ApplicationConfiguration.Initialize();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      switch (fStartType)
      {
        case StartType.Service:
          Application.Run(new FormService(args));
          break;
        case StartType.Editor:
          Application.Run(new FormEditor());
          break;
        case StartType.Process:
          Application.Run(new FormProcess(args));
          break;
      }
      Utils.Config.Save();
    }
  }
}