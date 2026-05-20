using IronPdf;
namespace IronPdf.Examples.GettingStarted.Ironpdfengine
{
    public static class Section2
    {
        public static void Run()
        {
            // Connect to the remote IronPdfEngine
            Installation.ConnectToIronPdfHost(
                IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
            );
        }
    }
}