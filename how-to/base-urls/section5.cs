using IronPdf;
namespace ironpdf.BaseUrls
{
    public class Section5
    {
        public void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Set additional CSS url
            renderer.RenderingOptions.CustomCssUrl = "./style.css";
            
            // Render HTML file to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            
            // Export PDF
            pdf.SaveAs("tryCss.pdf");
        }
    }
}