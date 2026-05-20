using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section12
    {
        public static void Run()
        {
            // Define reusable HTML template for PDF files
            var htmlTemplate = "<p>Dear [[NAME]],</p><p>Thank you for your order.</p>";
            
            // Customer names for batch PDF conversion processing
            var names = new[] { "John", "James", "Jenny" };
            
            // Create personalized PDF documents for each customer
            var renderer = new ChromePdfRenderer();
            
            foreach (var name in names)
            {
                // Replace placeholder with actual data in HTML string
                var htmlInstance = htmlTemplate.Replace("[[NAME]]", name);
            
                // Generate personalized PDF document from HTML content
                var pdf = renderer.RenderHtmlAsPdf(htmlInstance);
            
                // Save with customer-specific filename as PDF files
                pdf.SaveAs($"{name}-invoice.pdf");
            }
        }
    }
}