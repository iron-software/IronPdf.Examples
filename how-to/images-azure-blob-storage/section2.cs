using IronPdf;
namespace IronPdf.Examples.HowTo.ImagesAzureBlobStorage
{
    public static class Section2
    {
        public static void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from a HTML string using C#
            var pdf = renderer.RenderHtmlAsPdf(imageTag);
            
            // Export to a file
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}