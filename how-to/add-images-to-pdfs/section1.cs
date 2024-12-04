using IronPdf;
namespace ironpdf.AddImagesToPdfs
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            string html = @"<img src='https://ironsoftware.com/img/products/ironpdf-logo-text-dotnet.svg'>";
            
            // Render HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Export PDF
            pdf.SaveAs("embedImage.pdf");
        }
    }
}