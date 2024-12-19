using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.AddImagesToPdfs
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            // Import image file binary data
            byte[] binaryData = File.ReadAllBytes("ironpdf-logo-text-dotnet.svg");
            
            // Convert the binary data to base 64
            string imgDataUri = Convert.ToBase64String(binaryData);
            
            // Embed in HTML
            string html = $"<img src='data:image/svg+xml;base64,{imgDataUri}'>";
            
            // Convert HTML to PDF
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html);
            
            // Export the PDF
            pdf.SaveAs("embedImageBase64.pdf");
        }
    }
}