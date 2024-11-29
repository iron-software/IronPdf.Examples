using IronPdf;
namespace ironpdf.FindReplaceText
{
    public class Section1
    {
        public void Run()
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