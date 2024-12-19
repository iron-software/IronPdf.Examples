using IronPdf.GrpcLayer;
using IronPdf;
namespace IronPdf.Examples.HowTo.IronpdfengineDocker
{
    public static class Section3
    {
        public static void Run()
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