using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfAssetsAndPerformanceCsharp
{
    public static class Section4
    {
        public static void Run()
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