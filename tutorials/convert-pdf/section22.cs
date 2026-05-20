using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section22
    {
        public static void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Configure render options
            renderer.RenderingOptions = new ChromePdfRenderOptions
            {
                // Enable table of content feature
                TableOfContents = TableOfContentsTypes.WithPageNumbers,
            };
            
            PdfDocument pdf = renderer.RenderHtmlFileAsPdf("tableOfContent.html");
            
            pdf.SaveAs("tableOfContents.pdf");
        }
    }
}