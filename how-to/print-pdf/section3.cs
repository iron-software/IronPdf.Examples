using IronPdf;
namespace ironpdf.PrintPdf
{
    public class Section3
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");
            
            // Print to file
            pdf.PrintToFile("");
        }
    }
}