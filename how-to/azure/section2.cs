using IronPdf;
namespace IronPdf.Examples.HowTo.Azure
{
    public static class Section2
    {
        public static void Run()
        {
            System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
        }
    }
}