using IronPdf;
namespace IronPdf.Examples.HowTo.SanitizePdf
{
    public static class Section3
    {
        public static void Run()
        {
            // Customize Chrome render options
            var options = new ChromePdfRenderOptions();
            
            // Set bottom margin to 50 pixels
            options.MarginBottom = 50;
            
            // Import PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Sanitize with Bitmap with Chrome render options
            PdfDocument sanitizeWithBitmap = Cleaner.SanitizeWithBitmap(pdf, options);
            
            // Sanitize with SVG with Chrome render options
            PdfDocument sanitizeWithSvg = Cleaner.SanitizeWithSvg(pdf, options);
            
            // Export PDFs
            sanitizeWithBitmap.SaveAs("sanitizeWithBitmap.pdf");
            sanitizeWithSvg.SaveAs("sanitizeWithSvg.pdf");
        }
    }
}