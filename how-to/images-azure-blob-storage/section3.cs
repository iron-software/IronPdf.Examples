using IronPdf;
namespace IronPdf.Examples.HowTo.ImagesAzureBlobStorage
{
    public static class Section3
    {
        public static void Run()
        {
            // The docs page has these open before the snippet; declared here so
            // the section stands on its own.
            string imageTag = "<img src='data:image/jpeg;base64,...' />";

            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from a HTML string using C#
            var pdf = renderer.RenderHtmlAsPdf(imageTag);
            
            // Export to a file
            pdf.SaveAs("imageToPdf.pdf");
        }
    }
}