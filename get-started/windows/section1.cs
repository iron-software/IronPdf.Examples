using IronPdf.GrpcLayer;
using IronPdf;
namespace IronPdf.Examples.GettingStarted.Windows
{
    public static class Section1
    {
        public static void Run()
        {
            // Configure IronPDF to connect to the remote IronPdfEngine instance
            // Replace "123.456.7.8:33350" with the actual remote host and port
            Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
        }
    }
}