using IronPdf.Editing;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section7
    {
        public static void Run()
        {
            // Load the existing PDF document.
            var pdf = PdfDocument.FromFile("invoice.pdf");
            
            // Create an HtmlStamp containing our signature image.
            var signatureStamp = new HtmlStamp("&lt;img src='assets/signature.png'/&gt;")
            {
                // Configure the stamp's position and appearance.
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = 10, // Add some space from the edge.
                Opacity = 90 // Make it slightly transparent.
            };
            
            // Apply the stamp to all pages of the PDF.
            pdf.ApplyStamp(signatureStamp);
            
            // Save the modified PDF document.
            pdf.SaveAs("official_invoice.pdf");
        }
    }
}