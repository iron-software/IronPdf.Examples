using IronPdf;
namespace ironpdf.ImagesAzureBlobStorage
{
    public class Section1
    {
        public void Run()
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