using IronPdf.GrpcLayer;
using IronPdf;
namespace IronPdf.Examples.GettingStarted.IronpdfengineDocker
{
    public static class Section2
    {
        public static void Run()
        {
            // Configure for Docker container
            var config = IronPdfConnectionConfiguration.Docker;
            config.Host = "localhost";
            IronPdf.Installation.ConnectToIronPdfHost(config);
            
            // Use IronPDF
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF Docker!<h1>");
            pdf.SaveAs("ironpdf.pdf");
        }
    }
}