using IronPdf.GrpcLayer;
using IronPdf;
namespace ironpdf.IronpdfengineDocker
{
    public class Section3
    {
        public void Run()
        {
            var config = new IronPdfConnectionConfiguration();
            config.ConnectionType = IronPdfConnectionType.Docker;
            IronPdf.Installation.ConnectToIronPdfHost(config);
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF Docker!<h1>");
            pdf.SaveAs("ironpdf.pdf");
        }
    }
}