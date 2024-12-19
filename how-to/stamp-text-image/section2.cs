using System;
using IronPdf;
namespace IronPdf.Examples.HowTo.StampTextImage
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");
            
            // Create image stamper
            ImageStamper imageStamper = new ImageStamper(new Uri("https://ironpdf.com/img/svgs/iron-pdf-logo.svg"))
            {
                VerticalAlignment = VerticalAlignment.Top,
            };
            
            // Stamp the image stamper
            pdf.ApplyStamp(imageStamper, 0);
            
            pdf.SaveAs("stampImage.pdf");
        }
    }
}