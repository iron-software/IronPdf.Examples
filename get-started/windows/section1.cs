using IronPdf;
namespace IronPdf.Examples.GettingStarted.Windows
{
    public static class Section1
    {
        public static void Run()
        {
            // Assuming that IronPdfEngine runs
            // remotely at 123.456.7.8:33350.
            Installation.ConnectToIronPdfHost( IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
        }
    }
}