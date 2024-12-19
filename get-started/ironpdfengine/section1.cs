using IronPdf;
namespace IronPdf.Examples.GettingStarted.Ironpdfengine
{
    public static class Section1
    {
        public static void Run()
        {
            // ... your code ...
            
            Installation.ConnectToIronPdfHost( IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
            
            // ... your code ...
        }
    }
}