using IronPdf;
namespace IronPdf.Examples.HowTo.BaseUrls
{
    public static class Section5
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Render HTML file to PDF
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("C:\\Assets\\TestInvoice1.html");
            
            // Export PDF
            pdf.SaveAs("Invoice.pdf");
        }
    }
}