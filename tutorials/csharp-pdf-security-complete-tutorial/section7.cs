using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpPdfSecurityCompleteTutorial
{
    public static class Section7
    {
        public static void Run()
        {
            // Import PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Sanitize with Bitmap
            PdfDocument sanitizeWithBitmap = Cleaner.SanitizeWithBitmap(pdf);
            
            // Sanitize with SVG
            PdfDocument sanitizeWithSvg = Cleaner.SanitizeWithSvg(pdf);
            
            // Export PDFs
            sanitizeWithBitmap.SaveAs("sanitizeWithBitmap.pdf");
            sanitizeWithSvg.SaveAs("sanitizeWithSvg.pdf");
        }
    }
}