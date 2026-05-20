using IronPdf;
namespace IronPdf.Examples.Tutorial.HtmlToPdf
{
    public static class Section9
    {
        public static void Run()
        {
            // Initialize ChromePdfRenderer for HTML file conversion
            var renderer = new ChromePdfRenderer();
            
            // Convert HTML file to PDF documents
            // Preserves all relative paths and linked resources in HTML
            var pdf = renderer.RenderHtmlFileAsPdf("Assets/TestInvoice1.html");
            
            // Save the HTML file as PDF 
            pdf.SaveAs("Invoice.pdf");
            
            // All CSS, JavaScript, and images load correctly in the generated PDF
        }
    }
}