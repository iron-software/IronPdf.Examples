using IronPdf.GrpcLayer;
using IronPdf;
namespace IronPdf.Examples.GettingStarted.Ironpdfengine
{
    public static class Section1
    {
        public static void Run()
        {
            // Establish a connection with the remote IronPdfEngine
            // Remember to replace the IP address and port with your actual server details
            Installation.ConnectToIronPdfHost(
                IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350")
            );
            
            // Additional code for your application
        }
    }
}