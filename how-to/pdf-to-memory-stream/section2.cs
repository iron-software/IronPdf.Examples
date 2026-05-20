using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.PdfToMemoryStream
{
    public static class Section2
    {
        public static void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // Convert the URL into PDF
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://ironpdf.com/");
            
            // Export PDF as Stream
            MemoryStream pdfAsStream = pdf.Stream;
            
            // Export PDF as Byte Array
            byte[] pdfAsByte = pdf.BinaryData;
        }
    }
}