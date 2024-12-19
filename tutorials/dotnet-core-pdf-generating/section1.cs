using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
            pdf.SaveAs("wiki.pdf");
        }
    }
}