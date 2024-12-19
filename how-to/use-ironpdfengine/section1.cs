using IronPdf;
namespace IronPdf.Examples.HowTo.UseIronpdfengine
{
    public static class Section1
    {
        public static void Run()
        {
            Installation.ConnectToIronPdfHost(IronPdf.GrpcLayer.IronPdfConnectionConfiguration.RemoteServer("123.456.7.8:33350"));
        }
    }
}