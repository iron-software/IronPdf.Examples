using IronSoftware.Drawing;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section4
    {
        public static void Run()
        {
            // This example demonstrates various ways to add a visual image to a PDF signature.
            
            // Create a PdfSignature object.
            var signature = new PdfSignature("IronSoftware.pfx", "123456");
            
            // Define the position and size for the signature image on the first page (index 0).
            var signatureRectangle = new Rectangle(350, 750, 200, 100);
            
            // Option 1: Set the SignatureImage property directly.
            signature.SignatureImage = new PdfSignatureImage("assets/visual-signature.png", 0, signatureRectangle);
            
            // Option 2: Use the LoadSignatureImageFromFile method.
            signature.LoadSignatureImageFromFile("assets/visual-signature.png", 0, signatureRectangle);
            
            // Option 3: Load an image from a stream. This is useful for images generated in memory.
            AnyBitmap image = AnyBitmap.FromFile("assets/visual-signature.png");
            using (var imageStream = image.ToStream())
            {
                signature.LoadSignatureImageFromStream(imageStream, 0, signatureRectangle);
            }
            
            // After configuring the signature image, apply it to a PDF.
            var pdf = PdfDocument.FromFile("invoice.pdf");
            pdf.Sign(signature);
            pdf.SaveAs("VisualSignature.pdf");
            </span><br class="ProseMirror-trailingBreak">
        }
    }
}