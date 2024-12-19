using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section15
    {
        public static void Run()
        {
            IronPdf.License.LicenseKey = "YourLicenseKey";
            PdfDocument pdf = PdfDocument.FromFile("testFile.pdf");
            
            List<int> pageList = new List<int>() { 1, 2 };
            
            pdf.RasterizeToImageFiles("*.png", pageList);
        }
    }
}