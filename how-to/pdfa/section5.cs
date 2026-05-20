using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section5
    {
        public static void Run()
        {
            PdfDocument pdf = new PdfDocument("Google.pdf");
            
            // Initialize collection of embed file as string of path
            IEnumerable<string> embedPaths = new[] { "File1.xml", "File2.png" };
            
            // Convert to Pdf/A-3B with embeded files
            pdf.ConvertToPdfA(embedPaths);
        }
    }
}