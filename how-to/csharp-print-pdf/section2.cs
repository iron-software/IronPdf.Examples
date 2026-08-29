using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPrintPdf
{
    public static class Section2
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Get PrintDocument object
            var printDocument = pdf.GetPrintDocument();
            
            // Assign the printer name
            printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            
            // Print document
            printDocument.Print();
        }
    }
}