using System.Drawing.Printing;
using IronPdf;
namespace IronPdf.Examples.HowTo.PrintPdf
{
    public static class Section4
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Testing</h1>");
            
            PrinterSettings settings = new PrinterSettings() {
                PrinterName = "Microsoft Print to PDF",
            
                // Number of Copy
                Copies = 2,
            
                // Page range to print
                FromPage = 2,
                ToPage = 4,
            };
            
            PrintDocument document = pdf.GetPrintDocument(settings);
            
            // Print
            document.Print();
        }
    }
}