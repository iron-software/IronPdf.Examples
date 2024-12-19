using IronPdf;
namespace IronPdf.Examples.HowTo.PrintPdf
{
    public static class Section3
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");
            
            // Print to file
            pdf.PrintToFile("");
        }
    }
}