using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section1
    {
        public void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
            pdf.SaveAs("wiki.pdf");
        }
    }
}