using IronPdf;
namespace IronPdf.Examples.GettingStarted.Azure
{
    public static class Section1
    {
        public static void Run()
        {
            System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
        }
    }
}