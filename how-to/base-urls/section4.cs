using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section4
    {
        public void Run()
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