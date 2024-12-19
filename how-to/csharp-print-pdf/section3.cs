using System.Drawing.Printing;
using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPrintPdf
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Get PrintDocument object
            var printDocument = pdf.GetPrintDocument();
            
            // Set printer resolution
            printDocument.DefaultPageSettings.PrinterResolution = new PrinterResolution
            {
                Kind = PrinterResolutionKind.Custom,
                X = 1200,
                Y = 1200
            };
            
            // Print document
            printDocument.Print();
        }
    }
}