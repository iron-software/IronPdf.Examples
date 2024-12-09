using IronPdf.GrpcLayer;
using IronPdf;
namespace ironpdf.IronpdfengineDocker
{
    public class Section2
    {
        public void Run()
        {
            var config = new IronPdfConnectionConfiguration();
            config.ConnectionType = IronPdfConnectionType.Docker;
            IronPdf.Installation.ConnectToIronPdfHost(config);
        }
    }
}