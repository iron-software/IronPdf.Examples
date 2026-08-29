using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPrintPdf
{
    public static class Section5
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Get PrintDocument object
            var printDocument = pdf.GetPrintDocument();
            
            // Subscribe to the PrintPage event
            var printedPages = 0;
            printDocument.PrintPage += (sender, args) => printedPages++;
            
            // Print document
            printDocument.Print();
        }
    }
}