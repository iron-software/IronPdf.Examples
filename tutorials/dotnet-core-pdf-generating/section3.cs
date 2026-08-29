using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section3
    {
        public static void Run()
        {
            // Program.cs — .NET 8 LTS-compatible
            
            // 1. Activate a license (or trial key)
            IronPdf.License.LicenseKey = "YOUR-LICENSE-KEY";
            
            // 2. Create a reusable renderer instance
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions =
                {
                    // Force A4 portrait output and apply @media print styles
                    PaperSize    = PdfPaperSize.A4,
                    CssMediaType = PdfCssMediaType.Print
                }
            };
            
            // 3. Convert Microsoft Docs home page to PDF
            using PdfDocument pdf = renderer.RenderUrlAsPdf("https://learn.microsoft.com/");
            
            // 4. Save the PDF or stream it from a Web API
            pdf.SaveAs("docs-offline-copy.pdf");
        }
    }
}