namespace nte.erp.client
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      //ApplicationConfiguration.Initialize();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Utils.LoadConfig();
      Application.Run(new FormMain());
      //Application.Run(new FormTest());
    }
  }
}