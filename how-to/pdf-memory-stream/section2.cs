using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.PdfMemoryStream
{
    public static class Section2
    {
        public static void Run()
        {
            // Read PDF file as stream
            var fileByte = File.ReadAllBytes("sample.pdf");
            
            // Instantiate PDF object from stream
            PdfDocument pdf = new PdfDocument(fileByte);
        }
    }
}