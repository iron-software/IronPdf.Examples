using IronPdf.Rendering;
using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section10
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // Apply print-specific CSS rules
            renderer.RenderingOptions.CssMediaType = PdfCssMediaType.Print;
            
            // Set custom margins in millimeters
            renderer.RenderingOptions.MarginTop = 50;
            renderer.RenderingOptions.MarginBottom = 50;
            
            // Enable background colors and images
            renderer.RenderingOptions.PrintHtmlBackgrounds = true;
            
            // Set paper size and orientation
            renderer.RenderingOptions.PaperSize = PdfPaperSize.A4;
            renderer.RenderingOptions.PaperOrientation = PdfPaperOrientation.Landscape;
            
            // Generate PDFs with all settings applied to HTML content
            var htmlContent = "<div style='background-color: #f0f0f0; padding: 20px;'><h1>Styled Content</h1></div>";
            var pdfDocument = renderer.RenderHtmlAsPdf(htmlContent);
            pdfDocument.SaveAs("styled-output.pdf");
        }
    }
}