using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section8
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");
            
            string oldText = ".NET6";
            string newText = ".NET7";
            
            // Replace text on all pages
            pdf.ReplaceTextOnAllPages(oldText, newText);
            
            pdf.SaveAs("replaceText.pdf");
        }
    }
}