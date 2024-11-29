using System;
using IronPdf;
namespace ironpdf.Datauris
{
    public class Section1
    {
        public void Run()
        {
            // Read byte from image file
            var pngBinaryData = System.IO.File.ReadAllBytes("My_image.png");
            
            // Convert bytes to base64
            var ImgDataURI = @"data:image/png;base64," + Convert.ToBase64String(pngBinaryData);
            
            // Import base64 to img tag
            var ImgHtml = $"<img src='{ImgDataURI}'>";
            
            ChromePdfRenderer Renderer = new ChromePdfRenderer();
            
            // Render the HTML string
            var pdf = Renderer.RenderHtmlAsPdf(ImgHtml);
            
            pdf.SaveAs("datauri_example.pdf");
        }
    }
}