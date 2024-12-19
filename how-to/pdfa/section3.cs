using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section3
    {
        public static void Run()
        {
            // Use the Chrome Renderer to make beautiful HTML designs from URLs
            var chromeRenderer = new ChromePdfRenderer();
            
            // Render a Website as a PdfDocument object using Chrome
            PdfDocument pdf = chromeRenderer.RenderUrlAsPdf("https://www.microsoft.com");
            
            // Use the SaveAsPdfA method to save to file
            pdf.SaveAsPdfA("website-accessible.pdf", PdfAVersions.PdfA3b);
        }
    }
}