using IronPdf;
namespace IronPdf.Examples.HowTo.FindReplaceText
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");
            
            string oldText = ".NET6";
            string newText = ".NET7";
            
            // Replace text on page 1
            pdf.ReplaceTextOnPage(0, oldText, newText);
            
            pdf.SaveAs("replaceTextOnSinglePage.pdf");
        }
    }
}