using IronPdf;
namespace IronPdf.Examples.GettingStarted.InstallationOverview
{
    public static class Section6
    {
        public static void Run()
        {
            Installation.ConnectToIronPdfHost(
                IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
            );
        }
    }
}