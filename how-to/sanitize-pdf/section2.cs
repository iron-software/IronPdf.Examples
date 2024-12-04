using System;
using IronPdf;
namespace ironpdf.SanitizePdf
{
    public class Section2
    {
        public void Run()
        {
            // Import PDF document
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            // Scan PDF
            CleanerScanResult result = Cleaner.ScanPdf(pdf);
            
            // Output the result
            Console.WriteLine(result.IsDetected);
            Console.WriteLine(result.Risks.Count);
        }
    }
}