using IronPdf;
namespace IronPdf.Examples.GettingStarted.Ironpdfengine
{
    public static class Section2
    {
        public static void Run()
        {
            Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
        }
    }
}