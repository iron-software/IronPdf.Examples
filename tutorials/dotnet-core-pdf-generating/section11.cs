using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section11
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set rendering options
            renderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.A4;
            renderer.RenderingOptions.PaperOrientation = IronPdf.Rendering.PdfPaperOrientation.Portrait;
            
            renderer.RenderHtmlFileAsPdf(@"testFile.html").SaveAs("GeneratedFile.pdf");
        }
    }
}