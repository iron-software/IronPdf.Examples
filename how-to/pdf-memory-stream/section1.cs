using System.IO;
using IronPdf;
namespace ironpdf.PdfMemoryStream
{
    public class Section1
    {
        public void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            
            // Conversion of the URL into PDF
            Uri url = new Uri("https://ironpdf.com/how-to/pdf-memory-stream/");
            
            MemoryStream pdfAsStream = renderer.RenderUrlAsPdf(url).Stream; //Read stream
        }
    }
}