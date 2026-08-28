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
            var signatureStamp = new IronPdf.Editing.HtmlStamper("<img src='assets/signature.png'/>")
            {
                // Configure the stamp's position and appearance.
                VerticalAlignment = IronPdf.Editing.VerticalAlignment.Bottom,
                HorizontalAlignment = IronPdf.Editing.HorizontalAlignment.Right,
                VerticalOffset = new IronPdf.Editing.Length(10),
                HorizontalOffset = new IronPdf.Editing.Length(10),
                Opacity = 90 // Make it slightly transparent.
            };
            
            // Apply the stamp to all pages of the PDF.
            pdf.ApplyStamp(signatureStamp);
            
            // Save the modified PDF document.
            pdf.SaveAs("official_invoice.pdf");
        }
    }
}