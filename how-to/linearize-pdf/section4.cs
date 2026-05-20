using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.LinearizePdf
{
    public static class Section4
    {
        public static void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from an HTML string using C#
            var pdf = renderer.RenderHtmlAsPdf("<h1>Memory Stream</h1>");
            
            // Get the PDF binary data
            var pdfBytes = pdf.BinaryData;
            
            // Transform PDF bytes to a MemoryStream
            MemoryStream memoryStream = new MemoryStream(pdfBytes);
            
            // Save the MemoryStream as a linearized PDF
            PdfDocument.SaveAsLinearized(memoryStream, "linearize-stream.pdf");
        }
    }
}