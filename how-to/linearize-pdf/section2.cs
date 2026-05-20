using IronPdf;
namespace IronPdf.Examples.HowTo.LinearizePdf
{
    public static class Section2
    {
        public static void Run()
        {
            // Instantiate Renderer
            var renderer = new ChromePdfRenderer();
            
            // Create a PDF from an HTML string using C#
            var pdf = renderer.RenderHtmlAsPdf("<h1>Pdf Bytes</h1>");
            
            // Get the PDF binary data
            var pdfBytes = pdf.BinaryData;
            
            // Save the PDF binary data as a linearized PDF file
            PdfDocument.SaveAsLinearized(pdfBytes, "linearize-from-bytes.pdf");
        }
    }
}