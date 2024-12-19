using IronPdf;
namespace IronPdf.Examples.HowTo.PrintPdf
{
    public static class Section1
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Test printing</h1>");
            
            // Send the document to "Microsoft Print to PDF" printer
            pdf.Print("Microsoft Print to PDF");
        }
    }
}