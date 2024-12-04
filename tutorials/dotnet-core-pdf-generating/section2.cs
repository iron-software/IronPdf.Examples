using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section2
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>");
            pdf.SaveAs("HtmlString.pdf");
        }
    }
}