using System.Linq;
using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section2
    {
        public static void Run()
        {
            // Instantiate Renderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Create a PDF from a URL
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");
            
            // Access DOM Objects
            var objects = pdf.Pages.First().ObjectModel;
        }
    }
}