using IronPdf.GrpcLayer;
using IronPdf;
namespace IronPdf.Examples.HowTo.IronpdfengineDocker
{
    public static class Section2
    {
        public static void Run()
        {
            var config = new IronPdfConnectionConfiguration();
            config.ConnectionType = IronPdfConnectionType.Docker;
            IronPdf.Installation.ConnectToIronPdfHost(config);
        }
    }
}