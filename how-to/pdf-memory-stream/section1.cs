using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.PdfMemoryStream
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            
            // Conversion of the URL into PDF
            Uri url = new Uri("https://ironpdf.com/how-to/pdf-memory-stream/");
            
            MemoryStream pdfAsStream = renderer.RenderUrlAsPdf(url).Stream; //Read stream
        }
    }
}